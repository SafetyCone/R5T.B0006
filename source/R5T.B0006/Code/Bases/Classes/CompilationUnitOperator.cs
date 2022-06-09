using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class CompilationUnitOperator : ICompilationUnitOperator
    {
        #region Static
        
        public static CompilationUnitOperator Instance { get; } = new();

        #endregion
    }
}