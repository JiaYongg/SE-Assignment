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
        private int ratingStars;
        private string comments;

        public string RatingId
        {
            get { return ratingId; }
            set { ratingId = value; }
        }

        public int RatingStars
        {
            get { return ratingStars; }
            set { ratingStars = value; }
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public HotelRating() { }

        public HotelRating(string id, int stars, string comment)
        {
            RatingId = id;
            RatingStars = stars;
            Comments = comment;
        }

    }
}