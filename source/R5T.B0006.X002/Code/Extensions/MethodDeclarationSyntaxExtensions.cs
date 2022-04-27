using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Instances = R5T.B0006.X002.Instances;


namespace N8
{
    public static class IMethodGeneratorExtensions
    {
        public static MethodDeclarationSyntax PostCreationActions(this MethodDeclarationSyntax methodDeclarationSyntax,
            bool addBody = true)
        {
            var output = methodDeclarationSyntax
                .ModifyIf_Synchronous(
                    addBody,
                    xMethod => xMethod.AddInitialBody())
                .SetBracesLineIndentation(
                    // Set brace indentation as if method had no identation.
                    Instances.LineIndentation.NewLine());

            return output;
        }
    }
}
