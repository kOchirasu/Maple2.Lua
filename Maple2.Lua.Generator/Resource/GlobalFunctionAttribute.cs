namespace LuaGenerator; 

[AttributeUsage(AttributeTargets.Method)]
public class GlobalFunctionAttribute : Attribute {
    public GlobalFunctionAttribute() { }
    
    public string Name { get; set; }
}
