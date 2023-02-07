using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class Room
    {
        private int roomNum;
        private string bedType;
        private bool breakfastServed;
        private int maxGuest;
        private double costPerNight;

        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }

        public string BedType
        {
            get { return bedType; }
            set { bedType = value; }
        }
        public bool BreakfastServed
        {
            get { return breakfastServed; }
            set { breakfastServed = value; }
        }
        public int MaxGuest
        {
            get { return maxGuest; }
            set { maxGuest = value; }
        }
        public double CostPerNight
        {
            get { return costPerNight; }
            set { costPerNight = value; }
        }

        public Room(int num, string bedType, bool breakfastServed, int maxGuest, double costNight) 
        {
            RoomNum = num;
            BedType = bedType;
            BreakfastServed = breakfastServed;
            MaxGuest = maxGuest;
            CostPerNight = costNight;
        }
    }

}
