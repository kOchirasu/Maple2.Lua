using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Maple2.Lua.Generator.Utils; 

internal class AttributeSyntaxReceiver : ISyntaxReceiver {
    public HashSet<TypeDeclarationSyntax> Types { get; } = new HashSet<TypeDeclarationSyntax>();
    public HashSet<MethodDeclarationSyntax> Methods { get; } = new HashSet<MethodDeclarationSyntax>();

    public void OnVisitSyntaxNode(SyntaxNode syntaxNode) {
        // any method with at least one attribute is a candidate for property generation
        if (syntaxNode is MethodDeclarationSyntax {AttributeLists.Count: > 0} method) {
            Methods.Add(method);
            // if (!method.Modifiers.Any(modifier => modifier.IsKind(SyntaxKind.StaticKeyword))) {
            //     return;
            // }
            //
            // if (method.Ancestors().OfType<TypeDeclarationSyntax>().LastOrDefault() is { } type) {
            //     Methods.Add(method);
            //     Types.Add(type);
            // }
        }
    }
}
