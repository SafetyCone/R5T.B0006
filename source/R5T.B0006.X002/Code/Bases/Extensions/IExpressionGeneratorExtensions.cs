using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X002.Instances;


namespace System
{
    public static class IExpressionGeneratorExtensions
    {
        public static InvocationExpressionSyntax Invocation(this IExpressionGenerator _,
            ExpressionSyntax expression,
            params ArgumentSyntax[] arguments)
        {
            var output = Instances.SyntaxFactory.Invocation(
                expression,
                arguments);

            return output;
        }

        public static InvocationExpressionSyntax Invocation(this IExpressionGenerator _,
            ExpressionSyntax expression,
            IEnumerable<string> argumentNames)
        {
            var arguments = argumentNames
                .Select(x => Instances.SyntaxFactory.Argument(x))
                .Now();

            var output = _.Invocation(
                expression,
                arguments);

            return output;
        }

        public static SimpleLambdaExpressionSyntax Lambda(this IExpressionGenerator _,
            string parameterName,
            CSharpSyntaxNode syntaxNode)
        {
            var parameter = Instances.SyntaxFactory.Parameter(parameterName);

            var output = Instances.SyntaxFactory.SimpleLambda(
                parameter,
                syntaxNode);

            return output;
        }

        public static MemberAccessExpressionSyntax MemberAccess(this IExpressionGenerator _,
            string memberedName,
            string memberName)
        {
            var memberedNameSyntax = Instances.SyntaxFactory.Name(memberedName);

            var output = _.MemberAccess(
                memberedNameSyntax,
                memberName);

            return output;
        }

        public static MemberAccessExpressionSyntax MemberAccess(this IExpressionGenerator _,
           ExpressionSyntax expression,
           string memberName)
        {
            var memberNameSyntax = Instances.SyntaxFactory.Name(memberName);

            var output = Instances.SyntaxFactory.MemberAccess(
                expression,
                memberNameSyntax);

            return output;
        }
    }
}
