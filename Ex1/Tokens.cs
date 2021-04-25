using sly.lexer;

namespace CompiladoresC_.Ex1
{
    public enum Tokens
    {

        [Lexeme("(^\\d{3}\\d{9}$)")]
        PHONE_NUMBER = 1,
    }
}
