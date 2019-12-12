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


    }
}
