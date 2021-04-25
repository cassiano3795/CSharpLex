using sly.lexer;
using sly.parser;
using sly.parser.generator;

namespace CompiladoresC_.Ex2
{
    public class PlateParser
    {
        [Production("expression : PLATE")]
        public string Expression(Token<Tokens> plate)
        {
            return plate.Value;
        }
        public static Parser<Tokens, string> GetParser()
        {
            var parserInstance = new PlateParser();
            var builder = new ParserBuilder<Tokens, string>();
            var Parser = builder.BuildParser(parserInstance, ParserType.LL_RECURSIVE_DESCENT, "expression").Result;

            return Parser;
        }
    }
}
