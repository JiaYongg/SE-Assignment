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
        private int reservationCost;
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

        //public int reservationCost // Derivated Attribute
        //{
        //    get { return reservationCost; }
        //    set { reservationCost = value; }
        //}

        public bool IsCancelled
        {
            get { return isCancelled; }
            set { isCancelled = value; }
        }

        public Reservation() { };
        public Reservation(string id, DateTime checkIn, DateTime checkout, int costs, bool iscancelled) 
        {
            reservationId = id;
            checkInDate = checkIn; 
            checkOutDate = checkout;
            reservationCost = costs;
            isCancelled = iscancelled;
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

        public void calculateCost()
        {
            //Implementation
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