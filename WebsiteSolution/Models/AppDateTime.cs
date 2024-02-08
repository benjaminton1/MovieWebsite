using System;
using System.ComponentModel.DataAnnotations;

namespace Group5_FinalProject_v2.Models
{
	public class AppDateTime
	{
        [Display(Name = "Date Time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime DateTime { get; set; }
    }
}

