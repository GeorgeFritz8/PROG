using System;
using System.Collections.Generic;

namespace Commandline_Project
{
    class Program

    {
        static void Main(string[] args)
        {
            ReviewList database = new ReviewList();

            database.addReview(new Review(5, "Good shit"));
            database.addReview(new Review(1, "Bad shit"));
            database.addReview(new Review(3, "Medium shit"));

            foreach (Review review in database.GetReviews())
            {
                Console.WriteLine("Reviw is:" + " " + review.Stars + "; " + review.Message);
            }
        }
    }
    public class ReviewList
    {
        private List<Review> _ReviewDatabase;

        public ReviewList()
        {
            _ReviewDatabase = new List<Review>();
        }

        public void addReview(Review ReviewToAdd)
        { 
            _ReviewDatabase.Add(ReviewToAdd);
        }
        
        public List<Review> GetReviews()
        {
            return _ReviewDatabase;
        }
    }
}
