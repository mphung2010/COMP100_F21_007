using System;

namespace NestedLoops {
	class Program {
		static void Main(string[] args) {
			// NESTED LOOPS
			// Nested loops is a tool that can be used in many situations.
			// You create nested loops when implementing one loop inside another.
			// Nested loops come in handy when dealing with bidimensional objects (i.e. matrices).

			// Example: Writing a console app that displays a 10x10 matrix in the console,
			// in which each element is represented as:
			// <row number> <column number>
			// i.e. The first element would be 11, The second on the same row would be 12, etc.

			for (int row = 0; row < 10; row++) {
				for (int column = 0; column < 10; column++) {
					Console.Write($"{row}{column} ");
				}

				Console.WriteLine();
			}
		}
	}
}
