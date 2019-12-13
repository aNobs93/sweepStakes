using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type stack or queue");
            string input = Console.ReadLine();
            ISweepstakesManager manager =  SweepStakesFactory.PickQueueOrStackStorageToStore(input);
            MarketingFirm marketing = new MarketingFirm(manager);

        }
    }
}
