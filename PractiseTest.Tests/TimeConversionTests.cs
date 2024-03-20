using PractiseTests;

namespace PractiseTest.Tests;

public class TimeConversionTests
{
    //GivenSomeScenario_WhenSomethingHappens_ThenExpectSomeResult
    [Fact]
    public void Convert_Midnight_To_24Hour_Format()
    {
        // Arrange
        var input = "12:00:00AM";
        var expected = "00:00:00";

        // Act
        var result = TimeConversion.timeConversion(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Convert_Noon_To_24Hour_Format()
    {
        // Arrange
        var input = "12:00:00PM";
        var expected = "12:00:00";
        
        // Act
        var result = TimeConversion.timeConversion(input);
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Convert_AM_Time_To_24Hour_Format()
    {
        // Arrange
        var input = "01:00:00AM";
        var expected = "01:00:00";
        
        // Act
        var result = TimeConversion.timeConversion(input);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Convert_PM_Time_To_24Hour_Format()
    {
        // Arrange
        var input = "01:00:00PM";
        var expected = "13:00:00";
        
        // Act
        var result = TimeConversion.timeConversion(input);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Convert_Evening_Time_To_24Hour_Format()
    {
        // Arrange
        var input = "11:59:59PM";
        var expected = "23:59:59";
        
        // Act
        var result = TimeConversion.timeConversion(input);
        
        // Assert
        Assert.Equal(expected, result);
    }

}