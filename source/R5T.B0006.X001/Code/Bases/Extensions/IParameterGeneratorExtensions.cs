using System;
using System.Linq;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X001.Instances;


namespace System
{
    public static class IParameterGeneratorExtensions
    {
        public static ParameterSyntax ParseParameterFromText(this IParameterGenerator _,
            string text)
        {
            var output = SyntaxFactory.ParseParameterList(text)
                .Parameters
                // Throw if more or less than one.
                .Single();

            return output;
        }

        public static ParameterSyntax GetParameter(this IParameterGenerator _,
            string typeName,
            string name)
        {
            var text = Instances.ParameterOperator.GetParameterText_Latest(
                typeName,
                name);

            var parameter = _.ParseParameterFromText(text);
            return parameter;
        }
    }
}
