using System;

namespace Exercise06 {
	class Program {
		static void Main(string[] args) {
			/*
			
			Write a program to display the numbers 1 … 20 on separate lines with an asterisk after each multiple of 5. (multiples asterisk) 

			*/

			for (int i = 1; i <= 20; i++) {
				if (i % 5 == 0) {
					Console.WriteLine($"{i}*"); // i + "*"
				}
				else {
					Console.WriteLine(i);
				}
			}
		}
	}
}
