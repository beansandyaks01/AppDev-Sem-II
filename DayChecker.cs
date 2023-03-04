using System;

namespace DaysOfWeek;

public class DateChecker
{
    private readonly int[] _daysOfWeek;
    private readonly DateTime _startDate;
    private readonly DateTime _endDate;

    //initialize daysofWeek array, startDate and endDate in constructor
    public DateChecker(int[] daysOfWeek, DateTime startDate, DateTime endDate)
    {
        _daysOfWeek = daysOfWeek;
        _startDate = startDate;
        _endDate = endDate;
    }

    //Method to print number of occurences
    public void PrintOccurrences()
    {
        foreach (int dayOfWeek in _daysOfWeek)
        {
            int occurrences = 0;
            //https://learn.microsoft.com/en-us/powerquery-m/date-adddays
            for (DateTime date = _startDate; date <= _endDate; date = date.AddDays(1))
            {
                //https://stackoverflow.com/questions/9199080/how-to-get-the-integer-value-of-day-of-week
                if ((int)date.DayOfWeek == dayOfWeek)
                {
                    occurrences++;
                    Console.WriteLine($"{date.DayOfWeek} ({date:d})");
                }
            }
            Console.WriteLine($"{occurrences} occurrences of {(DayOfWeek)dayOfWeek}");
        }
    }
}

