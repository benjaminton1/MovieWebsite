
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Group5_FinalProject_v2.Models
{


    public class ReportSearchViewModel
    {

        [Display(Name = "Search by Name:")]
        public string SearchName { get; set; }


        [Display(Name = "Search by Purchase Date:")]
        public DateTime SearchPurchaseDate { get; set; }


        
    }
}
