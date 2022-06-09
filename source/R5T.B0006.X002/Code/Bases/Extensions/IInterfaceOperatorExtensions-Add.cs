using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using R5T.B0006.X002;

using Instances = R5T.B0006.X002.Instances;


namespace System
{
    public static partial class IInterfaceOperatorExtensions
    {
        public static Task<NamespaceDeclarationSyntax> AddInterface(this IInterfaceOperator _,
            NamespaceDeclarationSyntax @namespace,
            InterfaceDeclarationSyntax @interface)
        {
            var output = _.AddInterface_Synchronous(
                @namespace,
                @interface);

            return Task.FromResult(output);
        }

        public static NamespaceDeclarationSyntax AddInterface_Synchronous(this IInterfaceOperator _,
            NamespaceDeclarationSyntax @namespace,
            InterfaceDeclarationSyntax @interface)
        {
            @namespace = Instances.Operation.AddNode_Old(
                @namespace,
                @interface,
                _.PreAdd,
                _.AddToNamespace,
                _.PostAdd);

            return @namespace;
        }
    }
}


namespace R5T.B0006.X002
{
    public static partial class IInterfaceOperatorExtensions
    {
        public static NamespaceDeclarationSyntax AddToNamespace(this IInterfaceOperator _,
            NamespaceDeclarationSyntax @namespace,
            InterfaceDeclarationSyntax @interface)
        {
            var output = @namespace.AddMembers(@interface);
            return output;
        }
    }
}
