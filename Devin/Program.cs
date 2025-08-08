// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Serialization;

await MainAsync();

static async Task MainAsync()
{
    Console.WriteLine("Devin the AI agent");
    
    // Check if today is Friday or Monday
    DateTime today = DateTime.Now;
    if (DayChecker.IsFriday(today))
    {
        Console.WriteLine("It's Friday!");
    }
    else if (DayChecker.IsMonday(today))
    {
        var message = "Oh no, it's monday";
        if (await DayChecker.IsNorwegianHolidayAsync(today))
        {
            message += " but puhh... this monday is a holiday";
        }
        Console.WriteLine(message);
    }
}

public static class DayChecker
{
    public static bool IsFriday(DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Friday;
    }
    
    public static bool IsMonday(DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Monday;
    }
    
    public static async Task<bool> IsNorwegianHolidayAsync(DateTime date)
    {
        try
        {
            using var httpClient = new HttpClient();
            var year = date.Year;
            var url = $"https://date.nager.at/api/v3/PublicHolidays/{year}/NO";
            
            var response = await httpClient.GetStringAsync(url);
            var holidays = JsonSerializer.Deserialize<NorwegianHoliday[]>(response);
            
            return holidays?.Any(h => !string.IsNullOrEmpty(h.Date) && DateTime.Parse(h.Date).Date == date.Date) ?? false;
        }
        catch
        {
            return false;
        }
    }
}

public record NorwegianHoliday(
    [property: JsonPropertyName("date")] string Date,
    [property: JsonPropertyName("localName")] string LocalName,
    [property: JsonPropertyName("name")] string Name
);
