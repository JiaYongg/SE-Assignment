using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class HotelList : IHotelList
    {
        private string hotelID;
        private List<Hotel> hotelCollection;
        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }
        public List<Hotel> HotelCollection
        {
            get { return hotelCollection; }
            set { hotelCollection = value; }
        }
        public int numHotels
        {
            get { return hotelCollection.Count;}
        }
        public HotelList()
        {
            HotelCollection = new List<Hotel>();
        }
        public HotelIterator CreateIterator()
        {
            return new HotelIterator(this);
        }
    }
}
