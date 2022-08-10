using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.FizzBuzz._2
{
    public static class Answer
	{
		public static void Run()
        {
			int n = 100;
			var a = new FizzBuzzThread(true, true, n, "FizzBuzz");
			var b = new FizzBuzzThread(true, false, n, "Fizz");
			var c = new FizzBuzzThread(false, true, n, "Buzz");
			var d = new NumberThread(false, false, n);

            var thead1 = new Thread(a.Run);
            var thead2 = new Thread(b.Run);
            var thead3 = new Thread(c.Run);
            var thead4 = new Thread(d.Run);

            thead1.Start();
            thead2.Start();
            thead3.Start();
            thead4.Start();
        }
    }
}
