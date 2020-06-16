using ExtensionsNet.StringExtensions;
using FluentAssertions;
using System;
using Xunit;

namespace ExtensionsNet.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("Hello", "a", "b")]
        [InlineData("Hello", "a", "o")]
        [InlineData("Hello", "el", "a")]
        public void Between_ShouldReturnEmptyStringIfAnyArgumentStringsNotFound(string value, string leftString, string rightString)
        {
            String result = value.Between(leftString, rightString);

            result.Should().BeEmpty();
        }

        [Theory]
        [InlineData("<a>Hello</a>", "<a>", "</a>", "Hello")]
        [InlineData("S123456789T", "S", "T", "123456789")]
        [InlineData("Apples are good", "es ", " go", "are")]
        public void Between_ShouldReturnExpectedValueString(string value, string leftString, string rightString, string expectedValue)
        {
            String result = value.Between(leftString, rightString);

            result.Should().BeEquivalentTo(expectedValue);
        }
    }
}
