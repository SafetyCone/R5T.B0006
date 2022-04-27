using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ClassGenerator : IClassGenerator
    {
        #region Static
        
        public static ClassGenerator Instance { get; } = new();

        #endregion
    }
}