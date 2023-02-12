using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class HotelRating : ISubject
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
            set { ratingStars = value;}  
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        public List<IObserver> Observers
        {
            get { return observers; }
            set { observers = value; }
        }

        public HotelRating() { }

        public HotelRating(string id, double stars, string comment)
        {
            RatingId = id;
            RatingStars = stars;
            Comments = comment;
            observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("\nHotel and Admin have been notified!");
            foreach (var observer in observers)
            {
                observer.Update(ratingStars);
            }
        }

    }
}