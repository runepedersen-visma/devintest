// See https://aka.ms/new-console-template for more information

await MainAsync();

static async Task MainAsync()
{
    Console.WriteLine("Hello I am Devin the, daycommenter!");
    
    // Check if today is Friday or Monday
    DateTime today = DateTime.Now;
    if (DayChecker.IsFriday(today))
    {
        Console.WriteLine("It's Friday!");
    }
    else if (DayChecker.IsMonday(today))
    {
        var message = "Oh no, it's Monday";
        if (await DayChecker.IsNorwegianHolidayAsync(today))
        {
            message += " but puhh... this Monday is a holiday";
        }
        Console.WriteLine(message);
    }
}
