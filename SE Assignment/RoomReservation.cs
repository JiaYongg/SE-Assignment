using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class RoomReservation
    {
        private Room room;
        private Reservation reservation;

        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        public Reservation Reservation
        {
            get { return reservation; }
            set { reservation = value; }
        }
    }
}
