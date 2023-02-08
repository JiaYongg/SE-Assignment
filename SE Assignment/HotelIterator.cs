using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class HotelIterator
    {
        private HotelList hotelList;
        private int position = 0;
        //private string hotelID;
        public bool isFound = false;

        public HotelIterator(HotelList list)
        {
            hotelList = list;
                

        }
        public bool hasNext()
        {
            if (position < hotelList.numHotels)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object next()
        {
            ++position;
            if (position < hotelList.numHotels)
            {
                return hotelList.HotelCollection[position];
            }
            else
            {
                return null;
            }


            
        }
        public void remove()
        {
            throw new InvalidOperationException("Remove is not supported by Hotel Iterator");
        }
    }
}
