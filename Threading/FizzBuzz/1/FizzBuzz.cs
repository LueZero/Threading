using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.FizzBuzz._1
{
    public class FizzBuzz
    {
		public static void Go(int n = 100)
		{
			for (int i = 1; i <= n; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
