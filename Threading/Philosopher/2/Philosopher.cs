using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.Philosopher._2
{
    public class Philosopher
    {
        private int bites = 10;

        private Chopstick _left, _right;

        public Philosopher(Chopstick left, Chopstick right)
        {
            _left = left;
            _right = right;
        }

        public void Eat()
        {
            if (PickUp())
            {
                Chew();
                PickDown();
            }
        }

        public bool PickUp()
        {
            // 嘗試拿筷子
            if (!_left.PickUp("左邊"))
            {
                return false;
            }

            if (!_right.PickUp("右邊"))
            {
                _left.PutDown("左邊");
                return false;
            }

            return true;
        }

        public void Chew()
        {
            Console.WriteLine("咀嚼");
        }

        public void PickDown()
        {
            _right.PutDown("右邊");
            _left.PutDown("左邊");
        }

        public void Run()
        {
            for (var i = 0; i < bites; i++)
            {
                Eat();
            }
        }
    }
}
