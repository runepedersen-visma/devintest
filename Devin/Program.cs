// See https://aka.ms/new-console-template for more information
Console.WriteLine("Devin the AI agent");

// Check if today is Friday
DateTime today = DateTime.Now;
if (FridayChecker.IsFriday(today))
{
    Console.WriteLine("It's Friday!");
}

public static class FridayChecker
{
    public static bool IsFriday(DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Friday;
    }
}
