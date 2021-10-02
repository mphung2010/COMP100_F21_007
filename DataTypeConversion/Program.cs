using System;

namespace DataTypeConversion {
	class Program {
		static void Main(string[] args) {
			// Here is where the magic happens.

			// Everything the user types in the console is a string.
			string inputPrice = "9.99";
			string inputQuantity = "5";
			string inputHasDiscount = "true";
			string inputCashier = "A";

			// Converting string to double
			//double price = Convert.ToDouble(inputPrice);
			double price = double.Parse(inputPrice);

			// Converting string to int
			int quantity = Convert.ToInt32(inputQuantity);
			//int quantity = int.Parse(inputQuantity);

			// Converting string to bool
			//bool hasDiscount = Convert.ToBoolean(inputHasDiscount);
			bool hasDiscount = bool.Parse(inputHasDiscount);

			// Converting string to char
			char cashier = Convert.ToChar(inputCashier);
			//char cashier = char.Parse(inputCashier);


			// Casting is a data type conversion technique that can be used
			// as long as we are not converting to or from a string

			// Example: Converting 20 degrees Celsius to Fahrenheit

			double celsius = 20;
			double fahrenheit = (double)9 / 5 * celsius + 32;

			Console.WriteLine(fahrenheit);
		}
	}
}
