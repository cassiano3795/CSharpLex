using sly.lexer;

namespace CompiladoresC_.Ex7
{
    public enum Tokens
    {
        [Lexeme(@"(^((http|https):\/\/)?(www\.)?[a-zA-Z]*\.com(.[a-zA-Z]+)?$)")]
        URL = 1
    }
}
