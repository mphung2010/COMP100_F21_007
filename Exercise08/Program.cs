using System;

namespace Exercise08 {
	class Program {
		static void Main(string[] args) {
			/*
			
			Write a console app that displays a table with the conversions from Celsius to Fahrenheit.
			The program should prompt the user for the lower boundary and upper boundary.
			Make sure the table is nicely formatted.
			
			*/

			Console.WriteLine("Please enter the lowest temperature in Celsius: ");
			double celsius = double.Parse(Console.ReadLine());

			Console.WriteLine("\nPlease enter the highest temperature in Celsius: ");
			double max = double.Parse(Console.ReadLine());

			Console.WriteLine($"\n{"CELSIUS",-20}{"FAHRENHEIT",-20}");
			Console.WriteLine("===============================");

			while (celsius <= max) {
				double fahrenheit = (double)9 / 5 * celsius + 32;

				Console.WriteLine($"{celsius,-20:F3}{fahrenheit,-20:F3}");

				celsius++;
			}
		}
	}
}
