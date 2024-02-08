using System.ComponentModel.DataAnnotations;


namespace Group5_FinalProject_v2.Models
{
	public class Genre
	{
		
        [Display(Name = "Genre ID")]
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre Name")]
        public String GenreName { get; set; }


        // Nav Properies
        public List<Movie> Movie { get; set; }

        public Genre()
        {
            Movie ??= new List<Movie>();
        }
	}
}

