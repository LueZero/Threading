using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Foo._1
{
    public static class Answer
	{
		public static void Run()
        {
			Foo foo = new Foo();

			Thread first = new Thread(foo.First);
			Thread second = new Thread(foo.Second);
			Thread third = new Thread(foo.Third);

			first.Start();
			second.Start();
			third.Start();
		}
    }
}
