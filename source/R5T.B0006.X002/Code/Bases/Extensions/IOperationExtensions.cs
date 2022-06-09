using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;
using R5T.T0126;

using IOperation = R5T.T0098.IOperation;


namespace System
{
    public static class IOperationExtensions
    {
        /// <summary>
        /// Method establishing a framework for adding a node to a parent node.
        /// Framework returns an annotation to the node, and a new parent node instance modified to include the node to be added.
        /// </summary>
        /// <typeparam name="TParentNode">The node to which a node should be added.</typeparam>
        /// <typeparam name="TNode">The node to add.</typeparam>
        public static (TParentNode, ISyntaxNodeAnnotation<TNode>) AddNode<TParentNode, TNode>(this IOperation _,
            TParentNode parentNode,
            TNode node,
            Func<TNode, TNode> preAdd,
            Func<TParentNode, TNode, TParentNode> add,
            Func<TParentNode, ISyntaxNodeAnnotation<TNode>, TParentNode> postAdd)
            where TParentNode : SyntaxNode
            where TNode : SyntaxNode
        {
            node = preAdd(node);

            node = node.Annotate_Typed(out var annotation);

            parentNode = add(parentNode, node);

            parentNode = postAdd(parentNode, annotation);

            return (parentNode, annotation);
        }

        public static async Task<(TParentNode, ISyntaxNodeAnnotation<TNode>)> AddNode<TParentNode, TNode>(this IOperation _,
            TParentNode parentNode,
            TNode node,
            Func<TNode, Task<TNode>> preAdd,
            Func<TParentNode, TNode, Task<TParentNode>> add,
            Func<TParentNode, ISyntaxNodeAnnotation<TNode>, Task<TParentNode>> postAdd)
            where TParentNode : SyntaxNode
            where TNode : SyntaxNode
        {
            node = await preAdd(node);

            node = node.Annotate_Typed(out var annotation);

            parentNode = await add(parentNode, node);

            parentNode = await postAdd(parentNode, annotation);

            return (parentNode, annotation);
        }


        /// <summary>
        /// Method establishing a framework for adding a node to a parent node.
        /// Note: framework does *not* return an annotation of the node. Callers must pre-annotate the node to be added in order to return an annotation.
        /// This is because async methods cannot have return values.
        /// </summary>
        public static TParentNode AddNode_Old<TParentNode, TNode>(this IOperation _,
            TParentNode parentNode,
            TNode node,
            Func<TNode, TNode> preAdd,
            Func<TParentNode, TNode, TParentNode> add,
            Func<TParentNode, ISyntaxNodeAnnotation<TNode>, TParentNode> postAdd)
            where TParentNode : SyntaxNode
            where TNode : SyntaxNode
        {
            node = preAdd(node);

            node = node.Annotate_Typed(out var annotation);

            parentNode = add(parentNode, node);

            parentNode = postAdd(parentNode, annotation);

            return parentNode;
        }

        public static async Task<TParentNode> AddNode_Old<TParentNode, TNode>(this IOperation _,
            TParentNode parentNode,
            TNode node,
            Func<TNode, Task<TNode>> preAdd,
            Func<TParentNode, TNode, Task<TParentNode>> add,
            Func<TParentNode, ISyntaxNodeAnnotation<TNode>, Task<TParentNode>> postAdd)
            where TParentNode : SyntaxNode
            where TNode : SyntaxNode
        {
            node = await preAdd(node);

            node = node.Annotate_Typed(out var annotation);

            parentNode = await add(parentNode, node);

            parentNode = await postAdd(parentNode, annotation);

            return parentNode;
        }
    }
}
