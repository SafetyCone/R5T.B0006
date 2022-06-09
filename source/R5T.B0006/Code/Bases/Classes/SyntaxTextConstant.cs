using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SyntaxTextConstant : ISyntaxTextConstant
    {
        #region Static
        
        public static SyntaxTextConstant Instance { get; } = new();

        #endregion
    }
}