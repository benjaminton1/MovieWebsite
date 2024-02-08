using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Group5_FinalProject_v2.Controllers
{
    public class ReportsController : Controller
    {
        private AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Purchase> SelectedPurchases;

                SelectedPurchases = await _context.Purchases
                                 .Include(o => o.PurchaseDetail)
                                 .ToListAsync();
           

            return View(SelectedPurchases.OrderBy(o => o.PurchaseID));
        }


        public IActionResult DetailedSearch()
        {

            ViewBag.AllGenres = GetAllPurchasesSelectList();
            // set default properties by creating new instance of svm
            ReportSearchViewModel svm = new ReportSearchViewModel();
            // "All Categories" is selected as default
            svm.SearchName = "";
            return View(svm);
        }

        private SelectList GetAllPurchasesSelectList()
        {
            List<Purchase> purchaseList = _context.Purchases.ToList();
            Purchase SelectNone = new Purchase() { PurchaseID = 0};
            purchaseList.Add(SelectNone);
            SelectList purchaseSelectList = new SelectList(purchaseList.OrderBy(c => c.PurchaseID));
            return purchaseSelectList;
        }
        public IActionResult DisplaySearchResults(ReportSearchViewModel svm)
        {
            //var query = from j in _context.Schedules.Include(m => m.Movie).ThenInclude(g => g.Genres)
            //            select j;
            var query = from j in _context.Purchases
                        select j;
            if (svm.SearchName != null)
            {
                query = query.Where(j => j.User.FullName.Contains(svm.SearchName));
            }
            if (svm.SearchPurchaseDate != null)
            {
                query = query.Where(j => j.PurchaseDate.ToString() == svm.SearchPurchaseDate.ToString());
            }
            List<Purchase> selectedPurchases = query.Include(j => j.PurchaseDetail).ToList();
            ViewBag.SelectedPurchases = selectedPurchases;
            return View("Index", selectedPurchases.OrderByDescending(j => j.PurchaseID));
        }

        private bool PurchaseExists(int id)
        {
            return (_context.Purchases?.Any(e => e.PurchaseID == id)).GetValueOrDefault();
        }
    }
}


