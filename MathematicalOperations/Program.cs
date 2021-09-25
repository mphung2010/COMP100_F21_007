using System;

namespace MathematicalOperations {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens!

			// Calculating the area of a square:
			double side = 9.7;
			double area = side * side;

			Console.WriteLine("The area is:");
			Console.WriteLine(area);

			// Mathematical operations are not possible between numbers and text.
			int number = 3;
			string text = "This is a text";
			
			// The line below gives an error.
			//string result = number * text;
		}
	}
}
