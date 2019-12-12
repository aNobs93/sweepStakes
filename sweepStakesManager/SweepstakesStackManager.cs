using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    class SweepstakesStackManager<T>:ISweepstakesManager
    {
        Stack<T> newStack = new Stack<T>();

        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
