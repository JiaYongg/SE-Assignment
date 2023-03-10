using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialization of Objects

            Admin admin1 = new Admin("123", "password");

            Guest guest1 = new Guest("Sam", "1", "93836739", "sam56@outlook.com", "S9584736A", 200.50);
            Guest guest2 = new Guest("Nat", "2", "83759257", "nat24@gmail.com", "S8347483N", 245.20);
            Guest guest3 = new Guest("Kim", "3", "84563445", "kim62@hotmail.com", "S9182745E", 50.60);
            Guest guest4 = new Guest("Lay", "4", "94785965", "lay@connect.np.edu.sg", "T0104957Z", 70.20);
            Guest guest5 = new Guest("Ken", "5", "93857365", "ken51@gmail.com", "S9858373G", 66.50);
            Guest guest6 = new Guest("Haz", "6", "81957484", "haz9485@outlook.com", "T0204857J", 10);
            Guest guest7 = new Guest("Lin", "7", "87651234", "lin8765@outlook.com", "S9901234H", 22.20); // 1 old reservation


            Vouchers voucher1 = new Vouchers("1", 5, new DateTime(2024, 1, 5)); // voucher id is voucher code, eg. enter "1" for voucher code when applying voucher
            Vouchers voucher2 = new Vouchers("2", 5, new DateTime(2025, 2, 1));
            Vouchers voucher3 = new Vouchers("3", 5, new DateTime(2024, 5, 7));
            Vouchers voucher4 = new Vouchers("4", 5, new DateTime(2024, 12, 10));
            Vouchers voucher5 = new Vouchers("5", 5, new DateTime(2021, 9, 8)); // Expired voucher to test


            List<Vouchers> vList = new List<Vouchers> { voucher1, voucher2, voucher3, voucher4, voucher5 };

            Reservation reservation1 = new Reservation("1", new DateTime(2023, 1, 1), new DateTime(2023, 1, 5), 1880, "Fulfilled");
            Reservation reservation2 = new Reservation("2", new DateTime(2023, 12, 12), new DateTime(2023, 12, 17), 2100, "Submitted");  //Testable
            Reservation reservation3 = new Reservation("3", new DateTime(2023, 1, 7), new DateTime(2023, 1, 8), 140, "Fulfilled");
            Reservation reservation4 = new Reservation("4", new DateTime(2023, 12, 30), new DateTime(2024, 1, 12), 2860, "Confirmed"); //Testable
            Reservation reservation5 = new Reservation("5", new DateTime(2023, 11, 18), new DateTime(2023, 11, 20), 840, "Submitted"); //Testable
            Reservation reservation6 = new Reservation("6", new DateTime(2021, 1, 5), new DateTime(2021, 1, 10), 2900, "No-Show");
            Reservation reservation7 = new Reservation("7", new DateTime(2021, 2, 8), new DateTime(2021, 2, 14), 2700, "No-Show");
            Reservation reservation8 = new Reservation("8", new DateTime(2021, 3, 1), new DateTime(2021, 3, 2), 840, "Fulfilled");
            Reservation reservation9 = new Reservation("9", new DateTime(2021, 4, 22), new DateTime(2021, 4, 23), 480, "Fulfilled");
            Reservation reservation10 = new Reservation("10", new DateTime(2021, 5, 15), new DateTime(2021, 5, 20), 2700, "Cancelled");

            Reservation reservation11 = new Reservation("11", DateTime.Now, DateTime.Now.AddDays(2), 640, "Confirmed");
            Reservation reservation12 = new Reservation("12", DateTime.Now.AddDays(10), DateTime.Now.AddDays(20), 3200, "Confirmed");
            List<Reservation> reservationList = new List<Reservation> {reservation1, reservation2, reservation3, reservation4, reservation5,
                                                                       reservation6, reservation7, reservation8, reservation9,reservation10};

            List<Guest> guestList = new List<Guest> { guest1, guest2, guest3, guest4, guest5, guest6, guest7};

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
            guest7.addReservation(reservation10);

            List<string> facilities1 = new List<string> { "Gym", "Swimming Pool", "Lounge", "Sauna", "Casino" };
            List<string> facilities2 = new List<string> { "Swimming Pool", "Lounge", "Sauna", "Casino" };
            List<string> facilities3 = new List<string> { "Gym", "Swimming Pool", "Casino" };
            List<string> facilities4 = new List<string> { "Gym", "Swimming Pool" };
            List<string> facilities5 = new List<string> { "Gym", "Swimming Pool", "Lounge", "Sauna" };

            RoomType roomType1 = new RoomType("1", "King-sized Bed", "Yes", 2, 470);
            RoomType roomType2 = new RoomType("2", "Queen-sized Bed", "No", 2, 420);
            RoomType roomType3 = new RoomType("3", "Single Bed", "Yes", 1, 140);
            RoomType roomType4 = new RoomType("4", "Double Bed", "Yes", 2, 220);
            RoomType roomType5 = new RoomType("5", "Single Bed", "No", 1, 580);
            RoomType roomType6 = new RoomType("6", "Double Bed", "Yes", 2, 450);
            RoomType roomType7 = new RoomType("7", "Double King-sized Bed", "Yes", 4, 840);
            RoomType roomType8 = new RoomType("8", "Double Queen-sized Bed", "No", 4, 480);
            RoomType roomType9 = new RoomType("9", "King-sized Bed", "No", 2, 540);
            RoomType roomType10 = new RoomType("10", "Queen-sized Bed", "Yes", 2, 320);

            List<RoomType> mainRTList = new List<RoomType> { roomType1, roomType2, roomType3, roomType4, roomType5, roomType6, roomType7, roomType8, roomType9, roomType10 };

            List<RoomType> roomTypeList1 = new List<RoomType> { roomType1, roomType2 };
            List<RoomType> roomTypeList2 = new List<RoomType> { roomType3, roomType4 };
            List<RoomType> roomTypeList3 = new List<RoomType> { roomType5, roomType6 };
            List<RoomType> roomTypeList4 = new List<RoomType> { roomType7, roomType8 };
            List<RoomType> roomTypeList5 = new List<RoomType> { roomType9, roomType10 };

            RoomTypeReservation rtr1 = new RoomTypeReservation(reservation1, roomType1);
            RoomTypeReservation rtr2 = new RoomTypeReservation(reservation2, roomType2);
            RoomTypeReservation rtr3 = new RoomTypeReservation(reservation3, roomType3);
            RoomTypeReservation rtr4 = new RoomTypeReservation(reservation4, roomType4);
            RoomTypeReservation rtr5 = new RoomTypeReservation(reservation5, roomType2);
            RoomTypeReservation rtr6 = new RoomTypeReservation(reservation6, roomType5);
            RoomTypeReservation rtr7 = new RoomTypeReservation(reservation7, roomType6);
            RoomTypeReservation rtr8 = new RoomTypeReservation(reservation8, roomType7);
            RoomTypeReservation rtr9 = new RoomTypeReservation(reservation9, roomType8);
            RoomTypeReservation rtr10 = new RoomTypeReservation(reservation10, roomType9);
            RoomTypeReservation rtr11 = new RoomTypeReservation(reservation11, roomType10);
            RoomTypeReservation rtr12 = new RoomTypeReservation(reservation12, roomType10);

            List<RoomTypeReservation> rtrList = new List<RoomTypeReservation> { rtr1, rtr2, rtr3, rtr4, rtr5, rtr6, rtr7, rtr8, rtr9, rtr10, rtr11, rtr12 };

            Hotel luxuryHotel = new Hotel("1", "Luxurious Palace", "21 Orchard Rd", "Luxury", 5, true, facilities1, roomTypeList1); // change to boolean value to test that voucher prompt not shown
            Hotel themedHotel = new Hotel("2", "SkyHigh Hotel", "Bugis St 99", "Themed", 3, true, facilities2, roomTypeList2);
            Hotel cityHotel = new Hotel("3", "Central City Hotel", "184 Newton Rd", "City", 2, true, facilities3, roomTypeList3);
            Hotel budgetHotel = new Hotel("4", "Budget101", "123 Toa Payoh Rd", "Budget", 4, true, facilities4, roomTypeList4);
            Hotel ffHotel = new Hotel("5", "FF Hotel", "Changi Rd", "Family-Friendly", 3, true, facilities5, roomTypeList5);

            // Add all hotels to hotelcollection
            HotelList hotelList = new HotelList();
            hotelList.HotelCollection.Add(luxuryHotel);
            hotelList.HotelCollection.Add(themedHotel);
            hotelList.HotelCollection.Add(cityHotel);
            hotelList.HotelCollection.Add(budgetHotel);
            hotelList.HotelCollection.Add(ffHotel);

            HotelRating hrt1 = new HotelRating("1", 5, "It was nice");
            HotelRating hrt2 = new HotelRating("2", 4.3, "Pretty good");
            HotelRating hrt3 = new HotelRating("3", 2.7, "Room was dirty");
            HotelRating hrt4 = new HotelRating("4", 3.2, "Expected better service");
            HotelRating hrt5 = new HotelRating("5", 5, "Excellent experience");

            List<HotelRating> hrtList = new List<HotelRating> { hrt1, hrt2, hrt3, hrt4, hrt5 };

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
                    // Login as Guest
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
                                        Console.WriteLine("6) Make Payment");
                                        Console.WriteLine("0) Exit");
                                        Console.WriteLine();

                                        Console.Write("Enter choice: ");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        // choosing the options
                                        switch (input)
                                        {
                                            // Browse Hotel Rooms
                                            case 1:
                                                Console.WriteLine("Would you like to search for rooms? ");
                                                Console.WriteLine("1) Yes");
                                                Console.WriteLine("2) No");
                                                Console.WriteLine();
                                                Console.Write("Enter choice: ");
                                                input = Convert.ToInt32(Console.ReadLine());
                                                // choosing the options
                                                switch (input)
                                                {                                                   
                                                    // Yes for search
                                                    case 1:
                                                        displayAllRooms(hotelList);
                                                        Console.WriteLine("\nChoose search by:"); // guest’s budget, hotel type, review score, location and facilities
                                                        Console.WriteLine("1) Budget");
                                                        Console.WriteLine("2) Hotel Type");
                                                        Console.WriteLine("3) Review Score");
                                                        Console.WriteLine("4) Location");
                                                        Console.WriteLine("5) Facilities");
                                                        Console.WriteLine("0) Exit");

                                                        Console.Write("Enter choice: ");
                                                        input = Convert.ToInt32(Console.ReadLine());
                                                        switch (input)
                                                        {
                                                            // Exit
                                                            case 0:
                                                                continue;
                                                            // Search By Budget
                                                            case 1:
                                                                Console.Write("Enter Min cost: ");
                                                                int minCost = Convert.ToInt32(Console.ReadLine());
                                                                Console.Write("Enter Max cost: ");
                                                                int maxCost = Convert.ToInt32(Console.ReadLine());
                                                                Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-5} {4,-16} {5,-15} {6,-10}", "Bed Type", "MaxGuest", "Breakfast Served", "Cost Per Night", "Hotel Type", "Location", "Facilities");
                                                                HotelIterator hotelIterator1 = new HotelIterator(hotelList);
                                                                while (hotelIterator1.hasNext())
                                                                {
                                                                    StringBuilder sb = new StringBuilder();
                                                                    Hotel hotel = (Hotel)hotelIterator1.next();
                                                                    for (int i = 0; i < hotel.FacilityList.Count; i++)
                                                                    {
                                                                        if (i == hotel.FacilityList.Count - 1)
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i]);
                                                                        }
                                                                        else
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i] + ", ");
                                                                        }
                                                                    }
                                                                    foreach (RoomType rt in hotel.RoomTypeList)
                                                                    {
                                                                        if (rt.CostPerNight >= minCost && rt.CostPerNight <= maxCost)
                                                                        {
                                                                            Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-10:#.00} {4,-20} {5,-15} {6,-10}", rt.BedType, rt.MaxGuest, rt.BreakfastServed, rt.CostPerNight, hotel.Category, hotel.Location, sb);
                                                                        }
                                                                    }
                                                                }
                                                                continue;
                                                            // Search By Hotel Type
                                                            case 2:
                                                                Console.Write("Enter Hotel Type: ");
                                                                string type = Console.ReadLine();
                                                                Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-5} {4,-16} {5,-15} {6,-10}", "Bed Type", "MaxGuest", "Breakfast Served", "Cost Per Night", "Hotel Type", "Location", "Facilities");
                                                                HotelIterator hotelIterator2 = new HotelIterator(hotelList);
                                                                while (hotelIterator2.hasNext())
                                                                {
                                                                    StringBuilder sb = new StringBuilder();
                                                                    Hotel hotel = (Hotel)hotelIterator2.next();
                                                                    for (int i = 0; i < hotel.FacilityList.Count; i++)
                                                                    {
                                                                        if (i == hotel.FacilityList.Count - 1)
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i]);
                                                                        }
                                                                        else
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i] + ", ");
                                                                        }
                                                                    }
                                                                    foreach (RoomType rt in hotel.RoomTypeList)
                                                                    {
                                                                        if (hotel.Category == type)
                                                                        {
                                                                            Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-10:#.00} {4,-20} {5,-15} {6,-10}", rt.BedType, rt.MaxGuest, rt.BreakfastServed, rt.CostPerNight, hotel.Category, hotel.Location, sb);
                                                                        }
                                                                    }
                                                                }
                                                                continue;
                                                            // Search by Review Score
                                                            case 3:
                                                                Console.Write("Enter Min Rating: ");
                                                                int minstars = Convert.ToInt32(Console.ReadLine());
                                                                Console.Write("Enter Max Rating: ");
                                                                int maxstars = Convert.ToInt32(Console.ReadLine());
                                                                Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-5} {4,-16} {5,-15} {6,-10}", "Bed Type", "MaxGuest", "Breakfast Served", "Cost Per Night", "Hotel Type", "Location", "Facilities");
                                                                HotelIterator hotelIterator3 = new HotelIterator(hotelList);
                                                                while (hotelIterator3.hasNext())
                                                                {
                                                                    StringBuilder sb = new StringBuilder();
                                                                    Hotel hotel = (Hotel)hotelIterator3.next();
                                                                    for (int i = 0; i < hotel.FacilityList.Count; i++)
                                                                    {
                                                                        if (i == hotel.FacilityList.Count - 1)
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i]);
                                                                        }
                                                                        else
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i] + ", ");
                                                                        }
                                                                    }
                                                                    foreach (RoomType rt in hotel.RoomTypeList)
                                                                    {
                                                                        if (hotel.NumStars >= minstars && hotel.NumStars >= maxstars)
                                                                        {
                                                                            Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-10:#.00} {4,-20} {5,-15} {6,-10}", rt.BedType, rt.MaxGuest, rt.BreakfastServed, rt.CostPerNight, hotel.Category, hotel.Location, sb);
                                                                        }
                                                                    }
                                                                }
                                                                continue;
                                                            // Search by Location
                                                            case 4:
                                                                Console.Write("Enter location: ");
                                                                string location = Console.ReadLine();
                                                                Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-5} {4,-16} {5,-15} {6,-10}", "Bed Type", "MaxGuest", "Breakfast Served", "Cost Per Night", "Hotel Type", "Location", "Facilities");
                                                                HotelIterator hotelIterator4 = new HotelIterator(hotelList);
                                                                while (hotelIterator4.hasNext())
                                                                {
                                                                    StringBuilder sb = new StringBuilder();
                                                                    Hotel hotel = (Hotel)hotelIterator4.next();
                                                                    for (int i = 0; i < hotel.FacilityList.Count; i++)
                                                                    {
                                                                        if (i == hotel.FacilityList.Count - 1)
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i]);
                                                                        }
                                                                        else
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i] + ", ");
                                                                        }
                                                                    }
                                                                    foreach (RoomType rt in hotel.RoomTypeList)
                                                                    {
                                                                        if (hotel.Location == location)
                                                                        {
                                                                            Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-10:#.00} {4,-20} {5,-15} {6,-10}", rt.BedType, rt.MaxGuest, rt.BreakfastServed, rt.CostPerNight, hotel.Category, hotel.Location, sb);
                                                                        }
                                                                    }
                                                                }
                                                                continue;
                                                            // Search by Facilities
                                                            case 5:
                                                                Console.Write("Enter facilities: ");
                                                                string facilities = Console.ReadLine();
                                                                Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-5} {4,-16} {5,-15} {6,-10}", "Bed Type", "MaxGuest", "Breakfast Served", "Cost Per Night", "Hotel Type", "Location", "Facilities");
                                                                HotelIterator hotelIterator5 = new HotelIterator(hotelList);
                                                                while (hotelIterator5.hasNext())
                                                                {
                                                                    StringBuilder sb = new StringBuilder();
                                                                    Hotel hotel = (Hotel)hotelIterator5.next();
                                                                    for (int i = 0; i < hotel.FacilityList.Count; i++)
                                                                    {
                                                                        if (i == hotel.FacilityList.Count - 1)
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i]);
                                                                        }
                                                                        else
                                                                        {
                                                                            sb.Append(hotel.FacilityList[i] + ", ");
                                                                        }
                                                                    }
                                                                    foreach (RoomType rt in hotel.RoomTypeList)
                                                                    {
                                                                        var allFacList = sb.ToString().Split(", ");
                                                                        var hasStringList = facilities.Split(", ");

                                                                        bool hasAllElements = true;
                                                                        foreach (var item in hasStringList)
                                                                        {
                                                                            if (!allFacList.Contains(item))
                                                                            {
                                                                                hasAllElements = false;
                                                                                break;
                                                                            }
                                                                        }

                                                                        if (hasAllElements)
                                                                        {
                                                                            Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-10:#.00} {4,-20} {5,-15} {6,-10}", rt.BedType, rt.MaxGuest, rt.BreakfastServed, rt.CostPerNight, hotel.Category, hotel.Location, sb);
                                                                        }

                                                                    }
                                                                }
                                                                continue;
                                                        }
                                                        continue;
                                                    // No
                                                    case 2:
                                                        displayAllRooms(hotelList);
                                                        continue;
                                                }
                                                continue;
                                            // Reserve Hotel Room
                                            case 2:
                                                DateTime ci, co;
                                                bool noNewReservation = true;
                                                while (noNewReservation)
                                                {
                                                    while (true)
                                                    {
                                                        Console.WriteLine("------------Make Reservation------------");
                                                        Console.Write("Enter Check-In Date: ");
                                                        ci = Convert.ToDateTime(Console.ReadLine());
                                                        Console.Write("Enter Check-Out Date: ");
                                                        co = Convert.ToDateTime(Console.ReadLine());
                                                        // co cant be same day or before ci
                                                        if (co <= ci)
                                                        {
                                                            Console.WriteLine("Check out date must be 1 or more days infront of check in date!");
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }


                                                    List<RoomType> availRooms = new List<RoomType>(mainRTList);

                                                    foreach (RoomTypeReservation rtr in rtrList)
                                                    {
                                                        // Check if dates is not before checkout but after checkin
                                                        if (co >= rtr.Reservation.CheckInDate && co <= rtr.Reservation.CheckOutDate && (rtr.Reservation.Status == "Submitted" || rtr.Reservation.Status == "Confirmed"))
                                                        {
                                                            availRooms.Remove(rtr.RoomType);

                                                            continue;
                                                        }
                                                        // Check if dates before checkout but after checkin
                                                        else if (ci > rtr.Reservation.CheckInDate && ci < rtr.Reservation.CheckOutDate && (rtr.Reservation.Status == "Submitted" || rtr.Reservation.Status == "Confirmed"))
                                                        {
                                                            availRooms.Remove(rtr.RoomType);
                                                            continue;
                                                        }
                                                        // check if dates inside checkout and checkin
                                                        else if (ci >= rtr.Reservation.CheckInDate && co <= rtr.Reservation.CheckOutDate && (rtr.Reservation.Status == "Submitted" || rtr.Reservation.Status == "Confirmed"))
                                                        {
                                                            availRooms.Remove(rtr.RoomType);
                                                            continue;
                                                        }
                                                        else
                                                        {
                                                            continue;
                                                        }
                                                    }
                                                    Console.WriteLine("------------Availble Rooms------------");
                                                    Console.WriteLine("{0,5} {1,-30} {2,-15} {3,-15} {4,-15:#.00} {5,-15:#.00}", "Room ID", "Bed Type", "Breakfast Served", "Max Guests", "Cost Per Night", "Subtotal Cost");
                                                    foreach (RoomType rt in availRooms)
                                                    {
                                                        Console.WriteLine("{0,5} {1,-30} {2,-15} {3,-15} ${4,-15:#.00} ${5,-15:#.00}", rt.RoomId, rt.BedType, rt.BreakfastServed, rt.MaxGuest, rt.CostPerNight, rt.CostPerNight * ((co - ci).Days));
                                                    }

                                                    int rtId;

                                                    while (true)
                                                    {
                                                        Console.Write("\nEnter room to reserve: ");
                                                        rtId = Convert.ToInt32(Console.ReadLine());
                                                        if (rtId > availRooms.Count())
                                                        {
                                                            Console.WriteLine("Invalid room selected");
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }



                                                    int reservationId = reservationList.Count + 1;
                                                    double newSubTotal = mainRTList[rtId - 1].CostPerNight * ((co - ci).Days);
                                                    Reservation newReservation = new Reservation(reservationId.ToString(), ci, co, newSubTotal, "Submitted");
                                                    reservationList.Add(newReservation);
                                                    g.ReservationList.Add(newReservation);

                                                    RoomTypeReservation newRtr = new RoomTypeReservation(newReservation, mainRTList[rtId]);
                                                    rtrList.Add(newRtr); 

                                                    Console.WriteLine("Thank you for reserving a room with us.");


                                                    Console.WriteLine("\nWould you want to reserve another room?");
                                                    Console.WriteLine("1) Yes");
                                                    Console.WriteLine("2) No");

                                                    Console.Write("Enter choice: ");
                                                    input = Convert.ToInt32(Console.ReadLine());
                                                    if (input == 2)
                                                    {
                                                        noNewReservation = false;
                                                    }
                                                }
                                                continue;
                                            // View Reservation History
                                            case 3:
                                                bool inReservationHistory = true;
                                                while (inReservationHistory)
                                                {
                                                    Console.WriteLine("------------Reservation History------------");
                                                    if (g.displayAllReservations() != false)
                                                    {
                                                        Console.WriteLine("------------Menu------------");
                                                        Console.WriteLine("1) Manage Reservations");
                                                        Console.WriteLine("2) Rate Hotels");
                                                        Console.WriteLine("0) Exit");
                                                        Console.WriteLine();

                                                        Console.Write("Enter choice: ");
                                                        input = Convert.ToInt32(Console.ReadLine());
                                                        switch (input)
                                                        {
                                                            // Exit
                                                            case 0:
                                                                inReservationHistory = false;
                                                                continue;
                                                            // Manage Reservation
                                                            case 1:
                                                                bool inManageReservations = true;
                                                                while (inManageReservations)
                                                                {
                                                                    Console.WriteLine("------------Manage Reservations------------");
                                                                    if (g.displayEditableReservations() != false)
                                                                    {
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


                                                                                bool editedReservation = false;
                                                                                while (!((newCIDate.Day - DateTime.Now.Day) >= 2) || !((newCODate.Day - newCIDate.Day) > 0))
                                                                                {
                                                                                    Console.Write("Enter New Check-In Date: ");
                                                                                    newCIDate = Convert.ToDateTime(Console.ReadLine());
                                                                                    Console.Write("Enter New Check-Out Date: ");
                                                                                    newCODate = Convert.ToDateTime(Console.ReadLine());

                                                                                    foreach (RoomTypeReservation rtr in rtrList)
                                                                                    {
                                                                                        if (rtr.Reservation.ReservationId == editID)
                                                                                        {
                                                                                            bool avail = isRoomAvail(reservationList, rtrList, rtr.RoomType, newCIDate, newCODate, editID);

                                                                                            if (avail)
                                                                                            {
                                                                                                if (!(((newCIDate - DateTime.Now).Days) >= 2))
                                                                                                {
                                                                                                    Console.WriteLine("Edit failed! Check in date must be 2 days after today.");
                                                                                                }
                                                                                                else if (((newCODate - newCIDate).Days) < 0)
                                                                                                {
                                                                                                    Console.WriteLine("Check-Out Date cannot be same or earlier than Check-In Date!");
                                                                                                }
                                                                                                else if (!(((newCODate - newCIDate).Days) > 0))
                                                                                                {
                                                                                                    Console.WriteLine("Days between Check-In Date and Check-Out Date has to be more than 1!");
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    g.editReservation(editID, newCIDate, newCODate, rtr.RoomType.CostPerNight * ((newCODate - newCIDate).Days));
                                                                                                    editedReservation = true;
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.WriteLine("Room not available at this date, change to a new date");
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (editedReservation)
                                                                                    {
                                                                                        break;
                                                                                    }                                                                                        
                                                                                }
                                                                                continue;
                                                                            case 2:
                                                                                Console.Write("Enter ID: ");
                                                                                string cancelID = Console.ReadLine();
                                                                                if (g.cancelReservation(cancelID) == true)
                                                                                {
                                                                                    inManageReservations = false;
                                                                                }

                                                                                continue;
                                                                            default:
                                                                                Console.WriteLine("Invalid Option!");
                                                                                return;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        break;
                                                                    }


                                                                }
                                                                continue;
                                                            case 2:
                                                                bool inRateHotels = true;
                                                                bool found;
                                                                List<string> trackList = new List<string>();
                                                                List<string> checkHotelList = new List<string>();
                                                                while (inRateHotels)
                                                                {
                                                                    Console.WriteLine("------------Rate Hotels------------");
                                                                    Console.WriteLine("{0,-5} {1,-15}    {2,-20}   {3,-25} {4,-30}", "ID", "Hotel Name", "Check In Date", "Check Out Date", "Cost");
                                                                    foreach (Hotel h in hotelList.HotelCollection)
                                                                    {
                                                                        foreach (Reservation r in g.ReservationList)
                                                                        {
                                                                            foreach (RoomTypeReservation rtr in rtrList)
                                                                            {
                                                                                if (rtr.Reservation.ReservationId == r.ReservationId && r.Status == "Fulfilled")
                                                                                {
                                                                                    foreach (RoomType rt in h.RoomTypeList)
                                                                                    {
                                                                                        if (rt == rtr.RoomType && trackList.Contains(h.HotelID) == false)
                                                                                        {
                                                                                            Console.WriteLine("{0,-5} {1,-15}   {2,-20}   {3,-25} ${4,-30}", h.HotelID, h.Name, rtr.Reservation.CheckInDate, rtr.Reservation.CheckOutDate, rtr.Reservation.ReservationCost);
                                                                                            checkHotelList.Add(h.HotelID);
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    Console.WriteLine("------------Menu------------");
                                                                    Console.WriteLine("1) Select Hotel to give Rating");
                                                                    Console.WriteLine("0) Exit");
                                                                    Console.WriteLine();

                                                                    Console.Write("Enter choice: ");
                                                                    input = Convert.ToInt32(Console.ReadLine());
                                                                    switch (input)
                                                                    {
                                                                        case 0:
                                                                            inRateHotels = false;
                                                                            continue;
                                                                        case 1:
                                                                            Console.Write("Enter Hotel ID: ");
                                                                            string hid = Console.ReadLine();
                                                                            bool check = checkHotelExist(hotelList, hid);
                                                                            if (check == false)
                                                                            {
                                                                                Console.WriteLine("Hotel does not exist!");
                                                                                continue;
                                                                            }
                                                                            if (checkHotelList.Contains(hid) == false)
                                                                            {
                                                                                Console.WriteLine("Please enter hotel ID from the list");
                                                                                continue;
                                                                            }
                                                                            Console.Write("Enter Number of Stars: ");
                                                                            string stars = Console.ReadLine();
                                                                            if (!int.TryParse(stars, out int result))
                                                                            {
                                                                                Console.WriteLine("Please enter a number!");
                                                                                continue;
                                                                            }
                                                                            Console.Write("Enter Comments: ");
                                                                            string comment = Console.ReadLine();
                                                                            if (string.IsNullOrWhiteSpace(comment))
                                                                            {
                                                                                Console.WriteLine("Please leave a comment!");
                                                                                continue;
                                                                            }
                                                                            trackList.Add(hid);
                                                                            g.rateHotel(hid, Convert.ToDouble(stars), comment, hrtList, hotelList.HotelCollection);
                                                                            Console.WriteLine("\nHotel Reviewed Successfully!");
                                                                            continue;
                                                                    }
                                                                }
                                                                continue;
                                                            default:
                                                                Console.WriteLine("Invalid Option!");
                                                                return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }

                                                    
                                                }
                                                continue;
                                            // View Profile
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
                                            // View Balance
                                            case 5:
                                                bool inAccBal = true;
                                                while (inAccBal)
                                                {
                                                    Console.WriteLine("You currently have ${0:#0.00} in your account balance.", g.Balance);
                                                    Console.WriteLine("------------Menu------------");
                                                    Console.WriteLine("1) Top up");
                                                    Console.WriteLine("0) Exit");
                                                    Console.WriteLine();
                                                    Console.Write("Enter choice: ");
                                                    input = Convert.ToInt32(Console.ReadLine());
                                                    switch (input)
                                                    {
                                                        case 1:
                                                            g.topUp();
                                                            continue;
                                                        case 0:
                                                            inAccBal = false;
                                                            break;
                                                    }
                                                }
                                                continue;
                                            // Make Payment
                                            case 6:
                                                bool inMakePayment = true;
                                                while (inMakePayment)
                                                {
                                                    Console.WriteLine("------------Submitted Reservations------------");
                                                    int payable = 0;
                                                    foreach (Reservation r in g.ReservationList)
                                                    {
                                                        if (r.Status == "Submitted")
                                                        {
                                                            payable++;
                                                            if (payable == 1)
                                                            {
                                                                Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-5:#.00}", "ID", "Check-In Date", "Check-Out Date", "Cost");
                                                            }
                                                            Console.WriteLine("{0,-5} {1,-15} {2,-15} ${3,-5:#.00}",r.ReservationId, r.CheckInDate.ToString("dd/MM/yyyy"), r.CheckOutDate.ToString("dd/MM/yyyy"), r.ReservationCost);
                                                            
                                                        }
                                                    }
                                                    if (payable == 0)
                                                    {
                                                        Console.WriteLine("No Reservations needs payment");
                                                    }

                                                    Console.WriteLine("------------Menu------------");
                                                    Console.WriteLine("1) Make Payment");
                                                    Console.WriteLine("0) Exit");
                                                    Console.WriteLine();
                                                    Console.Write("Enter choice: ");
                                                    input = Convert.ToInt32(Console.ReadLine());
                                                    switch (input)
                                                    {
                                                        case 1:
                                                            if (payable == 0)
                                                            {
                                                                Console.WriteLine("No Reservations needs payment.");
                                                                Console.WriteLine();
                                                                continue;
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Enter ID: ");
                                                                string rsid = Console.ReadLine();

                                                                HotelIterator hiter = new HotelIterator(hotelList);
                                                                RoomType roomt;
                                                                bool allowVoucher = false;
                                                                double vDisc = 0;
                                                                // Find RoomType for the reservation
                                                                foreach (RoomTypeReservation rtr in rtrList)
                                                                {
                                                                    if (rtr.Reservation.ReservationId == rsid)
                                                                    {
                                                                        roomt = rtr.RoomType;
                                                                        // Iterator to find which Hotel the RoomType belong to
                                                                        while (hiter.hasNext())
                                                                        {
                                                                            Hotel h = (Hotel)hiter.next();
                                                                            if (h.RoomTypeList.Contains(roomt))
                                                                            {
                                                                                allowVoucher = h.VoucherAllow;
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                continue;
                                                                            }

                                                                        }
                                                                        break;
                                                                    }
                                                                    else
                                                                    {
                                                                        continue;
                                                                    }
                                                                }

                                                                if (allowVoucher)
                                                                {
                                                                    bool inputVoucher = true;
                                                                    while (inputVoucher)
                                                                    {
                                                                        bool valid = false;
                                                                        Console.Write("Enter Voucher Code (Only one can be applied, leave empty if Not Applicable): ");
                                                                        string? vcode = Console.ReadLine();
                                                                        if (vcode == "" || vcode is null)
                                                                        {
                                                                            inputVoucher = false;
                                                                            break;
                                                                        }
                                                                        else
                                                                        {
                                                                            foreach (Vouchers v in vList)
                                                                            {
                                                                                if (v.VoucherId == vcode)
                                                                                {
                                                                                    valid = v.isValid();
                                                                                    if (valid)
                                                                                    {
                                                                                        vDisc = v.DiscountAmt;
                                                                                        Console.WriteLine("Voucher Applied!");
                                                                                        inputVoucher = false;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        Console.WriteLine("Voucher Expired!");
                                                                                        Console.Write("Would you like to enter another voucher? (Yes/No): ");
                                                                                        if (Console.ReadLine() == "No")
                                                                                        {
                                                                                            inputVoucher = false;
                                                                                        }

                                                                                    }
                                                                                    break;
                                                                                }
                                                                            }
                                                                        }
                                                                        
                                                                    }
                                                                    
                                                                }

                                                                foreach (Reservation r in g.ReservationList)
                                                                {
                                                                    if (r.ReservationId == rsid)
                                                                    {
                                                                        g.makePayment(r, vDisc);
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            continue;
                                                        case 0:
                                                            inMakePayment = false;
                                                            continue;
                                                        default:
                                                            Console.WriteLine("Invalid Option!");
                                                            continue;
                                                    }
                                                }
                                                continue;
                                            // Exit
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
                    // Login as Admin
                    case 2:
                        continue;

                    // Exit
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

        public static bool isRoomAvail(List<Reservation> rList, List<RoomTypeReservation> rtrList, RoomType rt, DateTime checkIn, DateTime checkOut, string reservationId)
        {

            foreach (Reservation r in rList)
            {
                foreach (RoomTypeReservation rtr in rtrList)
                {
                    if (rtr.Reservation.ReservationId != reservationId) 
                    {
                        if (rtr.RoomType == rt)
                        {
                            if (checkOut >= rtr.Reservation.CheckInDate && checkOut <= rtr.Reservation.CheckOutDate && (rtr.Reservation.Status == "Submitted" || rtr.Reservation.Status == "Confirmed"))
                            {
                                return false;
                            }
                            // Check if dates before checkout but after checkin
                            else if (checkIn > rtr.Reservation.CheckInDate && checkIn < rtr.Reservation.CheckOutDate && (rtr.Reservation.Status == "Submitted" || rtr.Reservation.Status == "Confirmed"))
                            {
                                return false;
                            }
                            // check if dates inside checkout and checkin
                            else if (checkIn >= rtr.Reservation.CheckInDate && checkOut <= rtr.Reservation.CheckOutDate && (rtr.Reservation.Status == "Submitted" || rtr.Reservation.Status == "Confirmed"))
                            {
                                return false;
                            }
                            //else
                            //{
                            //    return true;
                            //}
                        }
                    }
                }
            }

            return true;
        }
        public static void displayAllRooms(HotelList hotelList)
        {
            Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-5} {4,-16} {5,-15} {6,-10}", "Bed Type", "Max Guest", "Breakfast Served", "Cost Per Night", "Hotel Type", "Location", "Facilities");
            HotelIterator hotelIterator = new HotelIterator(hotelList);
            while (hotelIterator.hasNext())
            {
                StringBuilder sb = new StringBuilder();
                Hotel hotel = (Hotel)hotelIterator.next();
                for (int i = 0; i < hotel.FacilityList.Count; i++)
                {
                    if (i == hotel.FacilityList.Count - 1)
                    {
                        sb.Append(hotel.FacilityList[i]);
                    }
                    else
                    {
                        sb.Append(hotel.FacilityList[i] + ", ");
                    }
                }
                foreach (RoomType rt in hotel.RoomTypeList)
                {
                    Console.WriteLine("{0,-30} {1,-10} {2,-20} ${3,-10:#.00} {4,-20} {5,-15} {6,-10}", rt.BedType, rt.MaxGuest, rt.BreakfastServed, rt.CostPerNight, hotel.Category, hotel.Location, sb);
                }
            }
        }
        public static bool checkHotelExist(HotelList hotelList, string hid)
        {
            bool found = false;
            HotelIterator hotelIterator = new HotelIterator(hotelList);
            while (hotelIterator.hasNext())
            {

                StringBuilder sb = new StringBuilder();
                Hotel hotel = (Hotel)hotelIterator.next();
                if (hid == hotel.HotelID)
                {
                    found = true;
                }
            }
            return found;
        }
    }
}
