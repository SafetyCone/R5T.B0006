using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X002.Instances;


namespace System
{
    public static class IStatementGeneratorExtensions
    {
        public static ReturnStatementSyntax ReturnIdentifier(this IStatementGenerator _,
            string identifierName)
        {
            var output = Instances.SyntaxFactory.Return(identifierName)
                .NormalizeWhitespace()
                ;

            return output;
        }
    }
}
