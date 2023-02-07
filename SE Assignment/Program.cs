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
            // Initialization of Objects

            Guest guest1 = new Guest("Sam", "1", "93836739", "sam56@outlook.com", "S9584736A", 200.50);
            Guest guest2 = new Guest("Nat", "2", "83759257", "nat24@gmail.com", "S8347483N", 145.20);
            Guest guest3 = new Guest("Kim", "3", "84563445", "kim62@hotmail.com", "S9182745E", 50.60);
            Guest guest4 = new Guest("Lay", "4", "94785965", "lay@connect.np.edu.sg", "T0104957Z", 70.20);
            Guest guest5 = new Guest("Ken", "5", "93857365", "ken51@gmail.com", "S9858373G", 66.50);
            Guest guest6 = new Guest("Haz", "6", "81957484", "haz9485@outlook.com", "T0204857J", 10);

            Reservation reservation1 = new Reservation("1", new DateTime(2023, 1, 1), new DateTime(2023, 1, 5), 250, "Fulfilled");
            Reservation reservation2 = new Reservation("2", new DateTime(2023, 12, 12), new DateTime(2022, 12, 17), 500, "Submitted");
            Reservation reservation3 = new Reservation("3", new DateTime(2023, 1, 7), new DateTime(2023, 1, 8), 120, "Fulfilled");
            Reservation reservation4 = new Reservation("4", new DateTime(2023, 12, 30), new DateTime(2023, 1, 12), 700, "Confirmed");
            Reservation reservation5 = new Reservation("5", new DateTime(2023, 11, 18), new DateTime(2022, 11, 20), 300, "Submitted");
            Reservation reservation6 = new Reservation("6", new DateTime(2021, 1, 5), new DateTime(2021, 1, 10), 550, "No-Show");
            Reservation reservation7 = new Reservation("7", new DateTime(2021, 2, 8), new DateTime(2021, 2, 14), 600, "No-Show");
            Reservation reservation8 = new Reservation("8", new DateTime(2021, 3, 1), new DateTime(2021, 3, 2), 250, "Fulfilled");
            Reservation reservation9 = new Reservation("9", new DateTime(2021, 4, 22), new DateTime(2021, 4, 23), 200, "Fulfilled");
            Reservation reservation10 = new Reservation("10", new DateTime(2021, 5, 15), new DateTime(2021, 5, 20), 500, "Cancelled");

            Reservation reservation11 = new Reservation("11", DateTime.Now, DateTime.Now.AddDays(2), 250, "Confirmed");
            Reservation reservation12 = new Reservation("12", DateTime.Now.AddDays(10), DateTime.Now.AddDays(20), 250, "Confirmed");

            List<Reservation> reservationList = new List<Reservation> {reservation1, reservation2, reservation3, reservation4, reservation5,
                                                                       reservation6, reservation7, reservation8, reservation9,reservation10};

            List<Guest> guestList = new List<Guest> { guest1, guest2, guest3, guest4, guest5, guest6 };

            guest1.addReservation(reservation1);
            guest2.addReservation(reservation2);
            guest3.addReservation(reservation3);
            guest4.addReservation(reservation4);
            guest5.addReservation(reservation5);
            guest6.addReservation(reservation6);
            guest1.addReservation(reservation7);
            guest2.addReservation(reservation8);
            guest3.addReservation(reservation9);
            guest4.addReservation(reservation10);
            guest1.addReservation(reservation11);
            guest1.addReservation(reservation12);

            List<string> facilities1 = new List<string> { "Gym", "Swimming Pool", "Lounge", "Sauna", "Casino" };
            List<string> facilities2 = new List<string> { "Swimming Pool", "Lounge", "Sauna", "Casino" };
            List<string> facilities3 = new List<string> { "Gym", "Swimming Pool", "Casino" };
            List<string> facilities4 = new List<string> { "Gym", "Swimming Pool" };
            List<string> facilities5 = new List<string> { "Gym", "Swimming Pool", "Lounge", "Sauna" };

            Room room1 = new Room(101, "King-sized Bed", true, 2,  470);
            Room room2 = new Room(102, "Queen-sized Bed", false, 2, 420);
            Room room3 = new Room(103, "Single Bed", true, 1, 140);
            Room room4 = new Room(104, "Double Bed", true, 2, 220);
            Room room5 = new Room(105, "Single Bed", false, 1, 580);
            Room room6 = new Room(106, "Double Bed", true, 2, 450);
            Room room7 = new Room(107, "Double King-sized Bed", true, 4, 840);
            Room room8 = new Room(108, "Double Queen-sized Bed", false, 4, 480);
            Room room9 = new Room(109, "King-sized Bed", false, 2, 540);
            Room room10 = new Room(110, "Queen-sized Bed", true, 2, 320);

            List<Room> roomList1 = new List<Room> { room1, room2 };
            List<Room> roomList2 = new List<Room> { room3, room4 };
            List<Room> roomList3 = new List<Room> { room5, room6 };
            List<Room> roomList4 = new List<Room> { room7, room8 };
            List<Room> roomList5 = new List<Room> { room9, room10 };

            Hotel luxuryHotel = new Hotel("Luxurious Palace", "21 Orchard Rd", "Luxury", 5, true, facilities1, roomList1);
            Hotel themedHotel = new Hotel("SkyHigh Hotel", "Bugis St 99", "Themed", 3, true, facilities2, roomList2);
            Hotel cityHotel = new Hotel("Central City Hotel", "184 Newton Rd", "City", 2, true, facilities3, roomList3);
            Hotel budgetHotel = new Hotel("Budget101", "123 Toa Payoh Rd", "Budget", 4, true, facilities4, roomList4);
            Hotel ffHotel = new Hotel("FF Hotel", "Changi Rd", "Family-Friendly", 3, true, facilities5, roomList5);


            while (true)
            {
                // simple login option
                //Console.WriteLine();
                Console.WriteLine("------------Log in as------------");
                Console.WriteLine("1) Guest");
                Console.WriteLine("2) Hotel Administrator");
                Console.WriteLine("3) Exit");
                Console.WriteLine();

                Console.Write("Enter choice: ");
                int input = Convert.ToInt32(Console.ReadLine());
                // choosing the options
                switch (input)
                {
                    case 1:
                        Console.Write("Enter NRIC: ");
                        string? nric = Console.ReadLine();
                        if (nric == null)
                        {
                            Console.WriteLine("NRIC cannot be empty!");
                            continue;
                        }
                        else
                        {
                            bool inGuestMenu = true;
                            while (inGuestMenu)
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
                                        Console.WriteLine("0) Exit");
                                        Console.WriteLine();

                                        Console.Write("Enter choice: ");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        // choosing the options
                                        switch (input)
                                        {
                                            case 1:
                                                // for loop display rooms
                                                foreach (Room rm in roomList1)
                                                {
                                                    Console.WriteLine("Room: Bed Type:{0} Breakfast Served: {1} Max Guests: {2} Cost per night: ${3}", rm.BedType, rm.BreakfastServed, rm.MaxGuest, rm.CostPerNight);
                                                }
                                                continue;
                                            case 2:
                                                continue;
                                            case 3:
                                                bool inReservationHistory = true;
                                                while (inReservationHistory)
                                                {
                                                    Console.WriteLine("------------Reservation History------------");
                                                    g.displayAllReservations();

                                                    Console.WriteLine("------------Menu------------");
                                                    Console.WriteLine("1) Manage Reservations");
                                                    Console.WriteLine("0) Exit");
                                                    Console.WriteLine();

                                                    Console.Write("Enter choice: ");
                                                    input = Convert.ToInt32(Console.ReadLine());
                                                    switch (input)
                                                    {
                                                        case 0:
                                                            inReservationHistory = false;
                                                            continue;
                                                        case 1:
                                                            bool inManageReservations = true;
                                                            while (inManageReservations)
                                                            {
                                                                Console.WriteLine("------------Manage Reservations------------");
                                                                g.displayEditableReservations();

                                                                Console.WriteLine("------------Menu------------");
                                                                Console.WriteLine("1) Select Reservation To Edit");
                                                                Console.WriteLine("2) Select Reservation To Cancel");
                                                                Console.WriteLine("0) Exit");
                                                                Console.WriteLine();

                                                                Console.Write("Enter choice: ");
                                                                input = Convert.ToInt32(Console.ReadLine());
                                                                switch (input)
                                                                {
                                                                    case 0:
                                                                        inManageReservations = false;
                                                                        continue;
                                                                    case 1:
                                                                        Console.Write("Enter ID: ");
                                                                        string editID = Console.ReadLine();
                                                                        DateTime newCIDate = DateTime.Now;
                                                                        DateTime newCODate = DateTime.Now;

                                                                        while (!((newCIDate.Day - DateTime.Now.Day) >= 2) || !((newCODate.Day - newCIDate.Day) > 0))
                                                                        {
                                                                            Console.Write("Enter New Check-In Date: ");
                                                                            newCIDate = Convert.ToDateTime(Console.ReadLine());
                                                                            Console.Write("Enter New Check-Out Date: ");
                                                                            newCODate = Convert.ToDateTime(Console.ReadLine());

                                                                            if (!((newCIDate.Day - DateTime.Now.Day) >= 2))
                                                                            {
                                                                                Console.WriteLine("New Check-In Date must be more than 2 days from today!");
                                                                            }
                                                                            else if ((newCODate.Day - newCIDate.Day) < 0)
                                                                            {
                                                                                Console.WriteLine("Check-Out Date cannot be same or earlier than Check-In Date!");
                                                                            }
                                                                            else if (!((newCODate.Day - newCIDate.Day) > 0))
                                                                            {
                                                                                Console.WriteLine("Days between Check-In Date and Check-Out Date has to be more than 1!");
                                                                            }


                                                                        }
                                                                        g.editReservation(editID, newCIDate, newCODate);

                                                                        continue;
                                                                    case 2:
                                                                        Console.Write("Enter ID: ");
                                                                        string cancelID = Console.ReadLine();
                                                                        g.cancelReservation(cancelID);
                                                                        inManageReservations = false;
                                                                        continue;
                                                                    default:
                                                                        Console.WriteLine("Invalid Option!");
                                                                        return;
                                                                }

                                                            }
                                                            continue;
                                                        default:
                                                            Console.WriteLine("Invalid Option!");
                                                            return;
                                                    }
                                                }
                                                continue;

                                            case 4:

                                                Console.WriteLine("Name: {0,15}", g.Name);
                                                Console.WriteLine("Contact Number: {0,10}", g.ContactNum);
                                                Console.WriteLine("Email: {0,28}", g.Email);

                                                Console.WriteLine("------------Menu------------");
                                                Console.WriteLine("1) Exit");

                                                switch (EnterOption())
                                                {
                                                    case 1:
                                                        continue;
                                                    default:
                                                        Console.WriteLine("Invalid Option!");
                                                        return;
                                                }
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
                                            case 0:
                                                inGuestMenu = false;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                continue;
                            }

                        }
                        continue;

                    case 2:
                        continue;

                    case 3:
                        return;

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
