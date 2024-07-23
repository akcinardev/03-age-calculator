using AgeCalculator.Models;
using AgeCalculator.Controllers;

namespace AgeCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			AgeController ageController = new AgeController();

			// Get start and end dates from user
			Console.WriteLine("Date 1: (dd.mm.yyyy)");
			string? startDateInput = Console.ReadLine();

			Console.WriteLine("Date 2: (dd.mm.yyyy)");
			string? endDateInput = Console.ReadLine();

			if (string.IsNullOrEmpty(startDateInput) || string.IsNullOrEmpty(endDateInput))
			{
                Console.WriteLine("Invalid or null date.");
            }
			else
			{
				ageController.ShowAgeInfo(startDateInput, endDateInput);
			}
        }
	}
}
