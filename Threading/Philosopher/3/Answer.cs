using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Philosopher._3
{
    public static class Answer
	{
		public static int size = 3;

		public static int leftOf(int i)
		{
			return i;
		}

		public static int rightOf(int i)
		{
			return (i + 1) % size;
		}

		public static void Run()
        {
			Chopstick[] chopsticks = new Chopstick[size + 1];

			for (int i = 0; i < size + 1; i++)
			{
				chopsticks[i] = new Chopstick(i);
			}

			List<Philosopher> philosophers = new List<Philosopher>();

			for (int i = 0; i < size; i++)
			{
				var a = leftOf(i);
				var b = rightOf(i);
				Chopstick left = chopsticks[leftOf(i)];
				Chopstick right = chopsticks[rightOf(i)];
				philosophers.Add(new Philosopher(i, left, right));
			}

			foreach (var item in philosophers)
			{
				var thread = new Thread(item.Run);
				thread.Start();
				//thread.Join();
			}
		}
    }
}
