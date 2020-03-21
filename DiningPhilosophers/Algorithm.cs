using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DiningPhilosophers
{
    class Algorithm
    {
        Thread[] threads;
        private Table table { get;}

        public Algorithm(int number)
        {
            table = new Table(number);
            threads = new Thread[number];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Think);
            }          
        }


        private bool TryEating(Philosopher philosopher)
        {
            if (Monitor.TryEnter(table.forks))
            {
                if (philosopher.left.isFree && philosopher.right.isFree)
                {
                    lock (philosopher.left)
                    {
                        lock (philosopher.right)
                        {
                            philosopher.TakeForks();
                            Monitor.Exit(table.forks);
                            philosopher.Eat();
                            return true;
                        }
                    }
                }
                else
                {
                    Monitor.Exit(table.forks);
                }
            }

            return false;
        }

        private void Think(object philosopher)
        {
            Philosopher phil = philosopher as Philosopher;
                
            if (phil == null)
                return;

            while(true)
            {
                if (TryEating(phil))
                {
                    Console.WriteLine($"Philosopher {phil.Number} is thinking");
                    Thread.Sleep(500);
                }
            }
        }

        public void Execute()
        {
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start(table.philosophers[i]);
            }

        }
    }
}
