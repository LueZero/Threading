using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.FizzBuzz._2
{
	public class NumberThread : FizzBuzzThread
	{
		public NumberThread(bool div3, bool div5, int max) : base(div3, div5, max, null)
        {
        }
		
		public override void Print()
		{
			Console.WriteLine(Current);
		}
	}
}
