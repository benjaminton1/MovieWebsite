using Microsoft.AspNetCore.Identity;


//TODO: Update these using statements to include your project name
using Group5_FinalProject_v2.Utilities;
using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;

//TODO: Upddate this namespace to match your project name
namespace Group5_FinalProject_v2.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    PhoneNumber = "(512)555-1234",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Admin",
                    LastName = "Example",
                    FullName = "Admin Example",
                    Street = "123 Fake Street",
                    City = "City",
                    State = "Flugerville",
                    Zip = "78705",
                    Birthday = DateTime.Now, 
                    EmployeeStatus = true

                },
                Password = "Abc123!",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "bevo@example.com",
                    Email = "bevo@example.com",
                    PhoneNumber = "(512)555-5555",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Bevo",
                    LastName = "Longhorn",
                    FullName = "Bevo Longhorn",
                    Street = "456 Fake Street",
                    City = "City",
                    State = "Flugercity",
                    Zip = "78705",
                    Birthday = DateTime.Now,
                    EmployeeStatus = false

                },
                Password = "Password123!",
                RoleName = "Customer"

            });

            

            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;
        }
    }
}
