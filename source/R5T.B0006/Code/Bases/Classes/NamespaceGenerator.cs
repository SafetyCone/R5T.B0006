using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespaceGenerator : INamespaceGenerator
    {
        #region Static
        
        public static NamespaceGenerator Instance { get; } = new();

        #endregion
    }
}