using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public List<Reservation> ReservationList
        {
            get { return reservationList; }
            set { reservationList = value; }
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
                    Console.Write("Are you sure you want to cancel the booking (yes/no): ");
                    string option = Console.ReadLine();

                    if (option == "yes")
                    {
                        re.Status = "Cancelled";
                        balance += re.ReservationCost;
                        Console.WriteLine("Reservation has been successfully cancelled.");
                        // need to check if theres voucher applied in the reservation
                        Console.WriteLine("Your total balance is now ${0:#.00}", balance);
                        break;
                    }
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

        public void rateHotel(string hid, double stars, string comment, List<HotelRating> hrtList, List<Hotel> hList)
        {
            // implementation
            HotelRating hr = new HotelRating(hid, stars, comment);
            hrtList.Add(hr);
            double totalStars = 0;
            int count = 0;
            foreach (HotelRating hrt in hrtList)
            {
                if (hrt.RatingId == hid)
                {
                    totalStars += hrt.RatingStars;
                    count++;
                }
                else
                {
                    continue;
                }
            }
            foreach (Hotel h in hList)
            {
                if (h.HotelID == hid)
                {
                    h.calcStars(totalStars, count);
                }
            }
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
                        Console.WriteLine(String.Format("${0:#.00} has been topped up to your account. Your total balance is now ${1:#.00}", tpamt, balance));
                        break;
                    }
                }
            }
        }

        public void makePayment(Reservation r)
        {
            string cardtype, cardno;
            Console.WriteLine("1) Pay by Account Balance");
            Console.WriteLine("2) Pay by Credit Card");
            Console.WriteLine("0) Exit");
            Console.WriteLine();
            Console.Write("Enter choice: ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    if (balance >= r.ReservationCost)
                    {
                        balance -= r.ReservationCost;
                        r.Status = "Confirmed";
                        Console.WriteLine("Reservation Paid Successfully!");
                        Console.WriteLine("${0:#.00} has been deducted from your account balance. Your remaining balance is ${1:#.00}", r.ReservationCost, balance);
                    }
                    else if (balance < r.ReservationCost)
                    {
                        Console.WriteLine("Insufficient Funds, Would you like to pay the remaining with your credit card?");
                        Console.WriteLine("1) Yes");
                        Console.WriteLine("2) No");
                        Console.WriteLine();
                        Console.Write("Enter choice: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Console.Write("Enter Type of Card: ");
                                cardtype = Console.ReadLine();
                                Console.Write("Enter Card Number: ");
                                cardno = Console.ReadLine();
                                Console.WriteLine("Reservation Paid Successfully!");
                                r.Status = "Confirmed";
                                break;
                            case 2:
                                return;
                        }
                    }
                    return;
                case 2:
                    Console.Write("Enter Type of Card: ");
                    cardtype = Console.ReadLine();
                    Console.Write("Enter Card Number: ");
                    cardno = Console.ReadLine();
                    Console.WriteLine("Reservation Paid Successfully!");
                    r.Status = "Confirmed";
                    return;
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
                if (re.Status == "Submitted" || re.Status == "Confirmed")
                {
                    if ((re.CheckInDate - DateTime.Now).TotalDays >= 2)
                    {
                        editable++;
                        Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15} ${4,-10:#.00}", re.ReservationId, re.CheckInDate.ToString("dd/MM/yyyy"), re.CheckOutDate.ToString("dd/MM/yyyy"), re.Status, re.ReservationCost);
                    }
                }
            }
            if (editable == 0)
            {
                Console.WriteLine("No Reservations can be editted.");
            }
        }

    }
}
