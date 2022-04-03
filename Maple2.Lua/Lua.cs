using KopiLua;
using LuaGenerator;
using static KopiLua.Lua;

namespace Maple2.Lua;

public partial class Lua : IDisposable {
    private const string RESOURCE_NAME = "Maple2.Lua.luapack.o";
    
    private readonly LuaState state;
    
    public Lua(string locale) {
        state = LuaOpen();
        if (state == null) {
            throw new NullReferenceException("Failed to call lua_open");
        }
        
        LuaLOpenLibs(state);
        // sub_5B0490 - mapping: print, printErr, printWarn, printError to functions
        
        // Load embedded resource
        var lf = new LoadF {
            f = typeof(Lua).Assembly.GetManifestResourceStream(RESOURCE_NAME)
        };
        if (LuaLoad(state, GetF, lf, LuaToString(state, -1)) != 0) {
            throw new FileLoadException($"Failed to load {RESOURCE_NAME}");
        }
        
        // Initialize function definitions
        LuaCall(state, 0, 0);

        SetLocale(locale);
    }
    
    [GlobalFunction(Name = "set_locale")]
    public partial void SetLocale(string locale);
    
    [GlobalFunction(Name = "get_locale")]
    public partial string GetLocale();

    public string Dump(string name) {
        LuaGetGlobal(state, "dump");
        LuaGetGlobal(state, name);

        if (LuaPCall(state, 1, -1, 0) != 0) {
            throw new InvalidOperationException(LuaToString(state, -1).ToString());
        }

        string result = LuaToString(state, 1).ToString();
        LuaSetTop(state, 0); // Clear stack

        return result;
    }

    [GlobalFunction(Name = "clip_value")]
    public partial double ClipValue(double value, double min, double max);

    [GlobalFunction(Name = "round")]
    public partial double Round(double value, int digits);
    
    [GlobalFunction(Name = "floor")]
    public partial double Floor(double value, int digits);
    
    [GlobalFunction(Name = "ceil")]
    public partial double Ceiling(double value, int digits);

    // I don't know why this function exists...
    [GlobalFunction(Name = "significant_figure")]
    public partial double SignificantFigure(double value, int digits);

    public void Dispose() {
        LuaClose(state);
    }
}
