using System;


namespace R5T.B0006
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class InterfaceOperator : IInterfaceOperator
    {
        #region Static
        
        public static InterfaceOperator Instance { get; } = new();

        #endregion
    }
}