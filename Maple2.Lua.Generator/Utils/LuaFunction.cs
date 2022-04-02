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
            builder.AppendLine($"    lua_getglobal(state, \"{luaFunctionName}\");");
            foreach (IParameterSymbol parameter in parameters) {
                switch (ToLuaType(parameter.Type)) {
                    case "string":
                        builder.AppendLine($"    lua_pushstring(state, {parameter.Name});");
                        break;
                    case "number":
                        builder.AppendLine($"    lua_pushnumber(state, {parameter.Name});");
                        break;
                    case "boolean":
                        builder.AppendLine($"    lua_pushboolean(state, {parameter.Name} ? 1 : 0);");
                        break;
                }
            }
            
            builder.AppendLine($@"
    var code = lua_pcall(state, {parameters.Count}, -1, 0);
    if (code != 0) {{
        string error = $""Error {{lua_status(state)}}|{{code}}: {{lua_tostring(state, -1)?.ToString()}}"";
        throw new InvalidOperationException(error);
    }}
");

            if (returnType.Name != "Void") {
                switch (ToLuaType(returnType)) {
                    case "string":
                        builder.AppendLine("    var result = lua_tostring(state, -1).ToString();");
                        break;
                    case "number":
                        builder.AppendLine("    var result = lua_tonumber(state, -1);");
                        break;
                    case "boolean":
                        builder.AppendLine("    var result = lua_toboolean(state, -1);");
                        break;
                }
                builder.AppendLine("    lua_settop(state, 0); // Clear stack\n");
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
