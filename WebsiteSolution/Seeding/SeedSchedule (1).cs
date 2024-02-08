
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
  


   public static class SeedSchedule
   {
       public static void SeedAllSchedule(AppDbContext db)
       {
           List<Schedule> AllSchedule = new List<Schedule>();






            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 23, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	            SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 23, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	            SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 11, 23, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	            SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 23, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	            SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 23, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 23, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 23, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 23, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 23, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 23, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 23, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 11, 23, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 11, 23, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 24, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 24, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 11, 24, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 24, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 24, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 24, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 24, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 24, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 24, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 24, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 24, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 11, 24, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 11, 24, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 11, 25, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 11, 25, 12, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: An Unexpected Journey"),
                ShowTime = new DateTime(2023, 11, 25, 15, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Desolation of Smaug"),
                ShowTime = new DateTime(2023, 11, 25, 18, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                ShowTime = new DateTime(2023, 11, 25, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.SpecialEvent),
	              SpecialEvent = true,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 25, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 25, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: The Fellowship of the Ring"),
                ShowTime = new DateTime(2023, 11, 25, 13, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: Two Towers"),
                ShowTime = new DateTime(2023, 11, 25, 16, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: The Return of the King"),
                ShowTime = new DateTime(2023, 11, 25, 19, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.SpecialEvent),
	              SpecialEvent = true,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 11, 26, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 11, 26, 12, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: An Unexpected Journey"),
                ShowTime = new DateTime(2023, 11, 26, 15, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Desolation of Smaug"),
                ShowTime = new DateTime(2023, 11, 26, 18, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                ShowTime = new DateTime(2023, 11, 26, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.SpecialEvent),
	              SpecialEvent = true,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 26, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 26, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: The Fellowship of the Ring"),
                ShowTime = new DateTime(2023, 11, 26, 13, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: Two Towers"),
                ShowTime = new DateTime(2023, 11, 26, 16, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: The Return of the King"),
                ShowTime = new DateTime(2023, 11, 26, 19, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.SpecialEvent),
	              SpecialEvent = true,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 27, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 27, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 11, 27, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 27, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 27, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 27, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 27, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 27, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 27, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 27, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 27, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 11, 27, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 11, 27, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 28, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 28, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 11, 28, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.DiscountTuesday),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 28, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.DiscountTuesday),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 28, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 28, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 28, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 28, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 28, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.DiscountTuesday),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 28, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.DiscountTuesday),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 28, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 11, 28, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 11, 28, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 29, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 29, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 11, 29, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 29, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 29, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 29, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 29, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 29, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 29, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 29, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 29, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 11, 29, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 11, 29, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 30, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 30, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 11, 30, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 30, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 30, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 30, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 11, 30, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 11, 30, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 11, 30, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 11, 30, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 11, 30, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 11, 30, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 11, 30, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 1, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 1, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 12, 1, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 1, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 1, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 1, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.SpecialEvent),
	              SpecialEvent = true,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 1, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 1, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 1, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 1, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 1, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 12, 1, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.SpecialEvent),
	              SpecialEvent = true,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 12, 1, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 12, 2, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 12, 2, 12, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: An Unexpected Journey"),
                ShowTime = new DateTime(2023, 12, 2, 15, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Desolation of Smaug"),
                ShowTime = new DateTime(2023, 12, 2, 18, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                ShowTime = new DateTime(2023, 12, 2, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 2, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 2, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: The Fellowship of the Ring"),
                ShowTime = new DateTime(2023, 12, 2, 13, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: Two Towers"),
                ShowTime = new DateTime(2023, 12, 2, 16, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: The Return of the King"),
                ShowTime = new DateTime(2023, 12, 2, 19, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 12, 3, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 12, 3, 12, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: An Unexpected Journey"),
                ShowTime = new DateTime(2023, 12, 3, 15, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Desolation of Smaug"),
                ShowTime = new DateTime(2023, 12, 3, 18, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Hobbit: The Battle of Five Armies"),
                ShowTime = new DateTime(2023, 12, 3, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.SpecialEvent),
	              SpecialEvent = true,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 3, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 3, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: The Fellowship of the Ring"),
                ShowTime = new DateTime(2023, 12, 3, 13, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: Two Towers"),
                ShowTime = new DateTime(2023, 12, 3, 16, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Weekends),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Lord of the Rings: The Return of the King"),
                ShowTime = new DateTime(2023, 12, 3, 19, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.SpecialEvent),
	              SpecialEvent = true,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 4, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 4, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 12, 4, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 4, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 4, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 4, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 4, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 4, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 4, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 4, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 4, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 12, 4, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 12, 4, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 5, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 5, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 12, 5, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.DiscountTuesday),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 5, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.DiscountTuesday),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 5, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 5, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 5, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 5, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 5, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.DiscountTuesday),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 5, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.DiscountTuesday),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 5, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 12, 5, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 12, 5, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 6, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 6, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic"),
                ShowTime = new DateTime(2023, 12, 6, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 6, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 6, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 6, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 6, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 6, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 6, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 6, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 6, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 12, 6, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 12, 6, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 7, 9, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 7, 11, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Titanic: Jack's Revenge"),
                ShowTime = new DateTime(2023, 12, 7, 13, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 7, 16, 30, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 7, 19, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 7, 21, 0, 0),
                Theater = Theater.One,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story 7"),
                ShowTime = new DateTime(2023, 12, 7, 9, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Jurassic Park"),
                ShowTime = new DateTime(2023, 12, 7, 11, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.Matinee),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Secret Life of Walter Mitty"),
                ShowTime = new DateTime(2023, 12, 7, 13, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Fast and Furious 18: Anger Management"),
                ShowTime = new DateTime(2023, 12, 7, 15, 30, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Goonies"),
                ShowTime = new DateTime(2023, 12, 7, 18, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "The Sandlot"),
                ShowTime = new DateTime(2023, 12, 7, 20, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;



            AllSchedule.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.Title == "Rocky Horror Picture Show"),
                ShowTime = new DateTime(2023, 12, 7, 22, 0, 0),
                Theater = Theater.Two,
                Price = db.Prices.FirstOrDefault(c => c.TicketType == TicketType.WeekdayBase),
	              SpecialEvent = false,


            }) ;

            //create a counter and flag to help with debugging
            int intSchedulesID = 0;
            String strSchedulesCustomer = "Start";


            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (Schedule seedSchedules in AllSchedule)
                {
                    //updates the counters to get info on where the problem is
                    intSchedulesID = seedSchedules.ScheduleID;
                    strSchedulesCustomer = seedSchedules.Movie.Title;




                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it
                    Schedule dbSchedules = db.Schedules.FirstOrDefault(c => (c.ScheduleID == seedSchedules.ScheduleID) &&
                                                                                       (c.Movie.Title == seedSchedules.Movie.Title)
                                                                                  );


                    //if the artistRating isn't in the database, dbArtistRating will be null
                    if (dbSchedules == null)
                    {
                        //add the ArtistRating to the database
                        db.Schedules.Add(seedSchedules);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbSchedules.ShowTime = seedSchedules.ShowTime;
                        dbSchedules.Theater = seedSchedules.Theater;
                        dbSchedules.SpecialEvent = seedSchedules.SpecialEvent;






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
                msg.Append(strSchedulesCustomer);
                msg.Append(" strSchedulesCustomer (SchedulesRatingID = ");
                msg.Append(intSchedulesID);
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
