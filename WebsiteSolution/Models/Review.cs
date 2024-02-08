using System;
using System.ComponentModel.DataAnnotations;

namespace Group5_FinalProject_v2.Models
{
	public class Review

    {
        public Int32 ReviewID { get; set; }

        [StringLength(280)]
        [Required(ErrorMessage = "Review is a required field.")]
        [Display(Name = "Review")]
        public String TextReview { get; set; }

        [Required(ErrorMessage = "Rating is a required field.")]
        [DisplayFormat(DataFormatString = "{0:n1}")]
        [Display(Name = "Number Rating")]
        [Range(1, 5, ErrorMessage = "Rate the movie on a scale from 1 to 5!")]
        public Decimal NumRating { get; set; }

        [Display(Name = "Approval Status")]
        public Boolean ReviewStatus { get; set; }


        // Nav Properties
        public AppUser User { get; set; }

        public Movie Movie { get; set; }

    }

}