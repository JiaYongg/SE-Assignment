using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class RoomReservation
    {
        private string reservationID;
        private string roomID;
        private double totalCost;
        public string ReservationID
        {
            get { return reservationID; }
            set { reservationID = value; }
        }
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

    }
}
