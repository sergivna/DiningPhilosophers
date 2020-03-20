using System;
using System.Collections.Generic;
using System.Text;

namespace DiningPhilosophers
{
    class Fork
    {
        int number;
        public bool isFree { get; private set; }

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
