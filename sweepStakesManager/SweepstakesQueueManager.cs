using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    class SweepstakesQueueManager<T>:ISweepstakesManager
    {
        Queue<T> newQueue = new Queue<T>();
     
    }
}
