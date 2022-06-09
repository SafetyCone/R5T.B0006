using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeOperator : ITypeOperator
    {
        #region Static
        
        public static TypeOperator Instance { get; } = new();

        #endregion
    }
}