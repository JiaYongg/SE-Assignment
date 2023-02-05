using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize a few guests
            Guest guest1 = new Guest("Sam", "1", "93836739", "sam56@outlook.com", "S9584736A", 200.50);
            Guest guest2 = new Guest("Nat", "2", "83759257", "nat24@gmail.com", "S8347483N", 145.20);
            Guest guest3 = new Guest("Kim", "3", "84563445", "kim62@hotmail.com", "S9182745E", 50.60);
            Guest guest4 = new Guest("Lay", "4", "94785965", "lay@connect.np.edu.sg", "T0104957Z", 70.20);
            Guest guest5 = new Guest("Ken", "5", "93857365", "ken51@gmail.com", "S9858373G", 66.50);
            Guest guest6 = new Guest("Haz", "6", "81957484", "haz9485@outlook.com", "T0204857J", 10);

            List<Guest> guestList = new List<Guest>{guest1, guest2, guest3, guest4, guest5, guest6};

            List<string> facilities1 = new List<string>{"Gym", "Swimming Pool", "Lounge", "Sauna", "Casino"};
            List<string> facilities2 = new List<string>{"Swimming Pool", "Lounge", "Sauna", "Casino"};
            List<string> facilities3 = new List<string>{"Gym", "Swimming Pool", "Casino"};
            List<string> facilities4 = new List<string>{"Gym", "Swimming Pool"};
            List<string> facilities5 = new List<string>{"Gym", "Swimming Pool", "Lounge", "Sauna"};

            HotelReservation hr1 = new HotelReservation("101", true, 2, true, "King-sized Bed", 470);
            HotelReservation hr2 = new HotelReservation("102", false, 2, true, "Queen-sized Bed", 420);
            HotelReservation hr3 = new HotelReservation("103", true, 1, false, "Single Bed", 140);
            HotelReservation hr4 = new HotelReservation("104", true, 2, false, "Double Bed", 220);
            HotelReservation hr5 = new HotelReservation("105", false, 1, false, "Single Bed", 580);
            HotelReservation hr6 = new HotelReservation("106", true, 2, true, "Double Bed", 450);
            HotelReservation hr7 = new HotelReservation("107", true, 4, true, "Double King-sized Bed", 840);
            HotelReservation hr8 = new HotelReservation("108", false, 4, true, "Double Queen-sized Bed", 480);
            HotelReservation hr9 = new HotelReservation("109", false, 2, true, "King-sized Bed", 540);
            HotelReservation hr10 = new HotelReservation("110", true, 2, true, "Queen-sized Bed", 320);

            List<HotelReservation> hrList1 = new List<HotelReservation>{hr1, hr2};
            List<HotelReservation> hrList2 = new List<HotelReservation>{hr3, hr4};
            List<HotelReservation> hrList3 = new List<HotelReservation>{hr5, hr6};
            List<HotelReservation> hrList4 = new List<HotelReservation>{hr7, hr8};
            List<HotelReservation> hrList5 = new List<HotelReservation>{hr9, hr10};

            Hotel luxuryHotel = new Hotel( "Luxurious Palace", "21 Orchard Rd", "Luxury", 5, true, facilities1, hrList1);
            Hotel themedHotel = new Hotel("SkyHigh Hotel", "Bugis St 99", "Themed", 3, true, facilities2, hrList2);
            Hotel cityHotel = new Hotel("Central City Hotel", "184 Newton Rd", "City", 2, true, facilities3, hrList3);
            Hotel budgetHotel = new Hotel("Budget101", "123 Toa Payoh Rd", "Budget", 4, true, facilities4, hrList4);
            Hotel ffHotel = new Hotel("FF Hotel", "Changi Rd", "Family-Friendly", 3, true, facilities5, hrList5);
            
            

            while (true)
            {
                // simple login option
                //Console.WriteLine();
                Console.WriteLine("------------Log in as------------");
                Console.WriteLine("1) Guest");
                Console.WriteLine("2) Hotel Administrator");
                Console.WriteLine("3) Exit");
                Console.WriteLine();


                // choosing the options
                switch (EnterOption())
                {
                    case 1:
                        Console.Write("Enter NRIC: ");
                        string? nric = Console.ReadLine();
                        if (nric == null)
                        {
                            Console.WriteLine("NRIC cannot be empty!");
                        }
                        else
                        {
                            foreach (Guest g in guestList)
                            {
                                if (g.Nric == nric)
                                {
                                    Console.WriteLine("\nWelcome, {0}\n", g.Name);
                                    Console.WriteLine("1) Browse Hotel Rooms");
                                    Console.WriteLine("2) Reserve Hotel Room");
                                    Console.WriteLine("3) View Reservation History");
                                    Console.WriteLine("4) View Profile");
                                    Console.WriteLine("5) View Balance");
                                    Console.WriteLine("6) Exit");
                                    Console.WriteLine();

                                    // choosing the options
                                    switch (EnterOption())
                                    {
                                        case 1:
                                            continue;
                                        case 2:
                                            continue;
                                        case 3:
                                            continue;
                                        case 4:

                                            Console.WriteLine("Name: ", g.Name);
                                            Console.WriteLine("Contact Number: ", g.ContactNum);
                                            Console.WriteLine("Email: ", g.Email);

                                            continue;
                                        case 5:

                                            Console.WriteLine("You currently have ${0:#.00} in your account balance.", g.Balance);
                                            Console.WriteLine("------------Menu------------");
                                            Console.WriteLine("1) Top up");
                                            Console.WriteLine("2) Exit");

                                            switch (EnterOption())
                                            {
                                                case 1:
                                                    //user.topUp();
                                                    return;
                                                case 2:
                                                    continue;
                                            }
                                            return;
                                        case 6:
                                            continue;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }

                        return;

                    case 2:
                        continue;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("Invalid Option!\n");
                        continue;

                }

            }
        }
        public static int EnterOption()
        {
            // Validation to ensure the input are NUMBERS ONLY
            int main_choice;
            Console.Write("Enter choice: ");
            string? main_input = Console.ReadLine();
            bool success = Int32.TryParse(main_input, out main_choice);
            while (true)
            {
                if (!success)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Enter Integer Input only!");
                    break;
                }
                else
                {
                    break;
                }
            }
            return main_choice;
        }

    }
}
