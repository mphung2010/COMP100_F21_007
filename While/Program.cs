using System;

namespace While {
	class Program {
		static void Main(string[] args) {
			// WHILE LOOPS
			// While loops are pre-processed loops.
			// While loops may not execute the code in the body at all.

			// While loops:
			// 1. Have a header (definition).
			// 2. Have a body.

			// Writing a loop that counts from 0 to 9.

			int counter = 0;

			while (counter < 10) {
				// Do something X times.
				// This code will run while the condition below returns true.
				// Each time this code repeats is called an iteration.
				Console.WriteLine($"counter is {counter}.");

				//counter = counter + 1;
				counter++; // Same as the above.
			} 

			// Code continues...
		}
	}
}
