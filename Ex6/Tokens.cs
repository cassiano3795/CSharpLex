using sly.lexer;

namespace CompiladoresC_.Ex6
{
    public enum Tokens
    {
        [Lexeme(@"<(\S*?)[^>]*>.*?</\1>|<.*?/>")]
        HTML = 1
    }
}
