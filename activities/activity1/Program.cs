using System;

namespace activity1
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.Write("input first number: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("\ninput second number: ");
			int b = Convert.ToInt32(Console.ReadLine());
			int dif = Math.Abs(a-b);
			Console.WriteLine(a+" * "+b+" = "+(a*b));
			Console.WriteLine("The difference is " + dif);
			Console.WriteLine(a+" divided by "+b+" equals "+(a/b));
		}
	}
}
