using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;
using Microsoft.AspNetCore.Authorization;

namespace Group5_FinalProject_v2.Controllers
{
    public class MoviesController : Controller
    {
        //create an instance of AppDbContext
        private AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        //query the database for all movies and pass it through index view
        public IActionResult Index(string SearchString)
        {
            //use LINQ to filter wanted repos
            var query = from m in _context.Movies
                        select m;

            if (SearchString != null)
            {
                query = query.Where(m => m.Title.Contains(SearchString) ||
                              m.Description.Contains(SearchString));
            }

            List<Movie> SelectedMovies = query.Include(m => m.Genres).ToList();

            //Populate the view bag with a count of all movies
            ViewBag.AllJobs = _context.Movies.Count();

            //Populate the view bag with a count of selected movies
            ViewBag.SelectedJobs = SelectedMovies.Count();

            return View(SelectedMovies.OrderBy(m => m.Title));
        }

        // GET: Movies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return View("Error", new String[] { "Please specify a movie to view!" });
            }

            Movie movie = _context.Movies.Include(ms => ms.Genres).FirstOrDefault(ms => ms.MovieID == id);

            //Movie does not exist in database

            if (movie == null)
            {
                return View("Error", new String[] { "That movie was not found in the database." });
            }

            //if code gets this far, all is well
            return View(movie);
        }

        // GET: Movies/Create
        [Authorize(Roles = "Manager")]

        public IActionResult Create()
        {
            ViewBag.AllGenres = GetAllGenres();
            ViewBag.AllMPAAs = GetAllMPAASL();
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieID,Title,ReleaseYear,Description,RunTime,Actors")] Movie movie, int SelectedGenres, string SelectedMPAA)
        {
            movie.MovieID = Utilities.GenerateNextMovieID.GetNextMovieID(_context);

            if (ModelState.IsValid)
            {
                movie.Genres.GenreID = SelectedGenres;
                movie.MPAARating = SelectedMPAA;

                _context.Add(movie);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.AllGenres = GetAllGenres();

            return View(movie);
        }

        // GET: Movies/Edit/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            //if the user didn't specify a movie id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a movie to edit!" });
            }

            //find the movie in the database
            //be sure to change the data type to movie instead of 'var'
            Movie movie = await _context.Movies.Include(c => c.Genres)
                                           .FirstOrDefaultAsync(c => c.MovieID == id);

            //if the movie does not exist in the database, then show the user
            //an error message
            if (movie == null)
            {
                return View("Error", new string[] { "This movie was not found!" });
            }

            //populate the viewbag with existing genres
            ViewBag.AllGenres = GetAllGenres(movie);
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]

        public async Task<IActionResult> Edit(int id, [Bind("MovieID,Title,ReleaseYear,Description,RunTime,MPAARating,Tagline,Actors")] Movie movie, int GenreID)
        {
            //this is a security check to see if the user is trying to modify
            //a different record.  Show an error message
            if (id != movie.MovieID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid == false) //there is something wrong
            {
                ViewBag.AllGenres = GetAllGenres(movie);
                return View(movie);
            }

            //if code gets this far, attempt to edit the movie
            try
            {
                //Find the movie to edit in the database and include relevant 
                //navigational properties
                Movie dbMovie = _context.Movies
                    .Include(c => c.Genres)
                    .FirstOrDefault(c => c.MovieID == movie.MovieID);

                if (dbMovie == null)
                {
                    return View("Error", new string[] { "This movie was not found!" });
                }

                Genre selectedGenre = await _context.Genres.FindAsync(GenreID);
                if (selectedGenre != null)
                {
                    dbMovie.Genres = selectedGenre;
                }

                // Update other properties
                dbMovie.Title = movie.Title;
                dbMovie.ReleaseYear = movie.ReleaseYear;
                dbMovie.Description = movie.Description;
                dbMovie.RunTime = movie.RunTime;
                dbMovie.MPAARating = movie.MPAARating;
                dbMovie.Tagline = movie.Tagline;
                dbMovie.Actors = movie.Actors;

                // Save the changes
                _context.Update(dbMovie);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this movie.", ex.Message });
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movies == null)
            {
                return Problem("Entity set 'AppDbContext.Movies'  is null.");
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
          return (_context.Movies?.Any(e => e.MovieID == id)).GetValueOrDefault();
        }

        private SelectList GetAllGenres()
        {
            List<Genre> allGenres = _context.Genres.ToList();

            SelectList slAllGenres = new SelectList(allGenres.OrderBy(d => d.GenreName), "GenreID", "GenreName");

            return slAllGenres;
        }

        private SelectList GetAllGenres(Movie movie)
        {
            List<Genre> allGenres = _context.Genres.ToList();

            SelectList slAllGenres = new SelectList(allGenres.OrderBy(d => d.GenreName), "GenreID", "GenreName", movie.Genres.GenreID);

            return slAllGenres;
        }

        private SelectList GetAllMPAAs()
        {
            var allMPAAs = _context.Movies.Select(m => m.MPAARating).Distinct().ToList();

            SelectList slAllMPAAs = new SelectList(allMPAAs);

            return slAllMPAAs;
        }

        private SelectList GetAllMPAASL()
        {
            var allMPAAs = _context.Movies.Select(m => m.MPAARating).Distinct().ToList();

            SelectList slAllMPAAs = new SelectList(allMPAAs);

            return slAllMPAAs;
        }
    }
}
