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
        private bool hasBreakfast;
        private string bedType;
        private int roomCost;

        private Hotel hotel;
        private Reservation reservation;

        public string RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }
        public bool RoomAvailable
        {
            get { return roomAvailable; }
            set { roomAvailable = value; }
        }
        public int MaxGuest
        {
            get { return maxGuest; }
            set { maxGuest = value; }
        }
        public bool HasBreakfast
        {
            get { return hasBreakfast; }
            set { hasBreakfast = value; }
        }
        public string BedType
        {
            get { return bedType; }
            set { bedType = value; }
        }
        public int RoomCost
        {
            get { return roomCost; }
            set { roomCost = value; }
        }
        public Hotel Hotel
        {
            get { return hotel; }
            set { hotel = value; }
        }
        public Reservation Reservation
        {
            get { return reservation; }
            set { reservation = value; }
        }
        public HotelReservation(string roomNum, bool roomAvailable, int maxGuest, bool hasBreakfast, string bedType, int roomCost)
        {
            RoomNum = roomNum;
            RoomAvailable = roomAvailable;
            MaxGuest = maxGuest;
            HasBreakfast = hasBreakfast;
            BedType = bedType;
            RoomCost = roomCost;

            //Hotel.addHotelReservation(this);
            //Reservation.addHotelReservation(this);
        }
    }
}