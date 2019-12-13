using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    static class UserInterface
    {

        //Contestant contestant = new Contestant();
        

        public static void GetFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name");
            contestant.FirstName = Console.ReadLine();
            
        }

        public static void GetLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your last name");
            contestant.LastName = Console.ReadLine();
        }

        public static void GetEmailAddress(Contestant contestant)
        {
            Console.WriteLine("Please enter your email address");
            contestant.Email = Console.ReadLine();

        }

        public static string ChooseQueueOrStack()
        {
            string QueOrStack;
            Console.WriteLine("Do you want to store the sweepstakes in a stack or queue?\n enter 1 for Stack or 2 for Queue");
            return QueOrStack = Console.ReadLine().Trim();

        }

        public static void NotAnAnswer()
        {
            Console.WriteLine("Not a valid answer.");
        }


    }
}
