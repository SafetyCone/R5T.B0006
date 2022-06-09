using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X002.Instances;


namespace System
{
    public static partial class IClassOperatorExtensions
    {
        public static Task<NamespaceDeclarationSyntax> AddClass_WithIndentation(this IClassOperator _,
            NamespaceDeclarationSyntax @namespace,
            ClassDeclarationSyntax @class)
        {
            @class = @class.Annotate_Typed(out var annotation);

            @namespace = _.AddClass_SimpleSynchronous(
                @namespace,
                @class);

            @namespace = annotation.ModifySynchronous(
                @namespace,
                @class => @class.IndentBlock_Old(
                    Instances.Indentation.Class()));

            return Task.FromResult(@namespace);
        }

        public static Task<NamespaceDeclarationSyntax> AddClass_Latest(this IClassOperator _,
            NamespaceDeclarationSyntax @namespace,
            ClassDeclarationSyntax @class)
        {
            return _.AddClass_WithIndentation(
                @namespace,
                @class);
        }
    }
}