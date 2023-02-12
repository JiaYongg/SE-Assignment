using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class HotelRating
    {
        private string ratingId;
        private double ratingStars;
        private string comments;
        private List<IObserver> observers = new List<IObserver>();

        public string RatingId
        {
            get { return ratingId; }
            set { ratingId = value; }
        }

        public double RatingStars
        {
            get { return ratingStars; }
            set { ratingStars = value; } //Notify(); 
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public HotelRating() { }

        public HotelRating(string id, double stars, string comment)
        {
            RatingId = id;
            RatingStars = stars;
            Comments = comment;
        }

/*        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(rating);
            }
        }*/

    }
}