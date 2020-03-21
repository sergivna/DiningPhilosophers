using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Philosopher
    {
        public int Number { get;}
        public Fork left;
        public Fork right;

        bool hasLeft;
        bool hasRight;

        public Philosopher(int number, Fork left, Fork right)
        {
            this.Number = number;
            this.left = left;
            this.right = right;
        }
        
        public void TakeForks()
        {
            hasLeft = left.TakeFork();
            hasRight = right.TakeFork();

            if (!hasLeft || !hasRight)
                throw new Exception("smth is wrong");
        }
        public void Eat()
        {
            Console.WriteLine($"Philosopher {Number} is eating");
            Thread.Sleep(10000);

            hasLeft = left.ReturnFork();
            hasRight = right.ReturnFork();

            Console.WriteLine($"Philosopher {Number} finished dinner");
        }
    }
}
