using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class DocumentationOperator : IDocumentationOperator
    {
        #region Static
        
        public static DocumentationOperator Instance { get; } = new();

        #endregion
    }
}