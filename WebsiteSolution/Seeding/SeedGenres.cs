
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



    public static class SeedGenres
    {
        public static void SeedAllGenres(AppDbContext db)
        {
            if (db.Genres.Count() == 13)
            {
                NotSupportedException ex = new NotSupportedException("Genre record count at 13!");
                throw ex;
            }
            int intGenresAdded = 0;
            try
            {
                List<Genre> AllGenres = new List<Genre>();

                Genre g1 = new Genre { GenreName = "Drama" };
                AllGenres.Add(g1);
                Genre g2 = new Genre { GenreName = "Children and Family" };
                AllGenres.Add(g2);
                Genre g3 = new Genre { GenreName = "Action" };
                AllGenres.Add(g3);
                Genre g4 = new Genre { GenreName = "Romance" };
                AllGenres.Add(g4);
                Genre g5 = new Genre { GenreName = "Comedy" };
                AllGenres.Add(g5);
                Genre g6 = new Genre { GenreName = "Musical" };
                AllGenres.Add(g6);
                Genre g7 = new Genre { GenreName = "Horror" };
                AllGenres.Add(g7);
                Genre g8 = new Genre { GenreName = "Science Fiction" };
                AllGenres.Add(g8);

                Genre g;
                foreach (Genre genre in AllGenres)
                {
                    g = db.Genres.FirstOrDefault(x => x.GenreName == genre.GenreName);

                    //if genre not found
                    if (g == null)
                    {
                        db.Genres.Add(genre);
                        db.SaveChanges();
                        intGenresAdded += 1;
                    }
                }
            }
            catch
            {
                String msg = "Genres Added: " + intGenresAdded.ToString();
                throw new InvalidOperationException(msg);
            }
        }
    }
}


        