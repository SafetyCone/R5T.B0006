using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeGenerator : ITypeGenerator
    {
        #region Static
        
        public static TypeGenerator Instance { get; } = new();

        #endregion
    }
}