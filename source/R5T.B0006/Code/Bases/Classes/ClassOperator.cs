using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ClassOperator : IClassOperator
    {
        #region Static
        
        public static ClassOperator Instance { get; } = new();

        #endregion
    }
}