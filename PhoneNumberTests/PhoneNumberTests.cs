using System;
using Xunit;

namespace jkulubya.UG
{
    public class PhoneNumberTests
    {
        [Theory]
        [FlatFileData("PhoneNumberTestsData/validnumbers.txt")]
        public void ParseWithValidNumber(string value)
        {
            var number = PhoneNumberParser.Parse(value);
            
            Assert.Equal("256700192133", number.ToString());
        }
        
        [Theory]
        [FlatFileData("PhoneNumberTestsData/validnumbers.txt")]
        public void TryParseWithValidNumber(string value)
        {
            PhoneNumberParser.TryParse(value, out var number);
            
            Assert.Equal("256700192133", number.ToString());
        }

        [Theory]
        [FlatFileData("PhoneNumberTestsData/invalidnumbers.txt")]
        public void ParseShouldThrowWhenNumberIsInvalid(string value)
        {
            Assert.Throws<FormatException>(() => PhoneNumberParser.Parse(value));
        }
        
        [Theory]
        [FlatFileData("PhoneNumberTestsData/invalidnumbers.txt")]
        public void TryParseShouldReturnNullWhenNumberIsInvalid(string value)
        {
            PhoneNumberParser.TryParse(value, out var number);
            
            Assert.Null(number);
        }
    }
}