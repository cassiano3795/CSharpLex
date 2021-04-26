using sly.lexer;
using sly.parser;
using sly.parser.generator;

namespace CompiladoresC_.Ex6
{
    public class HtmlParser
    {
        [Production("expression : HTML")]
        public string Expression(Token<Tokens> plate)
        {
            return plate.Value;
        }
        public static Parser<Tokens, string> GetParser()
        {
            var parserInstance = new HtmlParser();
            var builder = new ParserBuilder<Tokens, string>();
            var Parser = builder.BuildParser(parserInstance, ParserType.LL_RECURSIVE_DESCENT, "expression").Result;

            return Parser;
        }
    }
}
