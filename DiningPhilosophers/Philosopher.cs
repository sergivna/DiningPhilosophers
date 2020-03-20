using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Philosopher
    {
        int Number { get;}
        Fork left;
        Fork right;

        bool hasLeft;
        bool hasRight;

        Thread thread;

        public Philosopher(int number, Fork left, Fork right)
        {
            this.Number = number;
            this.left = left;
            this.right = right;
        }

        public void Eat()
        {
            while (!hasLeft || !hasRight)
            {
                hasLeft = left.TakeFork();
                hasRight = right.TakeFork();
            }

             Console.WriteLine($"Philosopher {Number} is eating");
             Thread.Sleep(20);


            hasLeft = left.ReturnFork();
            hasRight = right.ReturnFork();

            Console.WriteLine("Philosopher finished");
        }
    }
}
