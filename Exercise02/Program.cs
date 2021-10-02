using System;

namespace Exercise02 {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens!

			// Write a console application that prompts the user for:
			// - Product price;
			// - Quantity;
			// - Tax rate.

			// And displays the order total, formatted as a currency value.

			// DECLARING VARIABLES
			double productPrice;
			int quantity;
			double taxRate;
			double total;

			// COLLECTING USER INPUT
			Console.WriteLine("Please enter the product price: ");
			productPrice = double.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the quantity: ");
			quantity = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the tax rate in decimal format: ");
			taxRate = Convert.ToDouble(Console.ReadLine());

			// ALGORITHM
			total = productPrice * quantity * (1 + taxRate);

			// DISPLAY OUTPUT
			Console.WriteLine($"\nThe order total is {total:C}");
		}
	}
}
