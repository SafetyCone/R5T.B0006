using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;


namespace System
{
    public static partial class IClassOperatorExtensions
    {
        public static Task<NamespaceDeclarationSyntax> AddClass_Simple(this IClassOperator _,
            NamespaceDeclarationSyntax @namespace,
            ClassDeclarationSyntax @class)
        {
            var output = _.AddClass_SimpleSynchronous(@namespace, @class);

            return Task.FromResult(output);
        }

        public static NamespaceDeclarationSyntax AddClass_SimpleSynchronous(this IClassOperator _,
            NamespaceDeclarationSyntax @namespace,
            ClassDeclarationSyntax @class)
        {
            var output = @namespace.AddMembers(@class);
            return output;
        }
    }
}