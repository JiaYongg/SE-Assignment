using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class Hotel
    {
        private string name;
        private string location;
        private string category;
        private List<string> facilityList;
        private List<Room> roomList;
        private int numStars;
        private bool voucherAllow;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int NumStars
        {
            get { return numStars; }
            set { numStars = value; }
        }
        public bool VoucherAllow
        {
            get { return voucherAllow; }
            set { voucherAllow = value; }
        }
        public Hotel(string name, string location, string category, int numstars, bool voucherallow, List<string> fList, List<Room> rlist)
        {
            Name = name;
            Location = location;
            Category = category;
            NumStars = numstars;
            VoucherAllow = voucherallow;

            facilityList = fList;
            roomList = rlist;
        }

        public int calcStars()
        {
            return 0;
        }

        // adds to the parksession list
        public void addHotelReservation(Room rm)
        {
            if (!roomList.Contains(rm))
            {
                roomList.Add(rm);
            }
            else
            {
                Console.WriteLine("This reservation already exists!");
            }
        }
    }
}