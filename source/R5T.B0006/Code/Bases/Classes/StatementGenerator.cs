using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class StatementGenerator : IStatementGenerator
    {
        #region Static
        
        public static StatementGenerator Instance { get; } = new();

        #endregion
    }
}