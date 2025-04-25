// Example function call
using System;

class Program
{
	static void Main()
	{
		int a = 5;
		int b = 10;

		int sum = AddTwoNumbers(a, b);
		Console.WriteLine($"The sum is: {sum}");
	}

	/// <summary>
	/// Adds two integers and returns the result.
	/// </summary>
	/// <param name="a">The first integer to add.</param>
	/// <param name="b">The second integer to add.</param>
	/// <returns>The sum of the two integers.</returns>
	static int AddTwoNumbers(int a, int b)
	{
		return a + b;
	}
	}
}