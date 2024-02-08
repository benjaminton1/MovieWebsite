using System;
using Microsoft.EntityFrameworkCore;

//TODO: Update this using statement to include your project name
using Group5_FinalProject_v2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//TODO: Make this namespace match your project name
namespace Group5_FinalProject_v2.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
        }

        //TODO: Add Dbsets here.  Products is included as an example.  
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

    }

}
