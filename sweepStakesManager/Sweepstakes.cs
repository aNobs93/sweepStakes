using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        Random rnd = new Random();
        
        Sweepstakes(string name)
        {
            
            contestants = new Dictionary<int, Contestant>();

        }

        void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count + 1;
            contestants.Add(contestant.RegistrationNumber, contestant);
            
            
        }

        Contestant PickWinner(Contestant contestant)
        {
            int i = rnd.Next(1, contestants.Count());
            contestant = contestants[i];
            return contestant;
        }

        void PrintContestantInfo(Contestant contestant)
        {
            contestant = PickWinner(contestant);
            Console.WriteLine(contestant.FirstName + " " + contestant.LastName);
            Console.WriteLine(contestant.Email);
            Console.WriteLine(contestant.Address);
            Console.WriteLine(contestant.RegistrationNumber);
        }
    }
}
