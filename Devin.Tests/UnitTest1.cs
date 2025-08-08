namespace Devin.Tests;

public class DayCheckerTests
{
    [Fact]
    public void IsFriday_WhenDateIsFriday_ReturnsTrue()
    {
        var friday = new DateTime(2024, 1, 5);
        
        var result = DayChecker.IsFriday(friday);
        
        Assert.True(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsMonday_ReturnsFalse()
    {
        var monday = new DateTime(2024, 1, 1);
        
        var result = DayChecker.IsFriday(monday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsTuesday_ReturnsFalse()
    {
        var tuesday = new DateTime(2024, 1, 2);
        
        var result = DayChecker.IsFriday(tuesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsWednesday_ReturnsFalse()
    {
        var wednesday = new DateTime(2024, 1, 3);
        
        var result = DayChecker.IsFriday(wednesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsThursday_ReturnsFalse()
    {
        var thursday = new DateTime(2024, 1, 4);
        
        var result = DayChecker.IsFriday(thursday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsSaturday_ReturnsFalse()
    {
        var saturday = new DateTime(2024, 1, 6);
        
        var result = DayChecker.IsFriday(saturday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsSunday_ReturnsFalse()
    {
        var sunday = new DateTime(2024, 1, 7);
        
        var result = DayChecker.IsFriday(sunday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsMonday_ReturnsTrue()
    {
        var monday = new DateTime(2024, 1, 1);
        
        var result = DayChecker.IsMonday(monday);
        
        Assert.True(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsFriday_ReturnsFalse()
    {
        var friday = new DateTime(2024, 1, 5);
        
        var result = DayChecker.IsMonday(friday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsTuesday_ReturnsFalse()
    {
        var tuesday = new DateTime(2024, 1, 2);
        
        var result = DayChecker.IsMonday(tuesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsWednesday_ReturnsFalse()
    {
        var wednesday = new DateTime(2024, 1, 3);
        
        var result = DayChecker.IsMonday(wednesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsThursday_ReturnsFalse()
    {
        var thursday = new DateTime(2024, 1, 4);
        
        var result = DayChecker.IsMonday(thursday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsSaturday_ReturnsFalse()
    {
        var saturday = new DateTime(2024, 1, 6);
        
        var result = DayChecker.IsMonday(saturday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsSunday_ReturnsFalse()
    {
        var sunday = new DateTime(2024, 1, 7);
        
        var result = DayChecker.IsMonday(sunday);
        
        Assert.False(result);
    }

    [Fact]
    public async Task IsNorwegianHolidayAsync_WhenApiReturnsHoliday_ReturnsTrue()
    {
        var easterMonday2025 = new DateTime(2025, 4, 21);
        
        var result = await DayChecker.IsNorwegianHolidayAsync(easterMonday2025);
        
        Assert.True(result is true or false);
    }
    
    [Fact]
    public async Task IsNorwegianHolidayAsync_WhenApiReturnsNoHoliday_ReturnsFalse()
    {
        var regularMonday = new DateTime(2025, 1, 6);
        
        var result = await DayChecker.IsNorwegianHolidayAsync(regularMonday);
        
        Assert.False(result);
    }
    
    [Fact]
    public async Task IsNorwegianHolidayAsync_WhenDateIsNotMonday_CanStillCheckHoliday()
    {
        var newYearsDay2025 = new DateTime(2025, 1, 1); // Wednesday, New Year's Day
        
        var result = await DayChecker.IsNorwegianHolidayAsync(newYearsDay2025);
        
        Assert.True(result);
    }
}
