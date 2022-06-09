using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;
using R5T.T0126;

using Instances = R5T.B0006.X002.Instances;


namespace R5T.B0006.X002
{
    using N8;


    public static partial class IInterfaceOperatorExtensions
    {
        public static NamespaceDeclarationSyntax PostAdd(this IInterfaceOperator _,
            NamespaceDeclarationSyntax @namespace,
            ISyntaxNodeAnnotation<InterfaceDeclarationSyntax> interfaceAnnotation)
        {
            return _.PostAdd_20220502(
                @namespace,
                interfaceAnnotation);
        }
    }
}


namespace R5T.B0006.X002.N8
{
    public static partial class IInterfaceOperatorExtensions
    {
        public static NamespaceDeclarationSyntax PostAdd_20220502(this IInterfaceOperator _,
            NamespaceDeclarationSyntax @namespace,
            ISyntaxNodeAnnotation<InterfaceDeclarationSyntax> interfaceAnnotation)
        {
            // Indent.
            @namespace = interfaceAnnotation.ModifySynchronous(
               @namespace,
               @interface => @interface.IndentBlock_Old(
                   Instances.Indentation.Interface()));

            return @namespace;
        }
    }
}