using System.Text;
using Microsoft.CodeAnalysis;

namespace Maple2.Lua.Generator.Utils; 

public class LuaFunction {
        private readonly string name;
        private readonly ITypeSymbol returnType;
        private readonly IList<IParameterSymbol> parameters;
        private readonly string luaFunctionName;

        public LuaFunction(IMethodSymbol method, string luaName) {
            name = method.Name;
            returnType = method.ReturnType;
            parameters = method.Parameters;
            luaFunctionName = luaName;
        }

        public override string ToString() {
            var builder = new StringBuilder();
            string @params = string.Join(", ", parameters.Select(p => $"{p.Type} {p.Name}"));
            builder.AppendLine($"public partial {returnType} {name}({@params}) {{");
            builder.AppendLine($"    LuaGetGlobal(state, \"{luaFunctionName}\");");
            foreach (IParameterSymbol parameter in parameters) {
                switch (ToLuaType(parameter.Type)) {
                    case "string":
                        builder.AppendLine($"    LuaPushString(state, {parameter.Name});");
                        break;
                    case "number":
                        builder.AppendLine($"    LuaPushNumber(state, {parameter.Name});");
                        break;
                    case "boolean":
                        builder.AppendLine($"    LuaPushBoolean(state, {parameter.Name} ? 1 : 0);");
                        break;
                }
            }
            
            builder.AppendLine($@"
    var code = LuaPCall(state, {parameters.Count}, -1, 0);
    switch (code) {{
        case LUA_ERRRUN:
            throw new ArgumentException($""LUA_ERRRUN: {{LuaToString(state, -1)?.ToString()}}"");
        case LUA_ERRMEM:
            throw new OutOfMemoryException(""LUA_ERRMEM: memory allocation error"");
        case LUA_ERRERR:
            throw new InvalidOperationException(""LUA_ERRERR: failed to handle error"");
        case 0:
            break; // OK
        default:
            throw new InvalidOperationException($""Internal error code: {{code}}"");
    }}
");

            if (returnType.Name != "Void") {
                switch (ToLuaType(returnType)) {
                    case "string":
                        builder.AppendLine("    var result = LuaToString(state, -1).ToString();");
                        break;
                    case "number":
                        builder.AppendLine("    var result = LuaToNumber(state, -1);");
                        break;
                    case "boolean":
                        builder.AppendLine("    var result = LuaToBoolean(state, -1);");
                        break;
                }
                builder.AppendLine("    LuaSetTop(state, 0); // Clear stack\n");
                builder.AppendLine($"    return ({returnType})result;");
            }

            builder.AppendLine("}");
            return builder.ToString();
        }

        private string ToLuaType(ITypeSymbol type) {
            switch (type.Name) {
                case "String":
                    return "string";
                case "Single": case "Double":
                case "Byte": case "SByte":
                case "Int16": case "UInt16":
                case "Int32": case "UInt32":
                case "Int64": case "UInt64":
                    return "number";
                case "Boolean":
                    return "boolean";
                default:
                    throw new Exception($"invalid lua type: \"{type.Name}\"");
            }
        }
    }
