using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class StatementOperator : IStatementOperator
    {
        #region Static
        
        public static StatementOperator Instance { get; } = new();

        #endregion
    }
}