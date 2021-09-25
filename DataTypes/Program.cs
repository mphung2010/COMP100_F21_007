using System;

namespace DataTypes {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens!

			// Declaring local variables that store text:
			string name;
			string email;

			// Initializing local variables that store text:
			email = "me@domain.com";

			// Declaring and initializing local variables at the same time:
			string address = "10 Test Dr";

			// Working with local variables that store integers:
			int age;
			age = 25;
			//int age = 25;

			// Working with local variables that store floating-point numbers:
			//double gpa;
			//gpa = 4.5;
			double gpa = 4.5;

			// Sometimes, even numberic values are treated as text.
			// They can be treated as text when the fact that they are numbers is irrelevant.
			string phone = "14165551234";

			// In C#, text (or strings) has to be surrounded with DOUBLE quotes.
			// Characters, however, have to be surrounded with SINGLE quotes.

			// Working with characters:
			char initial = 'L';

			// Working with booleans:
			bool isStudent = true;
		}
	}
}
