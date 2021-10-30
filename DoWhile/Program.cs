using System;

namespace DoWhile {
	class Program {
		static void Main(string[] args) {
			// DO WHILE LOOP
			// Looping structures are control structures.
			// They repeat a specified code block a number of times.
			// Looping structures will always contain a condition (Boolean expression)
			// that defines whether the code block in the body will repeat.

			// Do-While loops:
			// 0. Will always execute the body at least once (post-processed).
			// 1. Have a header (definition).
			// 2. have a body.

			// Writing a loop that counts from 0 to 9.

			int counter = 0;

			do {
				// Do something X times.
				// This code will run while the condition below returns true.
				// Each time this code repeats is called an iteration.
				Console.WriteLine($"counter is {counter}.");

				counter = counter + 1;
			} while (counter < 10);

			// Code continues...
		}
	}
}
