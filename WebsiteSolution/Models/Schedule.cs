                                                                                                                                                                                                                                                                 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Group5_FinalProject_v2.Models;
                                                  
namespace Group5_FinalProject_v2.Models
{
    public enum Theater { One, Two }

    public class Schedule          
	{

        [Display(Name = "Schedule ID")]
        public Int32 ScheduleID { get; set; }

        //[Display(Name = "ShowDate")]                      
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        //public DateTime ShowDate { get; set; }

        //[Display(Name = "ShowDate")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        //public DateTime ShowDate { get; set; }

        [Display(Name = "ShowTime")]
        [DataType(DataType.DateTime)]
        public DateTime ShowTime { get; set; }

        [Display(Name = "Theater Number")]
        public Theater Theater { get; set; }

        //[Display(Name = "Start Time")]
        //[DataType(DataType.Time)]
        //public DateTime StartTime { get; set; }

        //[Display(Name = "End Time")]
        //[DataType(DataType.Time)]
        //public DateTime EndTime { get; set; }

        [Display(Name = "Special Event")]
        public bool SpecialEvent { get; set; }


        // Nav Properties
        public Movie Movie { get; set; }

        public Price Price { get; set; }

        public List<PurchaseDetail> PurchaseDetail { get; set; }

        //public Genre Genre { get; set; }

        public Schedule()
        {
            if (PurchaseDetail == null)
            {
                PurchaseDetail = new List<PurchaseDetail>();
            }
        }
    }
}