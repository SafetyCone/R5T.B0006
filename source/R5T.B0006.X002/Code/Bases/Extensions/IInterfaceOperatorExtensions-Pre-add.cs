using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Instances = R5T.B0006.X002.Instances;


namespace R5T.B0006.X002
{
    using N8;


    public static partial class IInterfaceOperatorExtensions
    {
        public static InterfaceDeclarationSyntax PreAdd(this IInterfaceOperator _,
            InterfaceDeclarationSyntax @interface)
        {
            var output = _.PreAdd_20220502(@interface);
            return output;
        }
    }
}


namespace R5T.B0006.X002.N8
{
    public static partial class IInterfaceOperatorExtensions
    {
        public static InterfaceDeclarationSyntax PreAdd_20220502(this IInterfaceOperator _,
            InterfaceDeclarationSyntax @interface)
        {
            // Do nothing.

            return @interface;
        }
    }
}