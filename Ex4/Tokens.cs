using sly.lexer;

namespace CompiladoresC_.Ex4
{
    public enum Tokens
    {
        [Lexeme("(^\\d{9}\\-\\d{1})")]
        MATRICULA = 1
    }
}
