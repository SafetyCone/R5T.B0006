using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X002.Instances;


namespace System
{
    using N8;


    public static class IMethodGeneratorExtensions
    {
        public static MethodDeclarationSyntax PublicStatic(this IMethodGenerator _,
               string methodName,
               string returnType)
        {
            var text = $"public static {returnType} {methodName}{Instances.Syntax.EmptyParentheses()}";

            var output = Instances.SyntaxFactory.ParseMethodDeclaration(text)
                .PostCreationActions()
                ;

            return output;
        }
    }
}
