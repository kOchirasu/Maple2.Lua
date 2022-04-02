using System.Diagnostics;
using System.Reflection;
using System.Text;
using Maple2.Lua.Generator.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Maple2.Lua.Generator; 

[Generator]
public class GlobalFunctionGenerator : ISourceGenerator {
    private static readonly SourceText attributeSource =
        Assembly.GetExecutingAssembly().LoadSource("GlobalFunctionAttribute.cs");

    private static readonly string attributeNamespace = "LuaGenerator";
    private static readonly string attributeName = "GlobalFunctionAttribute";
    
    public void Initialize(GeneratorInitializationContext context) {
        // Register a syntax receiver that will be created for each generation pass
        context.RegisterForSyntaxNotifications(() => new AttributeSyntaxReceiver());
    }

    public void Execute(GeneratorExecutionContext context) {
        // if (!Debugger.IsAttached) {
        //     Debugger.Launch();
        // }
        
        var test = Assembly.GetExecutingAssembly().LoadSource("GlobalFunctionAttribute.cs");
        // Register the attribute source
        context.AddSource(attributeName, attributeSource);

        if (context.SyntaxReceiver is not AttributeSyntaxReceiver receiver) {
            return;
        }

        Compilation compilation = context.Compilation.AddSource(attributeSource.ToString());
        INamedTypeSymbol attributeSymbol = compilation.GetTypeByMetadataName($"{attributeNamespace}.{attributeName}");

        IEnumerable<IGrouping<ISymbol, IMethodSymbol>> classGroups = receiver.Methods.Methods(compilation)
            .WithAttribute(attributeSymbol)
            .GroupBy(method => method.ContainingType, SymbolEqualityComparer.Default);

        foreach (IGrouping<ISymbol, IMethodSymbol> group in classGroups) {
            var hintName = new StringBuilder($"[{group.Key.ContainingNamespace.Name}]");
            foreach (INamedTypeSymbol containingType in group.Key.ContainingTypes()) {
                hintName.Append($"{containingType.Name}.");
            }

            hintName.Append($"{group.Key.Name}_GlobalFunction.cs");

            var builder = new SourceBuilder(group.Key.ContainingNamespace);
            builder.Imports.AddRange(new[] {
                "System",
                "static KopiLua.Lua",
            });
            builder.Classes.AddRange(group.Key.ContainingTypes().Select(symbol => symbol.Name));
            builder.Classes.Add(group.Key.Name);

            try {
                foreach (IMethodSymbol method in group) {
                    AttributeData attributeData = method.GetAttribute(attributeSymbol);
                    string luaName = attributeData.GetValueOrDefault("Name", method.Name);

                    var luaFunction = new LuaFunction(method, luaName);
                    builder.Code.Add(luaFunction.ToString());
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }

            context.AddSource(hintName.ToString(), SourceText.From(builder.Build(), Encoding.UTF8));
        }
    }
    
    public static SourceText LoadSource(Assembly assembly, string fileName) {
        string resourceName = $"Maple2.Lua.Generator.Resource.{fileName}";
        using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        using (var reader = new StreamReader(stream)) {
            return SourceText.From(reader.ReadToEnd(), Encoding.UTF8);
        }
    }
}
