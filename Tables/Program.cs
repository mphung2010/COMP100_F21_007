using System;

namespace Tables {
	class Program {
		static void Main(string[] args) {
			// TABLES

			// Example: Writing a program that displays a table with the conversion from metric to imperial.
			// The table contains all values from 0 meters to 20 meters, and their corresponding values in feet.

			// Hint: 1 foot = 0.3048 meters.

			// Starting with the headers.

			Console.WriteLine($"{"METERS",-20}{"FEET",-20}");
			Console.WriteLine("==========================");

			for (int line = 0; line <= 20; line++) {
				double meters = line;
				double feet = meters / 0.3048;

				Console.WriteLine($"{meters,-20:F3}{feet,-20:F3}");
			}
		}
	}
}
