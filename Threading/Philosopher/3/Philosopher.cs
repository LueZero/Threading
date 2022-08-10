using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.Philosopher._3
{
    public class Philosopher
    {
        private int bites = 10;

        private Chopstick _lower, _hight;

        private string _left, _right;

        private int _index;

        public Philosopher(int i, Chopstick left, Chopstick right)
        {
            _index = i;

            if (left.getNumber() < right.getNumber())
            {
                _lower = left;
                _hight = right;

                _left = "左邊";
                _right = "右邊";
            }
            else
            {
                _lower = right;
                _hight = left;

                _left = "右邊";
                _right = "左邊";
            }
        }

        public void Eat()
        {
            PickUp();
            Chew();
            PickDown();
        }

        public void PickUp()
        {
            _lower.PickUp(_left, _index);
            _hight.PickUp(_right, _index);
        }

        public void Chew()
        {
            Console.WriteLine(_index + "咀嚼");
        }

        public void PickDown()
        {
            _hight.PutDown(_right, _index);
            _lower.PutDown(_left, _index);
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
