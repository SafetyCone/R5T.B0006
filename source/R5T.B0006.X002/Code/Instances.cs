using System;

using R5T.B0007;
using R5T.L0011.T001;
using R5T.L0011.T002;


namespace R5T.B0006.X002
{
    public static class Instances
    {
        public static IIndentation Indentation { get; } = B0007.Indentation.Instance;
        public static ILineIndentation LineIndentation { get; } = B0007.LineIndentation.Instance;
        public static ISyntax Syntax { get; } = L0011.T002.Syntax.Instance;
        public static ISyntaxFactory SyntaxFactory { get; } = L0011.T001.SyntaxFactory.Instance;
    }
}
