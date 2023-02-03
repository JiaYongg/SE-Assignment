using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class Guest
    {
        private string name;
        private string id;
        private string contactNum;
        private string email;
        private string nric;
        private double balance;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ContactNum
        {
            get { return contactNum; }
            set { contactNum = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nric
        {
            get { return nric; }
            set { nric = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Guest(string name, string id, string contactNum, string email, string nric, double balance)
        {
            Name = name;
            Id = id;
            ContactNum = contactNum;
            Email = email;
            Nric = nric;
            Balance = balance;
        }

        public Reservation makeReservation()
        {
            // implementation

        }

        public bool cancelReservation()
        {
            // implementation

        }

        public void rateHotel()
        {
            // implementation

        }

    }
}
