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
        public int numStars
        {
            get { return numStars; }
            set { numStars = value; }
        }
        public bool voucherAllow
        {
            get { return voucherAllow; }
            set { voucherAllow = value; }
        }
        public Hotel(string name, string location, int numstars, bool voucherAllow)
        {
            Name = name;
            Location = location;
            NumStars = numStars;
            VoucherAllow = voucherAllow;

            hotelReservationList = new List<HotelReservation>();
            facilityList = new List<string>();
            categoryList = new List<string>();
        }

        public int calcStars()
        {
            console.writeline("hi");
        } 
    }
}