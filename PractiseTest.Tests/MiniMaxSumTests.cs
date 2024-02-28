using PractiseTests;

namespace PractiseTest.Tests;

public class MiniMaxSumTests
{
    [Fact]
    public void BasicTest1()
    {
        // Arrange
        var testData = new List<int> {1, 2, 5, 7, 9};
        var expectedOutput = "16 24\n";

        using var sw = new StringWriter();
        Console.SetOut(sw);
            
        // Act
        MiniMaxSumSolution.miniMaxSum(testData);
            
        // Assert
        var result = sw.ToString().Replace("\r", "");
        Assert.Equal(expectedOutput, result);
    }

}