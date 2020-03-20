using System;
using System.Collections.Generic;
using System.Text;

namespace DiningPhilosophers
{
    class Philosopher
    {
        int number;
        Fork left;
        Fork right;

        public Philosopher(int number)
        {
            this.number = number;
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
