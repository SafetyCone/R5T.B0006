using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class InterfaceGenerator : IInterfaceGenerator
    {
        #region Static
        
        public static InterfaceGenerator Instance { get; } = new();

        #endregion
    }
}