using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Maple2.Lua.Generator.Utils; 

internal static class Extensions {
    public static Compilation AddSource(this Compilation compilation, string source) {
        var options = (compilation as CSharpCompilation)?.SyntaxTrees[0].Options as CSharpParseOptions;
        SyntaxTree attributeSyntaxTree =
            CSharpSyntaxTree.ParseText(SourceText.From(source, Encoding.UTF8), options);
        return compilation.AddSyntaxTrees(attributeSyntaxTree);
    }
    
    public static SourceText LoadSource(this Assembly assembly, string fileName) {
        string resourceName = $"Maple2.Lua.Generator.Resource.{fileName}";
        using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        using (var reader = new StreamReader(stream)) {
            return SourceText.From(reader.ReadToEnd(), Encoding.UTF8);
        }
    }

    public static IEnumerable<IMethodSymbol> WithAttribute(this IEnumerable<IMethodSymbol> symbols,
            INamedTypeSymbol attributeSymbol) {
        return symbols.Where(symbol => symbol.GetAttribute(attributeSymbol) != null);
    }
    
    public static AttributeData GetAttribute(this IMethodSymbol method, ISymbol attribute) {
        return method.GetAttributes()
            .SingleOrDefault(data => SymbolEqualityComparer.Default.Equals(data.AttributeClass, attribute));
    }
    
    public static IEnumerable<IMethodSymbol> Methods(this IEnumerable<MethodDeclarationSyntax> methods,
            Compilation compilation) {
        return methods.Select(method => {
            SemanticModel model = compilation.GetSemanticModel(method.SyntaxTree);
            return model.GetDeclaredSymbol(method);
        });
    }
    
    public static IList<INamedTypeSymbol> ContainingTypes(this ISymbol symbol) {
        List<INamedTypeSymbol> containingTypes = new List<INamedTypeSymbol>();
        INamedTypeSymbol containingType = symbol.ContainingType;
        while (containingType != null) {
            containingTypes.Add(containingType);
            containingType = containingType.ContainingType;
        }

        containingTypes.Reverse();
        return containingTypes;
    }
    
    public static T GetValueOrDefault<T>(this AttributeData data, string name, T @default) {
        TypedConstant constant = data.NamedArguments.SingleOrDefault(pair => pair.Key == name).Value;
        if (constant.Value is T value) {
            return value;
        }

        return @default;
    }
}
