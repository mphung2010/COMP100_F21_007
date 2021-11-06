using System;

namespace Exercise06 {
	class Program {
		static void Main(string[] args) {
			/*
			
			Write a program to display the numbers 1 … 20 on separate lines with an asterisk after each multiple of 5. (multiples asterisk) 

			*/

			// For solution:

			for (int i = 1; i <= 20; i++) {
				if (i % 5 == 0) {
					Console.WriteLine($"{i}*"); // i + "*"
				}
				else {
					Console.WriteLine(i);
				}
			}

			Console.WriteLine("\n===========================================\n");


			// Do-While solution:

			int counter = 1;

			do {
				if (counter % 5 == 0) {
					Console.WriteLine($"{counter}*"); // i + "*"
				}
				else {
					Console.WriteLine(counter);
				}

				counter++;
			} while (counter <= 20);

			Console.WriteLine("\n===========================================\n");


			// While solution:

			counter = 1;

			while (counter <= 20) {
				if (counter % 5 == 0) {
					Console.WriteLine($"{counter}*"); // i + "*"
				}
				else {
					Console.WriteLine(counter);
				}

				counter++;
			} 

		}
	}
}
