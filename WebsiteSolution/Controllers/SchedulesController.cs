using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;
namespace Group5_FinalProject_v2.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly AppDbContext _context;

        public SchedulesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            var schedules = _context.Schedules.Include(s => s.Movie).ToList();
            // Add the ViewBag property after retrieving schedules
            ViewBag.AllSchedules = schedules.Count();
            return View(schedules);
        }
        // GET: Schedules/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{ 
        //    var schedules = _context.Schedules.Include(s => s.Movie).ThenInclude(m => m.Genres).ToList();
        //    // Add the ViewBag property after retrieving schedules
        //    ViewBag.AllSchedules = schedules.Count();
        //    return View(schedules);
        //}
        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)

        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }
            var schedule = await _context.Schedules
            .FirstOrDefaultAsync(m => m.ScheduleID == id);
            if (schedule == null)
            {
                return NotFound();
            }
            return View(schedule);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScheduleID,ShowTime,Theater,SpecialEvent")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }
        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return View(schedule);
        }


        // POST: Schedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ScheduleID,ShowTime,Theater,SpecialEvent")] Schedule schedule)
        //{
        //    if (id != schedule.ScheduleID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        var existingSchedule = await _context.Schedules.FindAsync(id);
        //        existingSchedule.ShowTime = schedule.ShowTime;
        //        existingSchedule.Theater = schedule.Theater;
        //        existingSchedule.SpecialEvent = schedule.SpecialEvent;

        //        _context.Update(existingSchedule);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("Index", "Schedules");
        //    }

        //    return View(schedule);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ScheduleID,Theater,ShowTime,SpecialEvent")] Schedule schedule)
        //{
        //    //this is a security check to make sure they are editing the correct record
        //    if (id != schedule.ScheduleID)
        //    {
        //        return View("Error", new String[] { "There was a problem editing this order. Try again!" });
        //    }

        //    //create a new registration detail
        //    var dbSched = await _context.Schedules.FindAsync(id);
        //    //if code gets this far, update the record

        //    if (dbSched == null)
        //    {
        //        return NotFound();
        //    }

        //    // Update the properties with the new values
        //    dbSched.Theater = schedule.Theater;
        //    dbSched.ShowTime = schedule.ShowTime;
        //    dbSched.SpecialEvent = schedule.SpecialEvent;

        //    // Save changes to the database
        //    await _context.SaveChangesAsync();

        //    return RedirectToAction("Index", "Schedules", new { id = dbSched.ScheduleID });
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScheduleID,Theater,ShowTime,SpecialEvent")] Schedule schedule)
        {


            // This is a security check to make sure they are editing the correct record
            if (id != schedule.ScheduleID)
            {
                return View("Error", new String[] { "There was a problem adding this ticket. Try again!" });
            }

            // Find the existing schedule record in the database
            var existingSchedule = await _context.Schedules.FindAsync(schedule.ScheduleID);
            DateTime nextWeekStart = DateTime.Now.Date.AddDays(7);
            DateTime nextWeekEnd = nextWeekStart.Date.AddDays(6);

            // If the schedule record was not found, return a NotFound response
            if (existingSchedule == null)
            {
                return NotFound();
            }

            if (schedule.ShowTime < nextWeekStart || schedule.ShowTime > nextWeekEnd)
            {
                ModelState.AddModelError("ShowTime", "Showtime must be within the next week.");
                // Handle the error, display a message, or return to the view
                return View(schedule);
            }

            // Update the existing schedule record with the new values
            existingSchedule.Theater = schedule.Theater;
            existingSchedule.ShowTime = schedule.ShowTime;
            existingSchedule.SpecialEvent = schedule.SpecialEvent;

            // Save the changes to the database
            _context.Update(existingSchedule);
            await _context.SaveChangesAsync();

            // Redirect the user back to the index page
            return RedirectToAction("Index", "Schedules", new { id = existingSchedule.ScheduleID });
        }
       
       
      


        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }
            var schedule = await _context.Schedules
            .FirstOrDefaultAsync(m => m.ScheduleID == id);
            if (schedule == null)
            {
                return NotFound();
            }
            return View(schedule);
        }
        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schedules == null)
            {
                return Problem("Entity set 'AppDbContext.Schedules'  is null.");
            }
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule != null)
            {
                _context.Schedules.Remove(schedule);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult DetailedSearch()
        {

            
            ViewBag.AllGenres = GetAllGenresSelectList();
            // set default properties by creating new instance of svm
            SearchViewModel svm = new SearchViewModel();
            // "All Categories" is selected as default
            svm.SelectedGenre = 0;

            
            ViewBag.AllGenres = GetAllGenresSelectList();
            // set default properties by creating new instance of svm
            

            return View(svm);
        }
        private SelectList GetAllGenresSelectList()
        {
            List<Genre> genreList = _context.Genres.ToList();
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };
            genreList.Add(SelectNone);
            SelectList genreSelectList = new SelectList(genreList.OrderBy(c => c.GenreID), "GenreID", "GenreName");
            return genreSelectList;
        }
        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {

            //var query = from j in _context.Schedules.Include(m => m.Movie).ThenInclude(g => g.Genres)
            //            select j;


            //var query = from j in _context.Schedules.Include(m => m.Movie).ThenInclude(g => g.Genres)
            //            select j;
            var query = from j in _context.Schedules

                        select j;
            if (svm.SearchTitle != null)
            {
                query = query.Where(j => j.Movie.Title.Contains(svm.SearchTitle));
            }
            if (svm.SearchTagLine != null)
            {
                query = query.Where(j => j.Movie.Tagline.Contains(svm.SearchTagLine));
            }

            if (svm.SelectedGenre != 0)
            {
                query = query.Where(j => j.Movie.Genres.GenreID == svm.SelectedGenre);
            }
            if (svm.SearchMPAARating != null)
            {
                query = query.Where(j => j.Movie.MPAARating == svm.SearchMPAARating);
            }

            if (svm.SearchReleaseYear != null)
            {
                query = query.Where(j => j.Movie.ReleaseYear.ToString() == svm.SearchReleaseYear.ToString());
            }

            List<Schedule> selectedSchedules = query.Include(j => j.Movie).ToList();


            //if (svm.SearchCustomerRating != null) // user entered a salary
            //{
            //    if (svm.SearchType == SearchType.GreaterThan) // user selected "greater than"
            //    {
            //        query = query.Where(j => j.CustomerRating >= (svm.SearchCustomerRating));
            //    }

            //    else if (svm.SearchType == SearchType.LessThan) // user selected "less than"

            //    {
            //        query = query.Where(j => j.CustomerRating <= (svm.SearchCustomerRating));
            //    }
            //}

            //List<Schedule> selectedSchedules = query.Include(j => j.Movie).ThenInclude(m => m.Genres).ToList();

            ViewBag.SelectedSchedules = selectedSchedules;
            return View("Index", selectedSchedules.OrderByDescending(j => j.Movie.ReleaseYear));
        }

        public ActionResult PlanSchedule()
        {
            var schedules = _context.Schedules.Include(s => s.Movie).ToList();

            // Add the ViewBag property after retrieving schedules
            ViewBag.AllSchedules = schedules.Count();






            // Get movies for the next week
            DateTime nextWeekStart = DateTime.Now.Date.AddDays(7);
            DateTime nextWeekEnd = nextWeekStart.Date.AddDays(6);

            var moviesForNextWeek = _context.Schedules

                .Where(m => m.ShowTime.Date >= nextWeekStart && m.ShowTime.Date <= nextWeekEnd)
                .ToList();


            return View(moviesForNextWeek);
        }


        public IActionResult AddMovie(int? id)
        {
            // Assuming you want to pass the ScheduleID to the view for editing
            // If it's a new movie, id will be null
            var schedule = new Schedule { ScheduleID = id.GetValueOrDefault() };
            return View(schedule);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddMovie([Bind("ShowTime, Theater, SpecialEvent")] Schedule schedule)
        //{
        //    // Check if the ShowTime is within the allowed date range
        //    DateTime nextWeekStart = DateTime.Now.Date.AddDays(7);
        //    DateTime nextWeekEnd = nextWeekStart.Date.AddDays(6);

        //    if (schedule.ShowTime < nextWeekStart || schedule.ShowTime > nextWeekEnd)
        //    {
        //        ModelState.AddModelError("ShowTime", "Showtime must be within the next week.");
        //        // Handle the error, display a message, or return to the view
        //        return View(schedule);
        //    }

        //    if ((schedule.ShowTime >= nextWeekStart && schedule.ShowTime <= nextWeekEnd))
        //    {
        //        // If the ModelState is valid, proceed to save the schedule to the database
        //        var existingSchedule = await _context.Schedules.FindAsync(schedule.ScheduleID);

        //        // If the schedule record was not found, return a NotFound response
        //        if (existingSchedule == null)
        //        {
        //            return NotFound();
        //        }

        //        // Update the existing schedule record with the new values
        //        existingSchedule.Theater = schedule.Theater;
        //        existingSchedule.ShowTime = schedule.ShowTime;
        //        existingSchedule.SpecialEvent = schedule.SpecialEvent;

        //        // Save the changes to the database
        //        _context.Update(existingSchedule);
        //        await _context.SaveChangesAsync();

        //        // Redirect the user back to the index page
        //        return RedirectToAction("Index", "Schedules", new { id = existingSchedule.ScheduleID });
        //        // Add your logic to save the schedule to the database using the context (_context)
        //    }

        //    // If ModelState is not valid, return to the view with the model

        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddMovie(int id, [Bind("ScheduleID, ShowTime, Theater, SpecialEvent")] Schedule schedule)
        //{
        //    // Check if the ShowTime is within the allowed date range
        //    DateTime nextWeekStart = DateTime.Now.Date.AddDays(7);
        //    DateTime nextWeekEnd = nextWeekStart.Date.AddDays(6);

        //    if (schedule.ShowTime < nextWeekStart || schedule.ShowTime > nextWeekEnd)
        //    {
        //        ModelState.AddModelError("ShowTime", "Showtime must be within the next week.");
        //        // Handle the error, display a message, or return to the view
        //        return View(schedule);
        //    }

        //    // Retrieve the existing schedule record from the database
        //    var existingSchedule = await _context.Schedules.FindAsync(schedule.ScheduleID);

        //    // Check if there is an existing schedule with the same ShowTime
        //    var conflictingSchedule = await _context.Schedules.FirstOrDefaultAsync(s => s.ShowTime == schedule.ShowTime);

        //    if (conflictingSchedule != null)
        //    {
        //        ModelState.AddModelError("ShowTime", "The new movie timing conflicts with an existing movie.");
        //        // Handle the error, display a message, or return to the view
        //        return View(schedule);
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        if (existingSchedule == null)
        //        {
        //            // If the schedule record was not found, create a new one
        //            _context.Add(schedule);
        //        }
        //        else
        //        {
        //            // Update the existing schedule record with the new values
        //            existingSchedule.Theater = schedule.Theater;
        //            existingSchedule.ShowTime = schedule.ShowTime;
        //            existingSchedule.SpecialEvent = schedule.SpecialEvent;

        //            // Update the schedule record in the database
        //            _context.Update(existingSchedule);
        //        }

        //        // Save the changes to the database
        //        await _context.SaveChangesAsync();

        //        // Redirect the user back to the index page
        //        return RedirectToAction("Index", "Schedules", new { id = existingSchedule.ScheduleID });
        //    }

        //    // If ModelState is not valid, return to the view with the model
        //    return View(PlanSchedule);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMovie(int id, [Bind("ScheduleID, ShowTime, Theater, SpecialEvent")] Schedule schedule)
        {
            // Check if the ShowTime is within the allowed date range
            DateTime nextWeekStart = DateTime.Now.Date.AddDays(7);
            DateTime nextWeekEnd = nextWeekStart.Date.AddDays(6);

            if (schedule.ShowTime < nextWeekStart || schedule.ShowTime > nextWeekEnd)
            {
                ModelState.AddModelError("ShowTime", "Showtime must be within the next week.");
                // Handle the error, display a message, or return to the view
                return View(schedule);
            }
            var existingSchedule = await _context.Schedules.FindAsync(schedule.ScheduleID);
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    
                    // If ScheduleID is 0, it's a new schedule, so add it
                    _context.Add(schedule);

                    existingSchedule.Theater = schedule.Theater;
                    existingSchedule.ShowTime = schedule.ShowTime;
                    existingSchedule.SpecialEvent = schedule.SpecialEvent;

                    // Save the changes to the database
                    _context.Update(existingSchedule);
                    await _context.SaveChangesAsync();
                }
                // Redirect the user back to the index page
                return RedirectToAction("Index", "Schedules", new { id = existingSchedule.ScheduleID });
            }

            // If ModelState is not valid, return to the view with the model
            return View(schedule);
        }

        private bool ScheduleExists(int id)
        {
            return (_context.Schedules?.Any(e => e.ScheduleID == id)).GetValueOrDefault();
        }

    }
}
