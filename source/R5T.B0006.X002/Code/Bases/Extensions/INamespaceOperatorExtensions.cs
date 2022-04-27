using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;
using R5T.T0126;

using Instances = R5T.B0006.X002.Instances;


namespace System
{
    public static class INamespaceOperatorExtensions
    {
        public static Task<CompilationUnitSyntax> AddNamespace_WithLeadingSeparation(this INamespaceOperator _,
            CompilationUnitSyntax compilationUnit,
            NamespaceDeclarationSyntax @namespace)
        {
            @namespace = @namespace.AnnotateTyped(out var annotation);

            compilationUnit = _.AddNamespace_SimpleSynchronous(
                compilationUnit,
                @namespace);

            compilationUnit = annotation.ModifySynchronous(
                compilationUnit,
                @namespace => @namespace.SetLeadingSeparatingTrivia(
                    Instances.LineIndentation.TwoBlankLines()));

            return Task.FromResult(compilationUnit);
        }

        /// <summary>
        /// Sets the namespace's end brace to have the same line indentation as the open brace.
        /// </summary>
        public static CompilationUnitSyntax SetEndBraceLineIndentation(this INamespaceOperator _,
            CompilationUnitSyntax compilationUnit,
            NamespaceAnnotation namespaceAnnotation)
        {
            compilationUnit = compilationUnit.Modify_TypedSynchronous(
                namespaceAnnotation,
                @namespace =>
                {
                    var openBraceLineIndentation = @namespace.OpenBraceToken.GetLineIndentation();

                    @namespace = @namespace.SetLineIndentation(
                        @namespace.CloseBraceToken,
                        openBraceLineIndentation);

                    return @namespace;
                });

            return compilationUnit;
        }
    }
}