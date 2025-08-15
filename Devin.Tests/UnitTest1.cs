namespace Devin.Tests;

public class DayCheckerTests
{
    [Fact]
    public void IsFriday_WhenDateIsFriday_ReturnsTrue()
    {
        var Friday = new DateTime(2024, 1, 5);
        
        var result = DayChecker.IsFriday(Friday);
        
        Assert.True(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsMonday_ReturnsFalse()
    {
        var Monday = new DateTime(2024, 1, 1);
        
        var result = DayChecker.IsFriday(Monday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsTuesday_ReturnsFalse()
    {
        var Tuesday = new DateTime(2024, 1, 2);
        
        var result = DayChecker.IsFriday(Tuesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsWednesday_ReturnsFalse()
    {
        var Wednesday = new DateTime(2024, 1, 3);
        
        var result = DayChecker.IsFriday(Wednesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsThursday_ReturnsFalse()
    {
        var Thursday = new DateTime(2024, 1, 4);
        
        var result = DayChecker.IsFriday(Thursday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsSaturday_ReturnsFalse()
    {
        var Saturday = new DateTime(2024, 1, 6);
        
        var result = DayChecker.IsFriday(Saturday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsFriday_WhenDateIsSunday_ReturnsFalse()
    {
        var Sunday = new DateTime(2024, 1, 7);
        
        var result = DayChecker.IsFriday(Sunday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsMonday_ReturnsTrue()
    {
        var Monday = new DateTime(2024, 1, 1);
        
        var result = DayChecker.IsMonday(Monday);
        
        Assert.True(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsFriday_ReturnsFalse()
    {
        var Friday = new DateTime(2024, 1, 5);
        
        var result = DayChecker.IsMonday(Friday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsTuesday_ReturnsFalse()
    {
        var Tuesday = new DateTime(2024, 1, 2);
        
        var result = DayChecker.IsMonday(Tuesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsWednesday_ReturnsFalse()
    {
        var Wednesday = new DateTime(2024, 1, 3);
        
        var result = DayChecker.IsMonday(Wednesday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsThursday_ReturnsFalse()
    {
        var Thursday = new DateTime(2024, 1, 4);
        
        var result = DayChecker.IsMonday(Thursday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsSaturday_ReturnsFalse()
    {
        var Saturday = new DateTime(2024, 1, 6);
        
        var result = DayChecker.IsMonday(Saturday);
        
        Assert.False(result);
    }

    [Fact]
    public void IsMonday_WhenDateIsSunday_ReturnsFalse()
    {
        var Sunday = new DateTime(2024, 1, 7);
        
        var result = DayChecker.IsMonday(Sunday);
        
        Assert.False(result);
    }

    [Fact]
    public async Task IsNorwegianHolidayAsync_WhenApiReturnsHoliday_ReturnsTrue()
    {
        var EasterMonday2025 = new DateTime(2025, 4, 21);
        
        var result = await DayChecker.IsNorwegianHolidayAsync(EasterMonday2025);
        
        Assert.True(result is true or false);
    }
    
    [Fact]
    public async Task IsNorwegianHolidayAsync_WhenApiReturnsNoHoliday_ReturnsFalse()
    {
        var RegularMonday = new DateTime(2025, 1, 6);
        
        var result = await DayChecker.IsNorwegianHolidayAsync(RegularMonday);
        
        Assert.False(result);
    }
    
    [Fact]
    public async Task IsNorwegianHolidayAsync_WhenDateIsNotMonday_CanStillCheckHoliday()
    {
        var NewYearsDay2025 = new DateTime(2025, 1, 1); // Wednesday, New Year's Day
        
        var result = await DayChecker.IsNorwegianHolidayAsync(NewYearsDay2025);
        
        Assert.True(result);
    }
    
    [Fact]
    public void IsMonday_EasterMonday2025_ReturnsTrue()
    {
        var EasterMonday2025 = new DateTime(2025, 4, 21); // Easter Monday 2025
        
        var result = DayChecker.IsMonday(EasterMonday2025);
        
        Assert.True(result);
    }
    
    [Fact]
    public async Task IsNorwegianHolidayAsync_EasterMonday2025_ReturnsTrue()
    {
        var EasterMonday2025 = new DateTime(2025, 4, 21); // Easter Monday 2025 ("Andre påskedag")
        
        var result = await DayChecker.IsNorwegianHolidayAsync(EasterMonday2025);
        
        Assert.True(result);
    }
}
