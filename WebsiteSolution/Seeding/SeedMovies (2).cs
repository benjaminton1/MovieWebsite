
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
  

    public static class SeedMovies
    {
        public static void SeedAllMovies(AppDbContext db)
        {
            List<Movie> AllMovies = new List<Movie>();




            AllMovies.Add(new Movie
            {
                //MovieID = 3001,
                Title = "Jurassic Park",
                ReleaseYear = 1993,
                Description = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                RunTime = 90,
                MPAARating = "PG-13",
                Tagline = "Welcome to Jurassic Park",
                Actors = "Sam Neill, Laura Dern, Jeff Goldblum",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Drama"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3002,
                Title = "Toy Story 7",
                ReleaseYear = 2023,
                Description = "Woody and Buzz team up once again to lead the resistance in the Toy Revolt.",
                RunTime = 90,
                MPAARating = "G",
                Tagline = "Play, pretend, and protect",
                Actors = "Tom Hanks, Tim Allen",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Children and Family"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3003,
                Title = "Fast and Furious 18: Anger Management",
                ReleaseYear = 2023,
                Description = "They may be riding mechanical scooters, but they are as furious as ever as they attend court-ordered therapy.",
                RunTime = 120,
                MPAARating = "R",
                Tagline = "I drink your milkshake",
                Actors = "The Rock, Vin Diesel",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Action"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3004,
                Title = "Titanic",
                ReleaseYear = 1999,
                Description = "An epic, action-packed romance set against the ill-fated maiden voyage of the R.M.S. Titanic.",
                RunTime = 150,
                MPAARating = "PG-13",
                Tagline = "Nothing On Earth Could Come Between Them. Collide With Destiny.",
                Actors = "Leonardo DiCaprio, Kate Winslet",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Romance"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3005,
                Title = "The Secret Life of Walter Mitty",
                ReleaseYear = 2013,
                Description = "When both he and a colleague are about to lose their job, Walter takes action by embarking on an adventure more extraordinary than anything he ever imagined.",
                RunTime = 120,
                MPAARating = "PG",
                Tagline = "Stop dreaming. Start Living.",
                Actors = "Ben Stiller",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Comedy"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3006,
                Title = "The Goonies",
                ReleaseYear = 1985,
                Description = "A group of young misfits called The Goonies discover an ancient map and set out on an adventure to find a legendary pirate's long-lost treasure.",
                RunTime = 90,
                MPAARating = "PG",
                Tagline = "The treacherous traps. The hidden treasure. And Sloth... Join the adventure.",
                Actors = "Sean Astin, Josh Brolin, Corey Feldman",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Children and Family"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3007,
                Title = "The Sandlot",
                ReleaseYear = 1993,
                Description = "When Scottie Smalls moves to a new neighborhood, he manages to make friends with a group of kids who play baseball at the sandlot.",
                RunTime = 90,
                MPAARating = "PG",
                Tagline = "The adventure of a lifetime, the summer of their dreams...the dog of their nightmares.",
                Actors = "Mike Vitar, Patrick Renna, James Earl Jones",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Children and Family"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3008,
                Title = "Rocky Horror Picture Show",
                ReleaseYear = 1975,
                Description = "A newly-engaged couple have a breakdown in an isolated area and must seek shelter at the bizarre residence of Dr. Frank-n-Furter",
                RunTime = 90,
                MPAARating = "R",
                Tagline = "Don't Dream it, Be It!",
                Actors = "Tim Curry, Susan Sarandon",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Musical"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3009,
                Title = "Titanic: Jack's Revenge",
                ReleaseYear = 2023,
                Description = "Emerging from the deep with revenge on his mind, Jack Dawson will stop at nothing to find Rose.",
                RunTime = 150,
                MPAARating = "R",
                Tagline = "She let me go, now I'll never let her forget it.",
                Actors = "Leonardo DiCaprio, Kate Winslet",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Horror"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3010,
                Title = "The Hobbit: An Unexpected Journey",
                ReleaseYear = 2012,
                Description = "An Unexpected Journey tells the tale of Bilbo Baggins, who is convinced by the wizard Gandalf to accompany thirteen Dwarves, led by Thorin Oakenshield, on a quest to reclaim the Lonely Mountain from the dragon Smaug.",
                RunTime = 150,
                MPAARating = "PG-13",
                Tagline = "From the smallest beginnings come the greatest legends. One journey started it all.",
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Science Fiction"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3011,
                Title = "The Hobbit: The Battle of Five Armies",
                ReleaseYear = 2014,
                Description = "Bilbo and company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness.",
                RunTime = 150,
                MPAARating = "PG-13",
                Tagline = "The defining chapter.",
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Science Fiction"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3012,
                Title = "The Hobbit: The Desolation of Smaug",
                ReleaseYear = 2013,
                Description = "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug.",
                RunTime = 150,
                MPAARating = "PG-13",
                Tagline = "It's a really big dragon",
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Science Fiction"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3013,
                Title = "Lord of the Rings: The Fellowship of the Ring",
                ReleaseYear = 2001,
                Description = "The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins, who inherits the Ring and steps into legend.",
                RunTime = 150,
                MPAARating = "PG-13",
                Tagline = "One Ring To Rule Them All. Fate Has Chosen Him. A Fellowship Will Protect Him. Evil Will Hunt Them.",
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Science Fiction"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3014,
                Title = "Lord of the Rings: Two Towers",
                ReleaseYear = 2002,
                Description = "Frodo and Sam discover they are being followed by the mysterious Gollum.",
                RunTime = 150,
                MPAARating = "PG-13",
                Tagline = "A New Power Is Rising. The Battle for Middle-earth Begins!",
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Science Fiction"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3015,
                Title = "Lord of the Rings: The Return of the King",
                ReleaseYear = 2003,
                Description = "Continuing the plot of the previous film, Frodo, Sam and Gollum are making their final way toward Mount Doom to destroy the One Ring, unaware of Gollum's true intentions, while Merry, Pippin, Gandalf, Aragorn, Legolas, Gimli and the others join forces together against Sauron and his legions in Minas Tirith.",
                RunTime = 180,
                MPAARating = "PG-13",
                Tagline = "No victory without suffering. No freedom without sacrifice.",
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Science Fiction"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3016,
                Title = "Barbie",
                ReleaseYear = 2023,
                Description = "Stereotypical Barbie experiences a full on existential crisis and embarks on a journey of self discovery. Along for the ride is her beau Ken.",
                RunTime = 120,
                MPAARating = "PG-13",
                Tagline = "She can do everything. He's just Ken.",
                Actors = "Ryan Gosling, Margot Robbie",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Comedy"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3017,
                Title = "Spider-Man: Into the Spider-Verse",
                ReleaseYear = 2018,
                Description = "Teen Miles Morales becomes the Spider-Man of his universe and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.",
                RunTime = 120,
                MPAARating = "PG",
                Tagline = "Enter a universe where more than one wears the mask.",
                Actors = "Shameik Moore, Jake Johnson, Hailee Steinfeld, Stan Lee, Oscar Isaac, Nicolas Cage, Mahershala Ali",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Action"),


            }) ;



            AllMovies.Add(new Movie
            {
                //MovieID = 3018,
                Title = "Spider-Man: Across the Spider-Verse",
                ReleaseYear = 2023,
                Description = "Miles Morales catapults across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence.",
                RunTime = 150,
                MPAARating = "PG",
                Tagline = "With great power comes great responsibility.",
                Actors = "Shameik Moore, Hailee Steinfeld, Oscar Isaac, Karan Soni, Andy Samberg, Daniel Kaluuya",
                Genres = db.Genres.FirstOrDefault(a => a.GenreName == "Action"),


            }) ;

            //create a counter and flag to help with debugging
            int intMovieID = 0;
            String strMovieName = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artists
                foreach (Movie seedMovies in AllMovies)
                {
                    //updates the counters to get info on where the problem is
                    intMovieID = seedMovies.MovieID;
                    strMovieName = seedMovies.Title;

                    //try to find the artist in the database
                    Movie dbMovie = db.Movies.FirstOrDefault(c => c.Title == seedMovies.Title);

                    //if the artist isn't in the database, dbArtist will be null
                    if (dbMovie == null)
                    {
                        //add the Artist to the database
                        db.Movies.Add(seedMovies);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artist because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbMovie.Title = seedMovies.Title;
                        dbMovie.ReleaseYear = seedMovies.ReleaseYear;
                        dbMovie.Description = seedMovies.Description;
                        dbMovie.RunTime = seedMovies.RunTime;
                        dbMovie.MPAARating = seedMovies.MPAARating;
                        dbMovie.Tagline = seedMovies.Tagline;
                        dbMovie.Actors = seedMovies.Actors;
                        dbMovie.Genres = seedMovies.Genres;


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
                msg.Append(strMovieName);
                msg.Append(" movie (MovieID = ");
                msg.Append(intMovieID);
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
