using System;
using System.Collections.Generic;
using System.Text;

namespace DiningPhilosophers
{
    class Table
    {
        int NumOfThings { get; }
        public Philosopher[] philosophers;
        Fork[] forks;

        public Table(int number)
        {
            this.NumOfThings = number;
            this.philosophers = new Philosopher[NumOfThings];
            this.forks = new Fork[NumOfThings];

            for (int i = 0; i < forks.Length; i++)
            {
                forks[i] = new Fork(i);
            }

            for (int i = 0; i < NumOfThings; i++)
            {
                Fork right = forks[i];
                Fork left = forks[(i + 1) % NumOfThings];
                philosophers[i] = new Philosopher(i, left, right);
            }
        }


    }
}
