using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Philosopher._3
{
    public class Chopstick
    {
        private object _lockA = new Object();

        private int _number;

        public Chopstick(int n)
        {
            _number = n;
        }

        public void PickUp(string direction, int _index)
        {
            try
            {
                Monitor.Enter(_lockA);
                Console.WriteLine(_index + "拿起" + direction + "筷子");
            }
            finally
            {
            }
        }

        public void PutDown(string direction, int _index)
        {
            try
            {
                Console.WriteLine(_index + "放下" + direction + "筷子");
            }
            finally
            {
                Monitor.Exit(_lockA);
            }
        }

        public int getNumber()
        {
            return _number;
        }
    }    
}
