using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Group5_FinalProject_v2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        //Create the constructor so that we get an instance of AppDbContext
        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Contact()
        {
            return View();
        }

        //public IActionResult Schedule()
        //{
        //    return View("Schedule");
        //}

    }
}