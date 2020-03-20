using System;
using System.Collections.Generic;
using System.Text;

namespace DiningPhilosophers
{
    class Algorithm
    {
        Table table { get; }

        public Algorithm(Table table)
        {
            this.table = table;
        }

        public void TryEating()
        {
            foreach (var philosopher in table.philosophers)
            {
                philosopher.Eat();
            }
        }

        public void Think() { }
    }
}
