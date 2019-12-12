using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    class  UserInterface
    {
        Contestant contestant = new Contestant();
        string QueOrStack;

        public  void GetFirstName()
        {
            Console.WriteLine("Please enter your first name");
            contestant.FirstName = Console.ReadLine();
            
        }

        public void GetLastName()
        {
            Console.WriteLine("Please enter your last name");
            contestant.LastName = Console.ReadLine();
        }

        public void GetEmailAddress()
        {
            Console.WriteLine("Please enter your email address");
            contestant.Email = Console.ReadLine();

        }

        public void ChooseQueueOrStack()
        {
            Console.WriteLine("Do you want to store the sweepstakes in a stack or queue?\n enter 1 for Stack or 2 for Queue");
            QueOrStack = Console.ReadLine().Trim();
            switch (QueOrStack)
            {
                case "1":
                    break;
                case "2":
                    break;

            }

        }


    }
}
