using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Instances = R5T.B0006.X002.Instances;


namespace System
{
    public static class BaseMethodDeclarationSyntaxExtensions
    {
        public static T AddBodyStatements_WithIndentation<T>(this T method,
            params StatementSyntax[] statements)
            where T : BaseMethodDeclarationSyntax
        {
            // Indent statements as if the method had zero indentation.
            var statementsIndentationTabCount = 1;

            var output = method.AddBodyStatements_WithIndentation(
                statements,
                Instances.Indentation.ByTabCount_SyntaxTriviaList(statementsIndentationTabCount));

            return output;
        }
    }
}
