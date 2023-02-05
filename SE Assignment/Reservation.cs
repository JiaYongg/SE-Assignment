using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class Reservation
    {
        private string reservationId;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private double reservationCost;
        private bool isCancelled;

        public string ReservationId
        {
            get { return reservationId; }
            set { reservationId = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        public double ReservationCost // Derivated Attribute - Might need some changes later
        {
            get { return reservationCost; }
            set { reservationCost = value; }
        }

        public bool IsCancelled
        {
            get { return isCancelled; }
            set { isCancelled = value; }
        }



        public void checkIn()
        {
            CheckInDate = DateTime.Now;
            Console.WriteLine("Check In Date: "+ CheckInDate);
        }

        public void checkOut()
        {
            CheckOutDate = DateTime.Now;
            Console.WriteLine("Check Out Date: " + CheckOutDate);
        }

        public double calculateCost(HotelReservation hr)
        {
            double cost = (CheckOutDate - CheckInDate).TotalDays * hr.RoomCost;
            return cost;
        }

        public bool isRoomAvail()
        {
            //if (isRoomAvail)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return true;
        }
    }
}