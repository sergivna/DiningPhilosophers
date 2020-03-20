using System;

namespace DiningPhilosophers
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm algorithm = new Algorithm(new Table(5));
            algorithm.TryEating();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
