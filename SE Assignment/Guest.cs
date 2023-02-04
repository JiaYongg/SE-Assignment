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

        public void topUp()
        {
            while (true)
            {
                Console.Write("Enter the amount you want to top up: ");
                string amt = Console.ReadLine();
                double tpamt;

                bool success = Int32.TryParse(amt, out tpamt);
                if (!success)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Enter Numbers only!");
                    continue;
                }
                else
                {
                    if (amt <= 0)
                    {
                        Console.WriteLine("Invalid Amount!");
                    }
                    else if (amt > 0)
                    {
                        balance += amt;
                        Console.WriteLine(String.Format("${0} has been topped up to your account. Your total balance is now ${1}", amt, balance));
                    }
                }
            }
        }

        public void makePayment(Reservation r)
        {

            if (balance >= r.ReservationCost)
            {
                balance -= r.ReservationCost;
                Console.WritLine("${0} has been deducted from your account balance. Your remaining balance is ${1}".Format(r.ReservationCost, balance));
            }
            else if (balance < r.ReservationCost)
            {
                Console.WriteLine("Insufficient Funds, Topup your account balance or pay the remaining with your credit card.");
                // implementation

            }
        }

    }
}
