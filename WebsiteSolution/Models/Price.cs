using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Group5_FinalProject_v2.Models
{
	public enum TicketType
	{
		//Matinee,
        //Tuesday,
        //Weekday,
        //Weekends,
        SpecialEvent,
        Matinee,
        DiscountTuesday,
        WeekdayBase,
        Weekends
	}

	public class Price
	{
        [Key]
        public Int32 TicketPriceID { get; set; }

        [Display(Name = "Ticket Type")]
        public TicketType TicketType { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Int32 TicketPrice { get; set; }

        // Nav Properties
        public List<Schedule> Schedule { get; set; }

        public Price()
        {
            Schedule ??= new List<Schedule>();
        }
    }
}
