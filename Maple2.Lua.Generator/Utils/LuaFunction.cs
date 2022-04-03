using System.CodeDom.Compiler;
using Microsoft.CodeAnalysis;

namespace Maple2.Lua.Generator.Utils; 

public class LuaFunction : IDisposable {
    private readonly string name;
    private readonly ITypeSymbol returnType;
    private readonly IList<IParameterSymbol> parameters;
    private readonly string luaFunctionName;

    private readonly StringWriter output;
    private readonly IndentedTextWriter writer;

    public LuaFunction(IMethodSymbol method, string luaName) {
        name = method.Name;
        returnType = method.ReturnType;
        parameters = method.Parameters;
        luaFunctionName = luaName;
        
        output = new StringWriter();
        writer = new IndentedTextWriter(output, "    ");
        Build();
    }

    public override string ToString() {
        return output.ToString();
    }

    private void Build() {
        string @params = string.Join(", ", parameters.Select(p => $"{p.Type} {p.Name}"));
        writer.WriteLine($"public partial {returnType} {name}({@params}) {{");
        writer.Indent++;
        writer.WriteLine($"LuaGetGlobal(state, \"{luaFunctionName}\");");
        foreach (IParameterSymbol parameter in parameters) {
            switch (ToLuaType(parameter.Type)) {
                case "string":
                    writer.WriteLine($"LuaPushString(state, {parameter.Name});");
                    break;
                case "number":
                    writer.WriteLine($"LuaPushNumber(state, {parameter.Name});");
                    break;
                case "integer":
                    writer.WriteLine($"LuaPushInteger(state, {parameter.Name});");
                    break;
                case "boolean":
                    writer.WriteLine($"LuaPushBoolean(state, {parameter.Name} ? 1 : 0);");
                    break;
            }
        }
        
        writer.WriteLine($@"
    var code = LuaPCall(state, {parameters.Count}, -1, 0);
    switch (code) {{
        case LUA_ERRRUN:
            throw new ArgumentException($""LUA_ERRRUN({name}): {{LuaToString(state, -1)?.ToString()}}"");
        case LUA_ERRMEM:
            throw new OutOfMemoryException(""LUA_ERRMEM({name}): memory allocation error"");
        case LUA_ERRERR:
            throw new InvalidOperationException(""LUA_ERRERR({name}): failed to handle error"");
        case 0:
            break; // OK
        default:
            throw new InvalidOperationException($""{name} - Internal error code: {{code}}"");
    }}
");

        if (returnType.Name != "Void") {
            var types = new List<ITypeSymbol>();
            if (returnType.IsTupleType && returnType is INamedTypeSymbol tupleType) {
                foreach (IFieldSymbol element in tupleType.TupleElements) {
                    types.Add(element.Type);
                }
            } else {
                types.Add(returnType);
            }
            
            var vars = new List<string>(types.Count);
            for (int i = 1; i <= types.Count; i++) {
                ITypeSymbol type = types[i - 1];
                if (type.NullableAnnotation == NullableAnnotation.Annotated) {
                    writer.WriteLine($"{type} result{i} = null;");
                    writer.WriteLine($"if (LuaGetTop(state) >= {i}) {{");
                    writer.Indent++;
                } else {
                    writer.WriteLine($"{type} result{i};");
                }
                switch (ToLuaType(type)) {
                    case "string":
                        writer.WriteLine($"result{i} = LuaToString(state, {i}).ToString();");
                        break;
                    case "number":
                        writer.WriteLine($"result{i} = ({type})LuaToNumber(state, {i});");
                        break;
                    case "integer":
                        writer.WriteLine($"result{i} = ({type})LuaToInteger(state, {i});");
                        break;
                    case "boolean":
                        writer.WriteLine($"result{i} = LuaToBoolean(state, {i});");
                        break;
                }
                if (type.NullableAnnotation == NullableAnnotation.Annotated) {
                    writer.Indent--;
                    writer.WriteLine("}");
                }

                vars.Add($"result{i}");
            }

            writer.WriteLine("LuaSetTop(state, 0); // Clear stack\n");
            writer.WriteLine($"return ({string.Join(", ", vars)});");
        }

        writer.Indent--;
        writer.WriteLine("}");
    }

    private static string ToLuaType(ITypeSymbol type) {
        if (type.NullableAnnotation == NullableAnnotation.Annotated && type is INamedTypeSymbol nullableType) {
            type = nullableType.TypeArguments.FirstOrDefault(nullableType.ConstructedFrom);
        }
        switch (type.Name) {
            case "String":
                return "string";
            case "Single": case "Double":
            case "Int64": case "UInt64":
                return "number";
            case "Byte": case "SByte":
            case "Int16": case "UInt16":
            case "Int32": case "UInt32":
                return "integer";
            case "Boolean":
                return "boolean";
            default:
                throw new Exception($"invalid lua type: \"{type.Name}\"");
        }
    }

    public void Dispose() {
        writer?.Dispose();
        output?.Dispose();
    }
}
