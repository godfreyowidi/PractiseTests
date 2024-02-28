// using PractiseTests;
//
// namespace PractiseTest.Tests;
//
// public class PlusMinusTests
// {
//     [Fact]
//     public void BasicTest()
//     {
//         // Arrange
//         var testData = new List<int> { 1, 1, 0, -1, -1 };
//         var expectedOutput = "0.400000\n0.400000\n0.200000\n";
//         
//         // Redirect console output
//         using var sw = new StringWriter();
//         Console.SetOut(sw);
//             
//         // Act
//         PlusMinusSolution.plusMinus(testData);
//             
//         // Assert
//         var result = sw.ToString().Replace("\r", "");
//         Assert.Equal(expectedOutput, result);
//     }
//
// }