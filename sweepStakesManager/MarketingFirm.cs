using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    class MarketingFirm
    {
        private ISweepstakesManager sweepstakesManager;
       
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
            sweepstakesManager.GetSweepstakes();
        }

        //public void AddToQueue(Sweepstakes sweepstakes)
        //{
        //    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
        //}

        //public void AddToStack(Sweepstakes sweepstakes)
        //{

        //}


    }
}
