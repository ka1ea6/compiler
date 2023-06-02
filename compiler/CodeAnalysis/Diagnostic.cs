using compiler.CodeAnalysis.Binding;
using compiler.CodeAnalysis.Symbols;
using compiler.CodeAnalysis.Syntax;
using compiler.CodeAnalysis.Text;
using System.Collections.Immutable;

namespace compiler.CodeAnalysis
{
    public sealed class Diagnostic
    {
        public Diagnostic(TextLocation location, string message)
        {
            Location = location;
            Message = message;
        }

        public TextLocation Location { get; }
        public string Message { get; }

        public override string ToString() => Message;
    }
}
