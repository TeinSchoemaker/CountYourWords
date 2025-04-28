using System;

namespace CountYourWords.Tests;

public class RegexInputTest
{
    [Fact]
    public void NoSymbols()
    {
        // Given
        var regexer = new RegexInput();
        var input = "l33t hotmail@gmail.nl ##world!!";
        var expected = new List<string> { "l", "t", "hotmail", "gmail", "nl", "world" };

        // When
        var result = regexer.Parse(input);

        // Then
        Assert.Equal(expected, result);
    }
}
