using System.Reflection.Metadata;
using Xunit;
using FluentAssertions;
using ExtensionsNet.StringExtensions;
using System;

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
    }
}
