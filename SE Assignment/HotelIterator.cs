using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class HotelIterator
    {
        private List<Hotel> hotels;
        private int position = 0;

        public HotelIterator(List<Hotel> hotels)
        {
            this.hotels = hotels;
        }
        public bool hasNext()
        {
            if (position < hotels.Count)
            {
                return true;
            }
            return false;
        }
        public object next()
        {
            Hotel hotel = hotels[position];
            position++;
            while (position < hotels.Count)
            {
                position++;
            }
            return hotel;
        }
        public void remove()
        {
            throw new InvalidOperationException("Remove is not supported by Hotel Iterator");
        }
    }
}
