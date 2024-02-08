
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
  
    public static class SeedCustomers
    {
        public async static Task<IdentityResult> SeedAllCustomers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "cbaker@example.com",
                    Email = "cbaker@example.com",
                    PhoneNumber = "152-275-7212",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Christopher",
                    LastName = "Baker",
                    FullName = "Christopher Baker",
                    Street = "1 David Park",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1945, 8, 2, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "bookworm",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "banker@longhorn.net",
                    Email = "banker@longhorn.net",
                    PhoneNumber = "596-211-5872",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Michelle",
                    LastName = "Banks",
                    FullName = "Michelle Banks",
                    Street = "10117 Swallow Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78712",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2000, 11, 18, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "aclfest2017",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "franco@example.com",
                    Email = "franco@example.com",
                    PhoneNumber = "756-979-6344",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    FullName = "Franco Broccolo",
                    Street = "21344 Marcy Avenue",
                    City = "Austin",
                    State = "TX",
                    Zip = "78786",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2002, 5, 2, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "aggies",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "wchang@example.com",
                    Email = "wchang@example.com",
                    PhoneNumber = "220-613-2686",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Wendy",
                    LastName = "Chang",
                    FullName = "Wendy Chang",
                    Street = "894 Kim Junction",
                    City = "Eagle Pass",
                    State = "TX",
                    Zip = "78852",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1955, 8, 20, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "alaskaboy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "limchou@gogle.com",
                    Email = "limchou@gogle.com",
                    PhoneNumber = "728-717-9608",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Lim",
                    LastName = "Chou",
                    FullName = "Lim Chou",
                    Street = "703 Anthes Lane",
                    City = "Austin",
                    State = "TX",
                    Zip = "78729",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2009, 4, 6, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "allyrally",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "shdixon@aoll.com",
                    Email = "shdixon@aoll.com",
                    PhoneNumber = "338-796-7818",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Shan",
                    LastName = "Dixon",
                    FullName = "Shan Dixon",
                    Street = "45927 Forest Run Trail",
                    City = "Georgetown",
                    State = "TX",
                    Zip = "78628",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1989, 10, 21, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "Anchorage",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "j.b.evans@aheca.org",
                    Email = "j.b.evans@aheca.org",
                    PhoneNumber = "878-921-1122",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Jim Bob",
                    LastName = "Evans",
                    FullName = "Jim Bob Evans",
                    Street = "51 Miller Park",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2001, 10, 8, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "billyboy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "feeley@penguin.org",
                    Email = "feeley@penguin.org",
                    PhoneNumber = "389-364-3017",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    FullName = "Lou Ann Feeley",
                    Street = "80686 Ryan Terrace",
                    City = "Austin",
                    State = "TX",
                    Zip = "78704",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1966, 6, 19, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "bunnyhop",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "tfreeley@minnetonka.ci.us",
                    Email = "tfreeley@minnetonka.ci.us",
                    PhoneNumber = "327-105-4962",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    FullName = "Tesa Freeley",
                    Street = "97327 Express Avenue",
                    City = "College Station",
                    State = "TX",
                    Zip = "77840",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1996, 9, 12, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "dustydusty",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "mgarcia@gogle.com",
                    Email = "mgarcia@gogle.com",
                    PhoneNumber = "480-950-2469",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    FullName = "Margaret Garcia",
                    Street = "1 Arrowood Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78756",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2002, 6, 17, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "gowest",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "439-864-2291",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Charles",
                    LastName = "Haley",
                    FullName = "Charles Haley",
                    Street = "5035 Dayton Court",
                    City = "Austin",
                    State = "TX",
                    Zip = "78746",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1998, 5, 15, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "hampton1",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "jeffh@sonic.com",
                    Email = "jeffh@sonic.com",
                    PhoneNumber = "287-989-2098",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    FullName = "Jeffrey Hampton",
                    Street = "90461 Evergreen Place",
                    City = "Austin",
                    State = "TX",
                    Zip = "78756",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2003, 4, 8, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "hickhickup",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "wjhearniii@umich.org",
                    Email = "wjhearniii@umich.org",
                    PhoneNumber = "759-247-6853",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "John",
                    LastName = "Hearn",
                    FullName = "John Hearn",
                    Street = "973 Stephen Alley",
                    City = "Liberty",
                    State = "TX",
                    Zip = "77575",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2000, 9, 15, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "ingram2015",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "ahick@yaho.com",
                    Email = "ahick@yaho.com",
                    PhoneNumber = "603-447-9200",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    FullName = "Anthony Hicks",
                    Street = "80319 Forster Parkway",
                    City = "San Antonio",
                    State = "TX",
                    Zip = "78203",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1980, 5, 7, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "jhearn22",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "ingram@jack.com",
                    Email = "ingram@jack.com",
                    PhoneNumber = "965-996-5936",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Brad",
                    LastName = "White",
                    FullName = "Brad White",
                    Street = "96 Stang Hill",
                    City = "New Braunfels",
                    State = "TX",
                    Zip = "78132",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1986, 2, 6, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "joejoejoe",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "toddj@yourmom.com",
                    Email = "toddj@yourmom.com",
                    PhoneNumber = "171-155-1224",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    FullName = "Todd Jacobs",
                    Street = "23726 Main Crossing",
                    City = "New York",
                    State = "NY",
                    Zip = "10101",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(1975, 8, 29, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "jrod2017",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "thequeen@aska.net",
                    Email = "thequeen@aska.net",
                    PhoneNumber = "300-564-3682",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    FullName = "Victoria Lawrence",
                    Street = "6299 Moland Alley",
                    City = "Lockhart",
                    State = "TX",
                    Zip = "78644",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2001, 1, 29, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "longhorns",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "linebacker@gogle.com",
                    Email = "linebacker@gogle.com",
                    PhoneNumber = "968-319-5113",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Erik",
                    LastName = "Lineback",
                    FullName = "Erik Lineback",
                    Street = "6 Truax Street",
                    City = "Kingwood",
                    State = "TX",
                    Zip = "77325",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2004, 5, 21, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "louielouie",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "elowe@netscare.net",
                    Email = "elowe@netscare.net",
                    PhoneNumber = "932-455-8010",
                    // Add additional fields that you created on the AppUser class
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    FullName = "Ernest Lowe",
                    Street = "50883 Heath Park",
                    City = "Beverly Hills",
                    State = "CA",
                    Zip = "90210",
                    PopcornPoints = 0,
                    //FirstName is included as an example
                    Birthday = new DateTime(2001, 12, 27, 0, 0, 0),
                    EmployeeStatus = false,
                },
                Password = "martin1234",
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
