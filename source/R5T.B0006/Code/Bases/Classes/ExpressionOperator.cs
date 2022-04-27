using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExpressionOperator : IExpressionOperator
    {
        #region Static
        
        public static ExpressionOperator Instance { get; } = new();

        #endregion
    }
}