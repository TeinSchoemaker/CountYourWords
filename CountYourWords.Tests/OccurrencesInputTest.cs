using System;

namespace CountYourWords.Tests;

public class OccurrencesInputTest
{
    [Fact]
    public void ReturnsOccurences() {

        // Given
        var occurrencesInput = new OccurrenesInput();
        var wordsList = new List<string> { "bread", "bread", "monkey", "airplane", "monkey", "bread" };

        // When 
        var result = occurrencesInput.InputCounter(wordsList);

        // Then
        Assert.Equal(3, result["bread"]);
        Assert.Equal(2, result["monkey"]);
        Assert.Equal(1, result["airplane"]);
    }
}
