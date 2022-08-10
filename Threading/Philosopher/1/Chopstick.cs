using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Philosopher._1
{
    public class Chopstick
    {
        private object _lockA = new Object();

        public Chopstick()
        {
        }

        public void PickUp(string direction)
        {
            try
            {
                Monitor.Enter(_lockA);
                Console.WriteLine("拿起" + direction + "筷子");
            }
            finally
            {
               
            }
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
