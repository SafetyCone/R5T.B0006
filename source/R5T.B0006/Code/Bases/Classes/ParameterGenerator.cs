using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ParameterGenerator : IParameterGenerator
    {
        #region Static
        
        public static ParameterGenerator Instance { get; } = new();

        #endregion
    }
}