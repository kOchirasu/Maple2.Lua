namespace Maple2.Lua.Generator.Utils; 

public class LuaHelper {
    public const string GET_STRING = $@"
private string GetString(lua_State state, int index) {{
    if (lua_gettop(state) >= index) {{
        return lua_tostring(state, index);
    }}
}}
";
    
    public const string GET_NUMBER = $@"
private double GetNumber(lua_State state, int index) {{
    if (lua_gettop(state) >= index) {{
        return lua_tonumber(state, index);
    }}
}}
";
    
    public const string GET_BOOLEAN = $@"
private bool GetBoolean(lua_State state, int index) {{
    if (lua_gettop(state) >= index) {{
        return lua_toboolean(state, index) != -1;
    }}
    return false;
}}
";
}
