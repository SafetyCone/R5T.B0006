using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;


namespace System
{
    public static partial class INamespaceOperatorExtensions
    {
        public static Task<CompilationUnitSyntax> AddNamespace_Simple(this INamespaceOperator _,
            CompilationUnitSyntax compilationUnit,
            NamespaceDeclarationSyntax @namespace)
        {
            var output = _.AddNamespace_SimpleSynchronous(compilationUnit, @namespace);
            
            return Task.FromResult(output);
        }

        public static CompilationUnitSyntax AddNamespace_SimpleSynchronous(this INamespaceOperator _,
            CompilationUnitSyntax compilationUnit,
            NamespaceDeclarationSyntax @namespace)
        {
            var output = compilationUnit.AddMembers(@namespace);
            return output;
        }
    }
}