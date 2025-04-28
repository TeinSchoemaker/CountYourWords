using System;

namespace CountYourWords.Tests;

public class SortInputTest
{
    [Fact]
    public void SortText()
    {
        // Given
        var sorter = new SortInput();
        var input = new Dictionary<string, int> {
            { "cheddar", 9},
            { "amor", 3},
            { "bear", 6}
        };

        // When
        var result = sorter.Sort(input);

        // Then
        Assert.Equal("amor", result[0].Key);
        Assert.Equal("bear", result[1].Key);
        Assert.Equal("cheddar", result[2].Key);
    }
}
