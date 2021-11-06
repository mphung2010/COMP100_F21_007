using System;

namespace Exercise07 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			Write a console program that prompts the user for the number of asterisks to display on the screen.

			The program should display each asterisk on the same line, separated by a space.

			Example:

			// Input:  5
			// Output: * * * * *
			 
			*/

			int counter = 0;

			Console.WriteLine("Enter the number of asterisks that you want to display on the screen.");
			int input = Convert.ToInt32(Console.ReadLine());

			while (counter < input) {
				Console.Write("* ");
				counter++;
			}
		}
	}
}
