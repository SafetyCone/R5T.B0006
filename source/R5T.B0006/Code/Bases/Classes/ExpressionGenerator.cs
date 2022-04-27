using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExpressionGenerator : IExpressionGenerator
    {
        #region Static
        
        public static ExpressionGenerator Instance { get; } = new();

        #endregion
    }
}