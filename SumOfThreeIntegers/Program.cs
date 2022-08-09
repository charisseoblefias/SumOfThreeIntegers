using System;

class SumOfThreeIntegers
{
	static void Main(String [] args)
	{
		Console.Write ("Enter first integer: ");
		int a = Int32.Parse (Console.ReadLine());
		Console.Write ("Enter second integer: ");
		int b = Int32.Parse (Console.ReadLine());
		Console.Write ("Enter third integer: ");
		int c = Int32.Parse (Console.ReadLine());
		Console.WriteLine ("The sum is {0}", a + b + c);
		Console.ReadKey();
		
	}
}