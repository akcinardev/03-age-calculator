using AgeCalculator.Models;

namespace AgeCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Get start and end dates from user
			// Console.WriteLine("Date 1: (dd.mm.yyyy)");
			// string? startDateInput = Console.ReadLine();
			string startDateInput = "10.07.1998";
			// 
			// Console.WriteLine("Date 2: (dd.mm.yyyy)");
			// string? endDateInput = Console.ReadLine();
			string endDateInput = "23.07.2024";

			// Format input and validate as datetime
			DateTime startDate = DateTime.Parse(startDateInput);
			DateTime endDate = DateTime.Parse(endDateInput);

			Age userAge = GetAge(startDate, endDate);

            Console.WriteLine($"You are {userAge.Years} years, {userAge.Months} months and {userAge.Days} days old.");
        }

		private static Age GetAge(DateTime firstDate, DateTime secondDate)
		{
			int yearDifference = secondDate.Year - firstDate.Year;
			int monthDifference = secondDate.Month - firstDate.Month;
			int dayDifference = secondDate.Day - firstDate.Day;

			if (dayDifference < 0)
			{
				monthDifference--;
				dayDifference += DateTime.DaysInMonth(secondDate.AddMonths(-1).Year, secondDate.AddMonths(-1).Month);
			}
			if (monthDifference < 0)
			{
				yearDifference--;
				monthDifference += 12;
			}

			return new Age(yearDifference, monthDifference, dayDifference);
        }
	}
}
