using Xunit;
using System.Collections.Generic;
using EasyCommandLineParser;

namespace EasyCommandLineParserTest
{

    public class ParseTest
    {
        class Options
        {
            [Option('t', "string", Required = false, HelpText = "String Value")]
            public string Text { get; set; }
            [Option('l', "long", Required = false, HelpText = "Long Value")]
            public long LongValue { get; set; }
            [Option('i', "int", Required = false, HelpText = "Int Value")]
            public int IntValue { get; set; }
        }

        [Fact]
        public void TestParse_ErrorParamOverflow()
        {
            var args = new List<string>();
            args.Add("--int");
            args.Add(long.MaxValue.ToString());
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.NotParsed);
            Assert.Equal(0, result.Value.IntValue);
        }

        [Fact]
        public void TestParse_ErrorNotExistsOption()
        {
            var args = new List<string>();
            args.Add("--t");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.NotEqual("TestText", result.Value.Text);
        }

        [Fact]
        public void TestParse_ErrorWrongParam()
        {
            var args = new List<string>();
            args.Add("--int");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.NotParsed);
            //Assert.NotEqual("int", result.Value.IntValue);
        }
    }
}
