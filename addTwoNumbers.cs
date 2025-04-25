// Example function call
using System;

class Program
{
	static void Main()
	{
		int a = 5;
		int b = 10;
		
		int sum = AddTwoNumbers(a, b);
		Console.WriteLine("The sum is: " + sum);
	}

	static int AddTwoNumbers(int a, int b)
	{
		return a + b;
	}
}