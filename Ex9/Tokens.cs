using sly.lexer;

namespace CompiladoresC_.Ex9
{
    public enum Tokens
    {
        [Lexeme("(^\"[a-zA-Z\\d]*\")$")]
        STRING = 1
    }
}
