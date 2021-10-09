using System;

namespace Exercise03 {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens.

			/*
			 
			Write a program that prompts the user for a number (that may be a fraction). 
			
			The program reads in the input and print the following: the input as a double, the input as an int and finally the input as a char.
			e.g. if the input is 65.790, then the output will be 65.790, 65, and A. 
			 
			*/

			// DECLARE VARIABLES
			double input;

			// COLLECT INPUT
			Console.WriteLine("Please input a floating-point number: ");
			input = double.Parse(Console.ReadLine());

			// ALGORITHM

			// DISPLAY OUTPUT
			Console.WriteLine($"Output as double: {input:F3}");
			Console.WriteLine($"Output as int: {(int)input}");
			Console.WriteLine($"Output as char: {(char)input}");
		}
	}
}
