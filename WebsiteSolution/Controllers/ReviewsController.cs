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
    public class ReviewsController : Controller

    {
        private readonly AppDbContext _context;

        public ReviewsController(AppDbContext context)

        {
            _context = context;
        }

        //GET: Reviews

        public async Task<IActionResult> Index()
        {
            var reviews = _context.Reviews.Include(r => r.Movie).ToList();
            // Add the ViewBag property after retrieving schedules
            ViewBag.AllReviews = reviews.Count();
            return View(reviews);
        }



        // GET: Reviews/Details/5

        public IActionResult Details(int? id)

        {

            if (id == null || _context.Reviews == null)
            {
                return View("Error", new String[] { "Please specify a review to view!" });
            }

            Review review = _context.Reviews.Find(id);

            if (review == null)
            {
                return View("Error", new String[] { "The review was not found in the database." });
            }

            return View(review);

        }



        // GET: Reviews/Create

        public IActionResult Create()

        {

            return View();

        }



        // POST: Reviews/Create

        // To protect from overposting attacks, enable the specific properties you want to bind to.

        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("ReviewID,TextReview,NumRating,ReviewStatus")] Review review)

        {

            if (ModelState.IsValid)

            {

                _context.Add(review);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }



            return View(review);

        }



        // GET: Reviews/Edit/5

        public async Task<IActionResult> Edit(int? id)

        {

            if (id == null || _context.Reviews == null)

            {

                return View("Error", new string[] { "Please specify a review to edit!" });

            }



            var review = await _context.Reviews.FindAsync(id);

            if (review == null)

            {

                return NotFound();

            }

            return View(review);

        }



        // POST: Reviews/Edit/5

        // To protect from overposting attacks, enable the specific properties you want to bind to.

        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit([Bind("ReviewID,TextReview,NumRating,ReviewStatus")] Review review)

        //{

        //    if (ModelState.IsValid)

        //    {

        //        if (ModelState.IsValid)
        //        {
        //            _context.Entry(review).State = EntityState.Modified;
        //            _context.SaveChanges();
        //            return RedirectToAction("Index", "Movie");
        //        }
        //        return View(review);
        //    }

        //    return View(review);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("ReviewID,TextReview,NumRating,ReviewStatus")] Review review)
        {
            if (!ModelState.IsValid)
            {
                return View(review);
            }

            var reviewToUpdate = await _context.Reviews.FindAsync(review.ReviewID);
            if (reviewToUpdate == null)
            {
                return NotFound();
            }

            reviewToUpdate.TextReview = review.TextReview;
            reviewToUpdate.NumRating = review.NumRating;
            reviewToUpdate.ReviewStatus = review.ReviewStatus;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(review.ReviewID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction("Index", "Movie");
        }



        private bool ReviewExists(int id)

        {
            return (_context.Reviews?.Any(e => e.ReviewID == id)).GetValueOrDefault();
        }

    }

}