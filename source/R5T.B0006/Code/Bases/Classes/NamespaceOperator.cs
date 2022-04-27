using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespaceOperator : INamespaceOperator
    {
        #region Static
        
        public static NamespaceOperator Instance { get; } = new();

        #endregion
    }
}