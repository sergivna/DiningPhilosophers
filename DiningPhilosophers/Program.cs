using System;

namespace DiningPhilosophers
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm algorithm = new Algorithm(5);
            algorithm.Execute();
            Console.ReadKey();
        }
    }
}
