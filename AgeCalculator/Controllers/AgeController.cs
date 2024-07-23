using AgeCalculator.Models;

namespace AgeCalculator.Controllers
{
	public class AgeController
	{
		public Age GetAge(DateTime firstDate, DateTime secondDate)
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

		public void ShowAgeInfo(string firstDate, string secondDate)
		{
			DateTime startDate;
			DateTime endDate;

			if (DateTime.TryParse(firstDate, out startDate) && DateTime.TryParse(secondDate, out endDate))
			{
				Age userAge = GetAge(startDate, endDate);
				Console.WriteLine($"You are {userAge.Years} years, {userAge.Months} months and {userAge.Days} days old.");
			}
			else
			{
				Console.WriteLine("Invalid date format. The format should be 'dd.mm.yyyy'");
			}
		}
	}
}
