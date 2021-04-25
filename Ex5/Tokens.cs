using sly.lexer;

namespace CompiladoresC_.Ex5
{
    public enum Tokens
    {
        [Lexeme(@"(^[+-]?(?:0|[1-9]\d*)(?:\.\d+)?$)")]
        REAL = 1,
    }
}
