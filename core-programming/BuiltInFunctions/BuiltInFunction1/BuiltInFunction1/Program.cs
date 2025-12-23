using System;
class Program
{
    static void Main()
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("1. Time Zones and DateTimeOffset");
            Console.WriteLine("2. Date Arithmetic");
            Console.WriteLine("3. Date Formatting");
            Console.WriteLine("4. Date Comparison");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter the Program to execute: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0: Console.WriteLine("Thank You"); break;
                case 1: DisplayTimeZones(); break;
                case 2: DateArithmetic(); break;
                case 3: DateFormatting(); break;
                case 4: DateComparison(); break;
            }
        }
    }

    public static void DisplayTimeZones()
    {
        DateTimeOffset currentTime = DateTimeOffset.Now;

        Console.WriteLine("\nCurrent Time in Different Time Zones:");
        Console.WriteLine("======================================");

        DateTimeOffset gmtTime = GetTimeInTimeZone(currentTime, "GMT Standard Time");
        Console.WriteLine($"GMT (Greenwich Mean Time): {gmtTime:yyyy-MM-dd HH:mm:ss zzz}");

        DateTimeOffset istTime = GetTimeInTimeZone(currentTime, "India Standard Time");
        Console.WriteLine($"IST (Indian Standard Time): {istTime:yyyy-MM-dd HH:mm:ss zzz}");

        DateTimeOffset pstTime = GetTimeInTimeZone(currentTime, "Pacific Standard Time");
        Console.WriteLine($"PST (Pacific Standard Time): {pstTime:yyyy-MM-dd HH:mm:ss zzz}");

        Console.WriteLine("\nAdditional Time Zone Information:");
        DisplayTimeZoneDetails("GMT Standard Time");
        DisplayTimeZoneDetails("India Standard Time");
        DisplayTimeZoneDetails("Pacific Standard Time");
    }

    public static DateTimeOffset GetTimeInTimeZone(DateTimeOffset currentTime, string timeZoneId)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return TimeZoneInfo.ConvertTime(currentTime, timeZone);
    }

    public static void DisplayTimeZoneDetails(string timeZoneId)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        Console.WriteLine($"\n{timeZone.DisplayName}");
        Console.WriteLine($"  Standard Name: {timeZone.StandardName}");
        Console.WriteLine($"  Daylight Name: {timeZone.DaylightName}");
        Console.WriteLine($"  Base UTC Offset: {timeZone.BaseUtcOffset}");
        Console.WriteLine($"  Supports Daylight Saving: {timeZone.SupportsDaylightSavingTime}");
    }

    public static void DateArithmetic()
    
    {
        Console.Write("\nEnter a date (yyyy-MM-dd): ");
        string input = Console.ReadLine();
        DateTime startDate = DateTime.Parse(input);

        Console.WriteLine($"\nStarting Date: {startDate:yyyy-MM-dd}");
        Console.WriteLine("\nPerforming Date Arithmetic:");
        Console.WriteLine("======================================");

        DateTime afterAdding7Days = AddDays(startDate, 7);
        Console.WriteLine($"After adding 7 days: {afterAdding7Days:yyyy-MM-dd}");

        DateTime afterAdding1Month = AddMonths(afterAdding7Days, 1);
        Console.WriteLine($"After adding 1 month: {afterAdding1Month:yyyy-MM-dd}");

        DateTime afterAdding2Years = AddYears(afterAdding1Month, 2);
        Console.WriteLine($"After adding 2 years: {afterAdding2Years:yyyy-MM-dd}");

        DateTime afterSubtracting3Weeks = SubtractWeeks(afterAdding2Years, 3);
        Console.WriteLine($"After subtracting 3 weeks: {afterSubtracting3Weeks:yyyy-MM-dd}");

        Console.WriteLine("\nFinal Result:");
        Console.WriteLine($"Original Date: {startDate:yyyy-MM-dd}");
        Console.WriteLine($"Final Date: {afterSubtracting3Weeks:yyyy-MM-dd}");

        TimeSpan difference = afterSubtracting3Weeks - startDate;
        Console.WriteLine($"Total Days Difference: {difference.Days} days");
    }

    public static DateTime AddDays(DateTime date, int days)
    {
        return date.AddDays(days);
    }

    public static DateTime AddMonths(DateTime date, int months)
    {
        return date.AddMonths(months);
    }

    public static DateTime AddYears(DateTime date, int years)
    {
        return date.AddYears(years);
    }

    public static DateTime SubtractWeeks(DateTime date, int weeks)
    {
        return date.AddDays(-weeks * 7);
    }

    public static void DateFormatting()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("\nCurrent Date in Different Formats:");
        Console.WriteLine("======================================");

        string format1 = FormatDateDDMMYYYY(currentDate);
        Console.WriteLine($"Format 1 (dd/MM/yyyy): {format1}");

        string format2 = FormatDateYYYYMMDD(currentDate);
        Console.WriteLine($"Format 2 (yyyy-MM-dd): {format2}");

        string format3 = FormatDateLong(currentDate);
        Console.WriteLine($"Format 3 (ddd, MMM dd, yyyy): {format3}");

        Console.WriteLine("\nAdditional Date Formats:");
        Console.WriteLine($"Full Date Time: {currentDate:F}");
        Console.WriteLine($"Long Date: {currentDate:D}");
        Console.WriteLine($"Short Date: {currentDate:d}");
        Console.WriteLine($"Long Time: {currentDate:T}");
        Console.WriteLine($"Short Time: {currentDate:t}");
        Console.WriteLine($"Month Day: {currentDate:MMMM dd}");
        Console.WriteLine($"Year Month: {currentDate:yyyy MMMM}");

        Console.WriteLine("\nCustom Formats:");
        Console.WriteLine($"dd-MMM-yyyy: {currentDate:dd-MMM-yyyy}");
        Console.WriteLine($"dddd, MMMM dd, yyyy: {currentDate:dddd, MMMM dd, yyyy}");
        Console.WriteLine($"MM/dd/yy HH:mm:ss: {currentDate:MM/dd/yy HH:mm:ss}");
    }

    public static string FormatDateDDMMYYYY(DateTime date)
    {
        return date.ToString("dd/MM/yyyy");
    }

    public static string FormatDateYYYYMMDD(DateTime date)
    {
        return date.ToString("yyyy-MM-dd");
    }

    public static string FormatDateLong(DateTime date)
    {
        return date.ToString("ddd, MMM dd, yyyy");
    }

    public static void DateComparison()
    {
        Console.Write("\nEnter first date (yyyy-MM-dd): ");
        string input1 = Console.ReadLine();
        DateTime date1 = DateTime.Parse(input1);

        Console.Write("Enter second date (yyyy-MM-dd): ");
        string input2 = Console.ReadLine();
        DateTime date2 = DateTime.Parse(input2);

        Console.WriteLine("\nDate Comparison Results:");
        Console.WriteLine("======================================");
        Console.WriteLine($"First Date: {date1:yyyy-MM-dd}");
        Console.WriteLine($"Second Date: {date2:yyyy-MM-dd}");

        int comparisonResult = CompareDates(date1, date2);

        Console.WriteLine("\nUsing DateTime.Compare():");
        if (comparisonResult < 0)
        {
            Console.WriteLine($"{date1:yyyy-MM-dd} is BEFORE {date2:yyyy-MM-dd}");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine($"{date1:yyyy-MM-dd} is AFTER {date2:yyyy-MM-dd}");
        }
        else
        {
            Console.WriteLine($"{date1:yyyy-MM-dd} is the SAME as {date2:yyyy-MM-dd}");
        }

        int compareToResult = date1.CompareTo(date2);
        Console.WriteLine("\nUsing DateTime.CompareTo():");
        Console.WriteLine($"Result: {compareToResult}");

        Console.WriteLine("\nUsing Direct Comparison Operators:");
        Console.WriteLine($"date1 < date2: {date1 < date2}");
        Console.WriteLine($"date1 > date2: {date1 > date2}");
        Console.WriteLine($"date1 == date2: {date1 == date2}");
        Console.WriteLine($"date1 <= date2: {date1 <= date2}");
        Console.WriteLine($"date1 >= date2: {date1 >= date2}");

        TimeSpan difference = date2 - date1;
        Console.WriteLine("\nTime Difference:");
        Console.WriteLine($"Days: {Math.Abs(difference.Days)}");
        Console.WriteLine($"Hours: {Math.Abs(difference.Hours)}");
        Console.WriteLine($"Total Days: {Math.Abs(difference.TotalDays):F2}");
        Console.WriteLine($"Total Hours: {Math.Abs(difference.TotalHours):F2}");
    }

    public static int CompareDates(DateTime date1, DateTime date2)
    {
        return DateTime.Compare(date1, date2);
    }
}