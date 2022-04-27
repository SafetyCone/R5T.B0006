using System;

using R5T.Magyar;

using R5T.B0006;


namespace System
{
    public static class IParameterOperatorExtensions
    {
        public static string GetParameterText_Latest(this IParameterOperator _,
            string typeName,
            string name)
        {
            var output = $"{typeName}{Strings.Space}{name}";
            return output;
        }
    }
}
