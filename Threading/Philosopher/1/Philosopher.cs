using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.Philosopher._1
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
            PickUp();
            Chew();
            PickDown();
        }

        public void PickUp()
        {
            _left.PickUp("左邊");
            _right.PickUp("右邊");
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
                Eat();
        }
    }
}
