using sly.lexer;

namespace CompiladoresC_.Ex8
{
    public enum Tokens
    {
        [Lexeme("[a-zA-Z\u00C0-\u00ff]{2,}")]
        WORD = 1
    }
}
