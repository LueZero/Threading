using System;
using System.Collections.Generic;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main()
        {
			Threading.Philosopher._1.Answer.Run();
            Threading.Philosopher._2.Answer.Run();
            Threading.Philosopher._3.Answer.Run();

            Threading.Foo._1.Answer.Run();
            Threading.Foo._2.Answer.Run();

            Threading.FizzBuzz._1.Answer.Run();
            Threading.FizzBuzz._2.Answer.Run();
        }
	}
}
