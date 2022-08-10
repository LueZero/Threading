using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Philosopher._2
{
    public class Chopstick
    {
        private object _lockA = new Object();
        private object _lockB = new Object();

        public Chopstick()
        {
        }

        public bool PickUp(string direction)
        {
            Console.WriteLine("拿起" + direction + "筷子");
            return Monitor.TryEnter(_lockA);
        }

        public void PutDown(string direction)
        {
            try
            {
                Console.WriteLine("放下" + direction + "筷子");
            }
            finally
            {
                Monitor.Exit(_lockA);
            }
        }
    }
}
