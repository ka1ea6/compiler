using compiler.CodeAnalysis.Text;
using compiler.CodeAnalysis.Symbols;
namespace compiler.CodeAnalysis.Symbols
{
    public sealed class ParameterSymbol : LocalVariableSymbol
    {
        public ParameterSymbol(string name, TypeSymbol type, int ordinal)
            : base(name, isReadOnly: true, type)
        {
            Ordinal = ordinal;
        }

        public override SymbolKind Kind => SymbolKind.Parameter;
        public int Ordinal { get; }
    }
}