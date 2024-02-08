
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
  
    public static class SeedEmployees
    {
        public async static Task<IdentityResult> SeedAllEmployees(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "michelle@example.com",
                    Email = "michelle@example.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Michelle",
                    LastName = "Banks",
                    FullName = "Michelle Banks",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "jVb0Z6",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "toddy@aool.com",
                    Email = "toddy@aool.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    FullName = "Todd Jacobs",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "1PnrBV",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    FullName = "Ernest Lowe",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "v3n5AV",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "mclarence@aool.com",
                    Email = "mclarence@aool.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Clarence",
                    LastName = "Martin",
                    FullName = "Clarence Martin",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "zBLq3S",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "nelson.Kelly@aool.com",
                    Email = "nelson.Kelly@aool.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    FullName = "Kelly Nelson",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "FSb8rA",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    FullName = "Megan Rhodes",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "1xVfHp",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "sheff44@ggmail.com",
                    Email = "sheff44@ggmail.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    FullName = "Martin Sheffield",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "4XKLsd",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Peter",
                    LastName = "Stump",
                    FullName = "Peter Stump",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "1XdmSV",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "yhuik9.Taylor@aool.com",
                    Email = "yhuik9.Taylor@aool.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    FullName = "Rachel Taylor",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "9yhFS3",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "tuck33@ggmail.com",
                    Email = "tuck33@ggmail.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Clent",
                    LastName = "Tucker",
                    FullName = "Clent Tucker",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "I6BgsS",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "taylordjay@aool.com",
                    Email = "taylordjay@aool.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Allison",
                    LastName = "Taylor",
                    FullName = "Allison Taylor",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "Vjb1wI",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "jojoe@ggmail.com",
                    Email = "jojoe@ggmail.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    FullName = "Joe Nguyen",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "xI8Brg",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "hicks43@ggmail.com",
                    Email = "hicks43@ggmail.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    FullName = "Anthony Hicks",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "s33WOz",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    FullName = "Bill O'Reilly",
                    EmployeeStatus = true,
                    PopcornPoints = 0,
                    PhoneNumber = "",
                     Street = "",
                    City = "",
                    State = "",
                    Zip = "",
                    Birthday = new DateTime(1999,01,01),

                },
                Password = "pS2OJh",
                RoleName = "Employee"
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
