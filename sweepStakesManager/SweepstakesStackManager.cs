using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    class SweepstakesStackManager:ISweepstakesManager
    {
        Stack<Sweepstakes> newStack = new Stack<Sweepstakes>();

        public Sweepstakes GetSweepstakes(Sweepstakes sweepstakes)
        {
            return newStack.Pop();
        }

        public void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            newStack.Push(sweepstakes);
        }
    }
}
