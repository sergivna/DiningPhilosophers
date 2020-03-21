using System;
using System.Collections.Generic;
using System.Text;

namespace DiningPhilosophers
{
    class Table
    {
        int NumOfPhilosophers { get; }
        public Philosopher[] philosophers;
        public Fork[] forks;

        public Table(int number)
        {
            this.NumOfPhilosophers = number;
            this.philosophers = new Philosopher[NumOfPhilosophers];
            this.forks = new Fork[NumOfPhilosophers];

            for (int i = 0; i < forks.Length; i++)
            {
                forks[i] = new Fork(i);
            }

            for (int i = 0; i < NumOfPhilosophers; i++)
            {
                Fork right = forks[i];
                Fork left = forks[(i + 1) % NumOfPhilosophers];
                philosophers[i] = new Philosopher(i, left, right);
            }
        }


    }
}
