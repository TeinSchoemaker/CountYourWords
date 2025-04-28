using System;

namespace CountYourWords.Tests;

public class CountInputTest
{
    [Fact]
    public void CountInput_ReturnsCorrectValue() {

        // Given
        var counter = new CountInput();
        var sortedInput = new List<KeyValuePair<string, int>> {
            new KeyValuePair<string, int>("start", 3),
            new KeyValuePair<string, int>("green", 5),
            new KeyValuePair<string, int>("break",2)
        };

        // When
        var result = counter.CountWords(sortedInput);

        // Then
        Assert.Equal(10, result);
    }
}
