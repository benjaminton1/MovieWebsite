
using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;
using Group5_FinalProject_v2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Group5_FinalProject_v2.Seeding
{
  

    public static class SeedReviews
    {
        public static void SeedAllReviews(AppDbContext db)
        {
            List<Review> AllReviews = new List<Review>();



            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Michelle Banks"),
                NumRating = 5.0m,
                TextReview = "Best movie I've ever seen.",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
                NumRating = 4.0m,
                TextReview = "Not bad.",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
                NumRating = 5.0m,
                TextReview = "Changed my life",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Franco Broccolo"),
                NumRating = 5.0m,
                TextReview = "Great family adventure movie",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Wendy Chang"),
                NumRating = 4.0m,
                TextReview = "Good movie",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Lim Chou"),
                NumRating = 1.0m,
                TextReview = "Worst thing I've ever seen",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
                NumRating = 5.0m,
                TextReview = "Reminded me of my summers in the NW",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Shan Dixon"),
                NumRating = 5.0m,
                TextReview = "I love a good treasure hunt!",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Jim Bob Evans"),
                NumRating = 3.0m,
                TextReview = "Meh",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
                NumRating = 4.0m,
                TextReview = "",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
                NumRating = 4.0m,
                TextReview = "",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Michelle Banks"),
                NumRating = 5.0m,
                TextReview = "",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Franco Broccolo"),
                NumRating = 5.0m,
                TextReview = "",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Wendy Chang"),
                NumRating = 1.0m,
                TextReview = "Too long",
                ReviewStatus = true,

            }) ;


            AllReviews.Add(new Review
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                User = db.Users.FirstOrDefault(u => u.FullName == "Lim Chou"),
                NumRating = 2.0m,
                TextReview = "Did they really need to drag this out into its own movie?",
                ReviewStatus = true,

            }) ;

            //create a counter and flag to help with debugging
            int intReviewID = 0;
            String strReviewCustomer = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (Review seedReview in AllReviews)
                {
                    //updates the counters to get info on where the problem is
                    intReviewID = seedReview.ReviewID;
                    strReviewCustomer = seedReview.User.FullName;


                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    Review dbReview = db.Reviews.FirstOrDefault(c => (c.User.FullName == seedReview.User.FullName) &&
                                                                                       (c.Movie.Title == seedReview.Movie.Title)
                                                                                  );

                    //if the artistRating isn't in the database, dbArtistRating will be null
                    if (dbReview == null)
                    {
                        //add the ArtistRating to the database
                        db.Reviews.Add(seedReview);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbReview.NumRating = seedReview.NumRating;
                        dbReview.TextReview = seedReview.TextReview;
                        dbReview.ReviewStatus = seedReview.ReviewStatus;



                        //you would add other fields here
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                msg.Append(strReviewCustomer);
                msg.Append(" strReviewCustomer (ReviewRatingID = ");
                msg.Append(intReviewID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }

        }
    }

}
