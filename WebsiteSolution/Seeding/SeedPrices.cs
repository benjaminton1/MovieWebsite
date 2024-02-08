
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
  


   public static class SeedPrices
   {
       public static void SeedAllPrices(AppDbContext db)
       {
           List<Price> AllPrices = new List<Price>();





           AllPrices.Add(new Price
           {
               TicketType = TicketType.SpecialEvent,
               TicketPrice = 15


           }) ;



           AllPrices.Add(new Price
           {
               TicketType = TicketType.Matinee,
               TicketPrice = 5


           }) ;



           AllPrices.Add(new Price
           {
               TicketType = TicketType.DiscountTuesday,
               TicketPrice = 8


           }) ;



           AllPrices.Add(new Price
           {
               TicketType = TicketType.WeekdayBase,
               TicketPrice = 10


           }) ;



           AllPrices.Add(new Price
           {
               TicketType = TicketType.Weekends,
               TicketPrice = 12


           }) ;

           //create a counter and flag to help with debugging
           int intPriceID = 0;
           int intPrice = 0;


           //we are now going to add the data to the database
           //this could cause errors, so we need to put this code
           //into a Try/Catch block
           try
           {
               //loop through each of the artists
               foreach (Price seedPrices in AllPrices)
               {
                   //updates the counters to get info on where the problem is
                   intPriceID = seedPrices.TicketPriceID;
                   intPrice = seedPrices.TicketPrice;


                   //try to find the artist in the database
                   Price dbPrice = db.Prices.FirstOrDefault(c => c.TicketType == seedPrices.TicketType);


                   //if the artist isn't in the database, dbArtist will be null
                   if (dbPrice == null)
                   {
                       //add the Artist to the database
                       db.Prices.Add(seedPrices);
                       db.SaveChanges();
                   }
                   else //the record is in the database
                   {
                       //update all the fields
                       //this isn't really needed for artist because it only has one field
                       //but you will need it to re-set seeded data with more fields
                       dbPrice.TicketType = seedPrices.TicketType;
                       dbPrice.TicketPrice = seedPrices.TicketPrice;


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
               msg.Append(intPrice);
               msg.Append(" price (PriceID = ");
               msg.Append(intPriceID);
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
