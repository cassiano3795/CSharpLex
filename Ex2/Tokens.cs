using sly.lexer;

namespace CompiladoresC_.Ex2
{
    public enum Tokens
    {
        [Lexeme("^[A-Z]{3}-[0-9]{4}$")]
        PLATE = 1
    }
}
