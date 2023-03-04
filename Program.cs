using System;

namespace DaysOfWeek;

class DayChecker
{
    static void Main(string[] args)
    {
        //Take input for days of week where 0 represents Sunday and 6 represents Saturday
        //https://learn.microsoft.com/en-us/powerquery-m/day-type
        Console.WriteLine("Enter a list of integers seperated by commas representing the days of week(0-6): ");
        string daysOfWeek = Console.ReadLine(); ;
        int[] listOfDays = Array.ConvertAll(daysOfWeek.Split(','), int.Parse);

        Console.WriteLine("Start Date: ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("End Date: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        var dayChecker = new DateChecker(listOfDays, startDate, endDate);
        dayChecker.PrintOccurrences();

        Console.ReadLine();

    }
}
