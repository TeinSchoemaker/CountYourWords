using System;
using Xunit;

namespace CountYourWords.Tests;

public class ReadInputTest
{
    [Fact]
    public void ReadFile()
    {
        // Given
        var testPath = "inputTest.txt";
        var expected = "Test test test";
        File.WriteAllText(testPath, expected);

        // When
        var read = new ReadInput(testPath);
        var result = read.Read();

        // Then
        Assert.Equal(expected, result);
    }
}