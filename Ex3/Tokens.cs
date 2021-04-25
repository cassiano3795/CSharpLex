using sly.lexer;

namespace CompiladoresC_.Ex3
{
    public enum Tokens
    {
        [Lexeme("(^\\d{3}.\\d{3}.\\d{3}\\-\\d{2})")]
        CPF = 1
    }
}
