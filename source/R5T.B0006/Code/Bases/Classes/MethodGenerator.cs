using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class MethodGenerator : IMethodGenerator
    {
        #region Static
        
        public static MethodGenerator Instance { get; } = new();

        #endregion
    }
}