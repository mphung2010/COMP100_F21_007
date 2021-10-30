using System;

namespace For {
	class Program {
		static void Main(string[] args) {
			// FOR LOOPS
			// For loops are pre-processed loops.

			// For loops:
			// 1. Have a header (definition).
			// 2. Have a body.
			// 3. Are self-contained.

			// Writing a loop that counts from 0 to 9.

			for (int counter = 0; counter < 10; counter++) {
				// This code repeats X times.
				Console.WriteLine($"counter is {counter}.");
			}
		}
	}
}
