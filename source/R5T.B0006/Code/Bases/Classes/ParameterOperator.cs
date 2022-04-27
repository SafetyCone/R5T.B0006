using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ParameterOperator : IParameterOperator
    {
        #region Static
        
        public static ParameterOperator Instance { get; } = new();

        #endregion
    }
}