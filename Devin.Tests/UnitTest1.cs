namespace Devin.Tests;

public class FridayCheckerTests
{
    [Fact]
    public void IsFriday_WhenDateIsFriday_ReturnsTrue()
    {
        var friday = new DateTime(2024, 1, 5);
        
        var result = FridayChecker.IsFriday(friday);
        
        Assert.True(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsMonday_ReturnsFalse()
    {
        var monday = new DateTime(2024, 1, 1);
        
        var result = FridayChecker.IsFriday(monday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsTuesday_ReturnsFalse()
    {
        var tuesday = new DateTime(2024, 1, 2);
        
        var result = FridayChecker.IsFriday(tuesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsWednesday_ReturnsFalse()
    {
        var wednesday = new DateTime(2024, 1, 3);
        
        var result = FridayChecker.IsFriday(wednesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsThursday_ReturnsFalse()
    {
        var thursday = new DateTime(2024, 1, 4);
        
        var result = FridayChecker.IsFriday(thursday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsSaturday_ReturnsFalse()
    {
        var saturday = new DateTime(2024, 1, 6);
        
        var result = FridayChecker.IsFriday(saturday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsSunday_ReturnsFalse()
    {
        var sunday = new DateTime(2024, 1, 7);
        
        var result = FridayChecker.IsFriday(sunday);
        
        Assert.False(result);
    }
}
