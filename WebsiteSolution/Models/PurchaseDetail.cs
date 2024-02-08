using System;
using System.ComponentModel.DataAnnotations;

namespace Group5_FinalProject_v2.Models
{
    public enum PurchaseStatus
    {
        Complete,
        Pending,
        Cancelled
    }
    public enum DiscountType
    {
        [Display(Name = "Senior Discount")] SeniorDiscount,
        [Display(Name = "Matinee Discount")] MatineeDiscount,
        [Display(Name = "Discount Tuesday")] DiscountTuesday,
    }

    public enum PaymentMethod
    {
        [Display(Name = "Cash/Card")] CashCard,
        [Display(Name = "Points")] Points

    }
    public enum PurchaseDetailTheater
    {
        [Display(Name = "Theater One")] TheaterOne,
        [Display(Name = "Theater Two")] TheaterTwo
    }

    public enum PDSeat
    {
        [Display(Name = "Seat A1")] A1,
        [Display(Name = "Seat A2")] A2,
        [Display(Name = "Seat A3")] A3,
        [Display(Name = "Seat A4")] A4,
        [Display(Name = "Seat A5")] A5,
        [Display(Name = "Seat B1")] B1,
        [Display(Name = "Seat B2")] B2,
        [Display(Name = "Seat B3")] B3,
        [Display(Name = "Seat B4")] B4,
        [Display(Name = "Seat B5")] B5,
        [Display(Name = "Seat C1")] C1,
        [Display(Name = "Seat C2")] C2,
        [Display(Name = "Seat C3")] C3,
        [Display(Name = "Seat C4")] C4,
        [Display(Name = "Seat C5")] C5,
        [Display(Name = "Seat D1")] D1,
        [Display(Name = "Seat D2")] D2,
        [Display(Name = "Seat D3")] D3,
        [Display(Name = "Seat D4")] D4,
        [Display(Name = "Seat D5")] D5,
        [Display(Name = "Seat E1")] E1,
        [Display(Name = "Seat E2")] E2,
        [Display(Name = "Seat E3")] E3,
        [Display(Name = "Seat E4")] E4,
        [Display(Name = "Seat E5")] E5,

    }

    public class PurchaseDetail
	{

        //public Int32 PurchaseID { get; set; }
        [Key]
        public Int32 PurchaseDetailID { get; set; }
        public Int32 TransactionID { get; set; }

       // public String Movie { get; set; }
       // public DateTime DateTime { get; set; }

        public PDSeat PDSeat { get; set; }

      //  public PurchaseDetailTheater PurchaseDetailTheater { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TicketPrice { get; set; }

        public Int32 PopcornPoints {  get; set; }

        public bool SeniorDiscount { get; set; }

        public bool TuesdayDiscount { get; set; }   

        public PaymentMethod PaymentMethod { get; set; }
        
        
        
        public Boolean IsGift { get; set; }

        //public PurchaseStatus PurchaseStatus { get; set; }

        public DiscountType DiscountType { get; set; }
        // Nav Properties
        public Purchase Purchase { get; set; }

        public Schedule Schedule { get; set; }

        //Additional Properties
      
      
    }
}

