using Xunit;
using System.Collections.Generic;
using EasyCommandLineParser;

namespace EasyCommandLineParserTest
{
    public class NullableTypesTest
    {
        class Options
        {
            [Option('t', "string", Required = false, HelpText = "String Value")]
            public string Text { get; set; }
            [Option('l', "long", Required = false, HelpText = "Long Value")]
            public long? LongValue { get; set; }
            [Option('i', "int", Required = false, HelpText = "Int Value")]
            public int? IntValue { get; set; }
            [Option('s', "short", Required = false, HelpText = "Short Value")]
            public short? ShortValue { get; set; }
            [Option('b', "byte", Required = false, HelpText = "Byte Value")]
            public byte? ByteValue { get; set; }
            [Option('c', "char", Required = false, HelpText = "Char Value")]
            public char? CharValue { get; set; }
            [Option('o', "sbyte", Required = false, HelpText = "SByte Value")]
            public sbyte? SByteValue { get; set; }
            [Option('p', "ulong", Required = false, HelpText = "ULong Value")]
            public ulong? ULongValue { get; set; }
            [Option('q', "uint", Required = false, HelpText = "UInt Value")]
            public uint? UIntValue { get; set; }
            [Option('r', "ushort", Required = false, HelpText = "UShort Value")]
            public ushort? UShortValue { get; set; }
            [Option('f', "float", Required = false, HelpText = "Float Value")]
            public float? FloatValue { get; set; }
            [Option('d', "double", Required = false, HelpText = "Double Value")]
            public double? DoubleValue { get; set; }
            [Option('m', "decimal", Required = false, HelpText = "Decimal Value")]
            public decimal? DecimalValue { get; set; }
            [Option('w', "bool", Required = false, HelpText = "Boolean Value")]
            public bool? BooleanValue { get; set; }
        }

        [Fact]
        public void TestNullable_TypeString()
        {
            var args = new List<string>();
            args.Add("--string");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.Equal("TestText", result.Value.Text);
        }

        [Fact]
        public void TestNullable_TypeLong()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.LongValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeInt()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.IntValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeShort()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.ShortValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeByte()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.ByteValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeChar()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.CharValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeSByte()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.SByteValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeULong()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.ULongValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeUInt()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.UIntValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeUShort()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.UShortValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeFloat()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.FloatValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeDouble()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.DoubleValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeDecimal()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.DecimalValue.HasValue);
        }

        [Fact]
        public void TestNullable_TypeBoolean()
        {
            var args = new List<string>();
            args.Add("--test");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.True(result.Tag == ParserResultType.Parsed);
            Assert.False(result.Value.BooleanValue.HasValue);
        }
    }
}
