using System;
using System.Collections.Generic;
using System.Text;

namespace DiningPhilosophers
{
    class Fork
    {
        int Number { get; }
        public bool isFree { get; private set; }

        public Fork(int number)
        {
            this.Number = number;
            isFree = true;
        }
        public bool TakeFork()
        {
            if(isFree)
            {
                isFree = false;
                return true;
            }

            return false;
        }

        public bool ReturnFork()
        {
            if(!isFree)
            {
                isFree = true;
                return true;
            }

            return false;
        }
    }
}
