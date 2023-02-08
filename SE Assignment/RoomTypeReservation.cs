using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class RoomTypeReservation
    {
        private Reservation reservation;
        private RoomType roomType;
        private double subTotal;
        public Reservation Reservation
        {
            get { return reservation; }
            set { reservation = value; }
        }
        public RoomType RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public double SubTotal
        {
            get { return (roomType.CostPerNight * (Reservation.CheckOutDate.Day - Reservation.CheckInDate.Day)); }
        }

        public RoomTypeReservation(Reservation r, RoomType rt)
        {
            Reservation = r;
            RoomType = rt;
        }

    }
}
