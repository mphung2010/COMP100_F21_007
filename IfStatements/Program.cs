using System;

namespace IfStatements {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens.

			// IF STATEMENTS
			// If statements are control structures that
			// define whether a code block will run.

			// If statements have two parts:
			// 1. Declaration (header).
			// 2. Body.
			// 3. Sometimes, if statements will have "else if" statements.
			// 4. Sometimes, if statements will have "else" statements.

			// Boolean statements are statements that return true or false.

			// Ex.: It is raining outside.
			// > false.

			// Ex.: The lights are on.
			// > true.

			// Ex.: 3 > 5
			// > false.

			// Ex.: 10 >= 5
			// > true.

			// Boolean statements can use comparison operators.
			// ==
			// !=
			// >
			// >=
			// <
			// <=

			// We are working on a program that outputs different messages
			// depending on the city provided by the user.

			string city = "Toronto";

			if (city == "Toronto") {
				// This code will run if city is equal to Toronto.
				Console.WriteLine("Toronto is a city in Canada.");
			}
			else if (city == "New York") {
				// This will only run if the first scenario is false.
				Console.WriteLine("New York is a city in the US.");
			}
			else if (city == "Paris") {
				// This will only run if the first and second scenarios are false.
				Console.WriteLine("Paris is a city in France.");
			}
			else {
				// This will only run if all of the scenarios above are false.
				Console.WriteLine("I do not know that city.");
			}

			// Code continues...
		}
	}
}
