using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class HotelReservation
    {
        private string roomNum;
        private bool roomAvailable;
        private int maxGuest;
        private bool hasBrakfast;
        private string bedType;
        private int roomCost;

        private Hotel hotel;
        private Reservation reservation;

        public string roomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }
        public bool roomAvailable
        {
            get { return roomAvailable; }
            set { roomAvailable = value; }
        }
        public int maxGuest
        {
            get { return maxGuest; }
            set { maxGuest = value; }
        }
        public bool hasBreakfast
        {
            get { return hasBreakfast; }
            set { hasBreakfast = value; }
        }
        public string bedType
        {
            get { return bedType; }
            set { bedType = value; }
        }
        public int roomCost
        {
            get { return roomCost; }
            set { roomCost = value; }
        }
    }
}