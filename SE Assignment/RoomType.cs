﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class RoomType
    {
        private string bedType;
        private string breakfastServed;
        private int maxGuest;
        private double costPerNight;

        public string BedType
        {
            get { return bedType; }
            set { bedType = value; }
        }
        public string BreakfastServed
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

        public RoomType(string bedType, string breakfastServed, int maxGuest, double costNight) 
        {
            BedType = bedType;
            BreakfastServed = breakfastServed;
            MaxGuest = maxGuest;
            CostPerNight = costNight;
        }
    }

}
