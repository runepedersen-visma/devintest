// See https://aka.ms/new-console-template for more information

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
