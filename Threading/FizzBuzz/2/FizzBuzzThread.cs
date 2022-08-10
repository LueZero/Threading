using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.FizzBuzz._2
{
	public class FizzBuzzThread
	{
		private static Object _lock = new Object();

		protected static int current = 1;

		private int _max;

		private bool _div3, _div5;

		private String _toPrint;

		public FizzBuzzThread(bool div3, bool div5, int max, String toPrint)
		{
			this._div3 = div3;
			this._div5 = div5;
			this._max = max;
			this._toPrint = toPrint;
		}

		public virtual void Print()
		{
			Console.WriteLine(_toPrint);		
		}

		public void Run()
		{
			while (true)
			{
				lock (_lock)
				{
					if (current > _max)
					{
						return;
					}

					if ((current % 3 == 0) == _div3 && (current % 5 == 0) == _div5)
					{
						Print();
						current++;
					}
				}
			}
		}
	}
}
