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
        private string hotelID;
        private string name;
        private string location;
        private string category;
        private List<string> facilityList;
        private List<RoomType> roomTypeList;
        private double numStars;
        private bool voucherAllow;

        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }
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
        public double NumStars
        {
            get { return numStars; }
            set { numStars = value; }
        }
        public bool VoucherAllow
        {
            get { return voucherAllow; }
            set { voucherAllow = value; }
        }
        public List<string> FacilityList
        {
            get { return facilityList; }
            set { facilityList = value; }
        }
        public List<RoomType> RoomTypeList
        {
            get { return roomTypeList; }
            set { roomTypeList = value; }
        }
        public Hotel(string name, string location, string category, double numstars, bool voucherallow, List<string> fList, List<RoomType> rtlist)
        {
            Name = name;
            Location = location;
            Category = category;
            NumStars = numstars;
            VoucherAllow = voucherallow;

            facilityList = fList;
            roomTypeList = rtlist;
        }

        public void calcStars(double totalStars, double count)
        {
            numStars = totalStars / count;
        }

        // adds to the parksession list
        public void addHotelReservation(RoomType rt)
        {
            if (!roomTypeList.Contains(rt))
            {
                roomTypeList.Add(rt);
            }
            else
            {
                Console.WriteLine("This reservation already exists!");
            }
        }
    }
}