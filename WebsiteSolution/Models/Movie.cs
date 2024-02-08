using System.ComponentModel.DataAnnotations;

namespace Group5_FinalProject_v2.Models
{
    public class Movie
    {
        //there are more properties here, like rating, tagline, actors, etc. 

        public Int32 MovieID { get; set; }

        [Required(ErrorMessage = "Movie Title is a required field.")]
        [Display(Name = "Movie Title")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Release Date is a required field.")]
        [Display(Name = "Release Date")]
        public Int32 ReleaseYear { get; set; }

        [Required(ErrorMessage = "Description is a required field.")]
        [Display(Name = "Description")]
        public String Description { get; set; }

        [Required(ErrorMessage = "Runtime is a required field.")]
        [Display(Name = "Runtime")]
        public Decimal RunTime { get; set; }

        [Required(ErrorMessage = "MPAA Rating is a required field.")]
        [Display(Name = "MPAA Rating")]
        public String MPAARating { get; set; }

        //[Display(Name = "Customer Rating:")]
        //public String CustomerRating { get; set; }

        [Display(Name = "Tagline")]
        public String Tagline { get; set; }

        [Required(ErrorMessage = "You are required to include at least one actor.")]
        [Display(Name = "Actors")]
        public String Actors { get; set; }

        // Customer Rating Average
        [DisplayFormat(DataFormatString = "{0:0.#}")]
        public Decimal AverageRating
        {
            get
            {
                if (Review.Count() == 0)
                    return 0;
                else
                    return Review.Average(mr => mr.NumRating);
            }
        }


        // Nav Properties
        public Genre Genres { get; set; }

        public List<Review> Review { get; set; }

        public List<Schedule> Schedule { get; set; }

        public Movie()
        {
            Review ??= new List<Review>();
            Schedule ??= new List<Schedule>();
        }

        
    }
}
