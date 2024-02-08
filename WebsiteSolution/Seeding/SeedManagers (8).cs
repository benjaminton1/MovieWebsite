
using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;
using Group5_FinalProject_v2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Group5_FinalProject_v2.Seeding
{
  
    public static class SeedManagers
    {
        public async static Task<IdentityResult> SeedAllManagers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Allen",
                    LastName = "Rogers",
                    FullName = "Allen Rogers",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                    Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,02,02),

                },
                Password = "3wCynC",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "captain@enterprise.net",
                    Email = "captain@enterprise.net",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Jean Luc",
                    LastName = "Picard",
                    FullName = "Jean Luc Picard",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                    Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,02,02),

                },
                Password = "Pbon0r",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "slayer@onegirl.net",
                    Email = "slayer@onegirl.net",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Buffy",
                    LastName = "Summers",
                    FullName = "Buffy Summers",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                    Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,02,02),

                },
                Password = "jW5fPP",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "liz@ggmail.com",
                    Email = "liz@ggmail.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    FullName = "Elizabeth Markham",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                    Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,02,02),

                },
                Password = "0QyilL",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "twin@deservedbetter.com",
                    Email = "twin@deservedbetter.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Fred",
                    LastName = "Weasley",
                    FullName = "Fred Weasley",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                    Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,02,02),

                },
                Password = "atLm6W",
                RoleName = "Manager"
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
                    errorFlag = aum.User.UserName;
                    // Took Utilities.AddUser from Relational Data Demo -> this is "Utilities/AddUser.cs"
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
