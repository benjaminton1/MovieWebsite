
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
  


    public static class SeedPurchases
    {
        public static void SeedAllPurchases(AppDbContext db)
        {
            List<Purchase> AllPurchases = new List<Purchase>();





            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Michelle Banks"),
               //Total = 54.375m,
               //Tax = 4.375m,
               //Subtotal = 50m,
               NumberOfTickets = 10,
               //TotalPopcornPoints = 50,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 5, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
               //Total = 126.15m,
               //Tax = 10.15m,
               //Subtotal = 116m,
               NumberOfTickets = 10,
               //TotalPopcornPoints = 116,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 10.875m,
               //Tax = 0.875m,
               //Subtotal = 10m,
               NumberOfTickets = 2,
               //TotalPopcornPoints = 10,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 14, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Michelle Banks"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 5, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Franco Broccolo"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Wendy Chang"),
               //Total = 10.875m,
               //Tax = 0.875m,
               //Subtotal = 10m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 10,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 14, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Lim Chou"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 5, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Shan Dixon"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Jim Bob Evans"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 14, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Lou Ann Feeley"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 5, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Victoria Lawrence"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Erik Lineback"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = false

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 14, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Ernest Lowe"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 20, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Michelle Banks"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Michelle Banks"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Franco Broccolo"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Wendy Chang"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Lim Chou"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Shan Dixon"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = false

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Jim Bob Evans"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Lou Ann Feeley"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Victoria Lawrence"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Erik Lineback"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = false

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Ernest Lowe"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
               //Total = 16.3125m,
               //Tax = 1.3125m,
               //Subtotal = 15m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 15,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
               //Total = 32.625m,
               //Tax = 2.625m,
               //Subtotal = 30m,
               NumberOfTickets = 2,
               //TotalPopcornPoints = 30,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 97.875m,
               //Tax = 7.875m,
               //Subtotal = 90m,
               NumberOfTickets = 6,
               //TotalPopcornPoints = 90,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Michelle Banks"),
               //Total = 32.625m,
               //Tax = 2.625m,
               //Subtotal = 30m,
               NumberOfTickets = 2,
               //TotalPopcornPoints = 30,
               Recipient = null,
               PurchaseStatus = false

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Jim Bob Evans"),
               //Total = 32.625m,
               //Tax = 2.625m,
               //Subtotal = 30m,
               NumberOfTickets = 2,
               //TotalPopcornPoints = 30,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Lou Ann Feeley"),
               //Total = 65.25m,
               //Tax = 5.25m,
               //Subtotal = 60m,
               NumberOfTickets = 4,
               //TotalPopcornPoints = 60,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 39.15m,
               //Tax = 3.15m,
               //Subtotal = 36m,
               NumberOfTickets = 3,
               //TotalPopcornPoints = 36,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Victoria Lawrence"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Franco Broccolo"),
               //Total = 26.1m,
               //Tax = 2.1m,
               //Subtotal = 24m,
               NumberOfTickets = 2,
               //TotalPopcornPoints = 24,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Wendy Chang"),
               //Total = 21.75m,
               //Tax = 1.75m,
               //Subtotal = 20m,
               NumberOfTickets = 2,
               //TotalPopcornPoints = 20,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 1, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Christopher Baker"),
               //Total = 10.875m,
               //Tax = 0.875m,
               //Subtotal = 10m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 10,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 15, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Lim Chou"),
               //Total = 13.05m,
               //Tax = 1.05m,
               //Subtotal = 12m,
               NumberOfTickets = 1,
               //TotalPopcornPoints = 12,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 24, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Jim Bob Evans"),
               //Total = 48.9375m,
               //Tax = 3.9375m,
               //Subtotal = 45m,
               NumberOfTickets = 9,
               //TotalPopcornPoints = 45,
               Recipient = null,
               PurchaseStatus = false

           }) ;
          


            AllPurchases.Add(new Purchase
           {

               PurchaseDate = new DateTime(2023, 11, 26, 0, 0, 0),
               User = db.Users.FirstOrDefault(u => u.FullName == "Brad White"),
               //Total = 0.0m,
               //Tax = 0.0m,
               //Subtotal = 0m,
               NumberOfTickets = 2,
               //TotalPopcornPoints = -200,
               Recipient = null,
               PurchaseStatus = true

           }) ;
          
            //create a counter and flag to help with debugging
            int intPurchaseID = 0;
            String strPurchaseCustomer = "Start";


            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (Purchase seedPurchase in AllPurchases)
                {
                    //updates the counters to get info on where the problem is
                    intPurchaseID = seedPurchase.PurchaseID;




                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    Purchase dbPurchase = db.Purchases.FirstOrDefault(c => (c.PurchaseID == seedPurchase.PurchaseID)
                                                                                  );


                    //if the artistRating isn't in the database, dbArtistRating will be null
                    if (dbPurchase == null)
                    {
                        //add the ArtistRating to the database
                        db.Purchases.Add(seedPurchase);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbPurchase.PurchaseDate = seedPurchase.PurchaseDate;
                       dbPurchase.Total = seedPurchase.Total;
                       dbPurchase.Tax = seedPurchase.Tax;
dbPurchase.Subtotal = seedPurchase.Subtotal;
dbPurchase.NumberOfTickets = seedPurchase.NumberOfTickets;
                       dbPurchase.TotalPopcornPoints = seedPurchase.TotalPopcornPoints;






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
                msg.Append(strPurchaseCustomer);
                msg.Append(" strPurchaseCustomer (PurchaseID = ");
                msg.Append(intPurchaseID);
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
