using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NameOperator : INameOperator
    {
        #region Static
        
        public static NameOperator Instance { get; } = new();

        #endregion
    }
}