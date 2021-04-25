using sly.lexer;
using sly.parser;
using sly.parser.generator;

namespace CompiladoresC_.Ex1
{
    public class PhoneNumberParser
    {
        [Production("expression : PHONE_NUMBER")]
        public string Expression(Token<Tokens> phoneNumber)
        {
            return phoneNumber.Value;
        }
        public static Parser<Tokens, string> GetParser()
        {
            var parserInstance = new PhoneNumberParser();
            var builder = new ParserBuilder<Tokens, string>();
            var Parser = builder.BuildParser(parserInstance, ParserType.LL_RECURSIVE_DESCENT, "expression").Result;

            return Parser;
        }
    }
}
