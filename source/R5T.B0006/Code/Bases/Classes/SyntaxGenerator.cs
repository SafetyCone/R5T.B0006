using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SyntaxGenerator : ISyntaxGenerator
    {
        #region Static
        
        public static SyntaxGenerator Instance { get; } = new();

        #endregion
    }
}