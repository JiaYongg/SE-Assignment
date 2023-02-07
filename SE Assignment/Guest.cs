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
        private List<Reservation> reservationList = new List<Reservation>();

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

        public void addReservation(Reservation r)
        {
            reservationList.Add(r);
        }

        public void cancelReservation(string rid)
        {
            foreach (Reservation re in reservationList)
            {
                if (rid == re.ReservationId)
                {
                    re.Status = "Cancelled";
                    Console.WriteLine("Reservation has been successfully cancelled.");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public void editReservation(string rid, DateTime ciDate, DateTime coDate)
        {
            foreach (Reservation re in reservationList)
            {
                if (rid == re.ReservationId)
                {
                    re.CheckInDate = ciDate;
                    re.CheckOutDate = coDate;
                    Console.WriteLine("Reservation has been successfully editted.");
                    break;
                }
                else
                {
                    continue;
                }
            }
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
                string? amt = Console.ReadLine();
                double tpamt;

                bool success = Double.TryParse(amt, out tpamt);
                if (!success)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Enter Numbers only!");
                    continue;
                }
                else
                {
                    if (tpamt <= 0)
                    {
                        Console.WriteLine("Invalid Amount!");
                    }
                    else if (tpamt > 0)
                    {
                        balance += tpamt;
                        Console.WriteLine(String.Format("${0} has been topped up to your account. Your total balance is now ${1}", tpamt, balance));
                    }
                }
            }
        }

        public void makePayment(Reservation r)
        {

            if (balance >= r.ReservationCost)
            {
                balance -= r.ReservationCost;
                Console.WriteLine("${0} has been deducted from your account balance. Your remaining balance is ${1}", Convert.ToString(r.ReservationCost), Convert.ToString(balance));
            }
            else if (balance < r.ReservationCost)
            {
                Console.WriteLine("Insufficient Funds, Topup your account balance or pay the remaining with your credit card.");
                // implementation

            }
        }

        public void displayAllReservations()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-10}", "Check-In Date", "Check-Out Date", "Status", "Cost");
            foreach (Reservation re in reservationList)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} ${3,-10:#.00}", re.CheckInDate.ToString("dd/MM/yyyy"), re.CheckOutDate.ToString("dd/MM/yyyy"), re.Status, re.ReservationCost);
            }
        }
        public void displayEditableReservations()
        {
            int editable = 0;
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15} ${4,-10}", "ID", "Check-In Date", "Check-Out Date", "Status", "Cost");
            foreach (Reservation re in reservationList)
            {
                //implementation
            }
        }

    }
}
