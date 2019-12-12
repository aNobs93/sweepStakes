using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakesManager
{
    public class Contestant
    {
        string fName;
        string lName;
        string email;
        string address;
        int registrationNumber;
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
    }
}
