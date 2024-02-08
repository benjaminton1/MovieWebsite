using Group5_FinalProject_v2.Utilities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

//TODO: Make this namespace match your project name
namespace Group5_FinalProject_v2.Models
{
    public class AppUser : IdentityUser
    {

        //TODO: Add custom user fields - first name is included as an example
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        public String FullName
        {
           // get { return FirstName + " " + LastName; }
           get;set; 
        }

        public int PopcornPoints { get; set; }

        [Display(Name = "Street Name")]
        public String Street { get; set; }

        [Display(Name = "City")]
        public String City { get; set; }

        [Display(Name = "State")]
        public String State { get; set; }

        [Display(Name = "Zip Code")]
        public String Zip { get; set; }

        [Display(Name = "Birthday")]
        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }
        

        [Display(Name = "Employee Status")]
        public Boolean EmployeeStatus { get; set; }


        // Nav Properties
        public List<Purchase> Purchase { get; set; }  

        public List<Review> Review { get; set; }

        public AppUser()
        {
            Purchase ??= new List<Purchase>();
            Review ??= new List<Review>();
        }
    }
}
