using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System;
namespace Group5_FinalProject_v2.Models
{
	public class Purchase
	{
		private const decimal TAX_RATE = 0.0825m; 
		public Int32 PurchaseID { get; set; }

        public Int32 ConfirmNum { get; set; }


        //TODO: is this inherited by Identity? or should recipient id be different? is it required?
        [Display(Name = "Recipient Name")]
		public string? Recipient { get; set; }

		//TODO: correct to pull from product details? 
		//TODO: if so, must create navigational property
		[Display(Name = "Order Subtotal")]
		[DisplayFormat(DataFormatString  = "{0:C}")]
		public Decimal Subtotal
		{
            get;set;//get { return PurchaseDetail.Sum(od => od.Price); }
		}

		[Display(Name = "Order Tax")]
		[DisplayFormat(DataFormatString = "{0:C}")]
		public Decimal Tax
		{   
            get;set;
			//get { return Subtotal * TAX_RATE; }
		}

        [Display(Name = "Grand Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Total
        
            { get; set;
            //get { return Subtotal + Tax; }
        }
        public Int32 NumberOfTickets { get; set; }
        public Int32 TotalPopcornPoints { get; set; }

        //public Int32 PopcornUsed { get; set; }

        //public Int32 PopcornAvailable { get; set; }
        public bool PurchaseStatus { get; set; }

		public DateTime PurchaseDate { get; set; }


        // Nav Properties
        public List<PurchaseDetail> PurchaseDetail { get; set; }  
       

        public AppUser User { get; set; }

        public Purchase()
        {
            if (PurchaseDetail == null)
            {
                PurchaseDetail = new List<PurchaseDetail>();
            }
        }
    }
}


