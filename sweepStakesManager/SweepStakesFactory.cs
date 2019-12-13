using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    class SweepStakesFactory
    {
        public ISweepstakesManager PickQueueOrStackStorageToStore( string choice)
        {
            choice = UserInterface.ChooseQueueOrStack();
            switch (choice)
            {
                case "1":
                    return new SweepstakesStackManager();
                case "2":
                    return new SweepstakesQueueManager();
                default:
                    UserInterface.NotAnAnswer();
                    return null;

            }
        }
    }
}
