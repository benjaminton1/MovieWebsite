using Group5_FinalProject_v2.DAL;
using System;
using System.Linq;


namespace Group5_FinalProject_v2.Utilities
{
    public static class GenerateNextMovieID
    {
        public static Int32 GetNextMovieID(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 3001;

            Int32 intMaxMovieID; //the current maximum course number
            Int32 intNextMovieID; //the course number for the next class

            if (_context.Movies.Count() == 0) //there are no registrations in the database yet
            {
                intMaxMovieID = START_NUMBER; //registration numbers start at 101
            }
            else
            {
                intMaxMovieID = _context.Movies.Max(c => c.MovieID); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxMovieID < START_NUMBER)
            {
                intMaxMovieID = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextMovieID = intMaxMovieID + 1;

            //return the value
            return intNextMovieID;
        }

    }
}