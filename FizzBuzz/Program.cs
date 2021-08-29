using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			// FizzBuzz problem
			// Print intigers 1-N
			// If the int is divisible by 3, print Fizz instead
			// If the int is divisible by 5, print Buzz instead
			// If the int is divisible by both 3 and 5, print FizzBuzz

			int endNumber = 50;


			for (int i = 1; i <= endNumber; i++)
			{
				string output = "";
				if (i % 3 == 0)
				{
					output += "Fizz";
				}
				if (i % 5 == 0)
				{
					output += "Buzz";
				}
				if (output == "")
				{
					output = i.ToString();
				}
				Console.WriteLine(output);
			}
		}
	}
}
