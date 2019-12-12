using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> newQueue = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            return newQueue.Dequeue();   
        }    

        public void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            newQueue.Enqueue(sweepstakes);
        }
    }
}
