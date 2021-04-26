using sly.lexer;

namespace CompiladoresC_.Ex10
{
    public enum Tokens
    {
        [Lexeme(@"[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}")]
        CNPJ = 1
    }
}
