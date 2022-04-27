using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class DocumentationGenerator : IDocumentationGenerator
    {
        #region Static
        
        public static DocumentationGenerator Instance { get; } = new();

        #endregion
    }
}