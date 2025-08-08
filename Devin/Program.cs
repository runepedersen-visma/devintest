// See https://aka.ms/new-console-template for more information
Console.WriteLine("Devin the AI agent");

// Check if today is Friday or Monday
DateTime today = DateTime.Now;
if (DayChecker.IsFriday(today))
{
    Console.WriteLine("It's Friday!");
}
else if (DayChecker.IsMonday(today))
{
    Console.WriteLine("Oh no, it's monday");
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
}
