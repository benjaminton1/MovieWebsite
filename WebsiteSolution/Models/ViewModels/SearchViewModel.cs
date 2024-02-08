
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Group5_FinalProject_v2.Models
{

    public enum SearchType { GreaterThan, LessThan }

    public class SearchViewModel
    {

        [Display(Name = "Search by Title:")]
        public string SearchTitle { get; set; }

        [Display(Name = "Search by Tag Line:")]
        public string SearchTagLine { get; set; }

        [Display(Name = "Search by Genre")]
        public Int32 SelectedGenre { get; set; }

        [Display(Name = "Search by Release Year:")]
        public string SearchReleaseYear { get; set; }

        [Display(Name = "Search by MPAA Rating:")]
        public string SearchMPAARating { get; set; }

        [Display(Name = "Search Type:")]
        public SearchType SearchType { get; set; }

        [Display(Name = "Search by Actor:")]
        public string SearchActor { get; set; }

        [Display(Name = "Search by Show Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedDateTime { get; set; }

        [Display(Name = "Search by Customer Rating:")]
        public Int32 SearchCustomerRating { get; set; }

    }
}
