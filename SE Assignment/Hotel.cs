using System;
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
        private List<HotelReservation> hrList;
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
        public Hotel(string name, string location, int numstars, bool voucherallow)
        {
            Name = name;
            Location = location;
            NumStars = numstars;
            VoucherAllow = voucherallow;

            hrList = new List<HotelReservation>();
            facilityList = new List<string>();
            categoryList = new List<string>();
        }

        public int calcStars()
        {
            //implementation
            //console.writeline("hi");
        }

        // adds to the parksession list
        public void addHotelReservation(HotelReservation hr)
        {
            if (!hotelReservationList.Contains(hr))
            {
                hotelReservationList.Add(hr);
            }
            else
            {
                Console.WriteLine("This reservation already exists!");
            }
        }
    }
}