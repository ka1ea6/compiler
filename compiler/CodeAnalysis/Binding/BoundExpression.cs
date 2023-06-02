using System;
using compiler.CodeAnalysis.Symbols;

namespace compiler.CodeAnalysis.Binding
{
    internal abstract class BoundExpression : BoundNode
    {
        public abstract TypeSymbol Type { get; }
    }
}
