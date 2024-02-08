using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group5_FinalProject_v2.DAL;
using Group5_FinalProject_v2.Models;
namespace Group5_FinalProject_v2.Controllers
{
    public class PurchaseDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public PurchaseDetailsController(AppDbContext context)
        {
            _context = context;
        }
        // GET: PurchaseDetails
        public async Task<IActionResult> Index()
        {
            return _context.PurchaseDetails != null ?
                        View(await _context.PurchaseDetails.ToListAsync()) :
                        Problem("Entity set 'AppDbContext.PurchaseDetails'  is null.");
        }
        // GET: PurchaseDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PurchaseDetails == null)
            {
                return NotFound();
            }
            var purchaseDetail = await _context.PurchaseDetails
                .FirstOrDefaultAsync(m => m.PurchaseDetailID == id);
            if (purchaseDetail == null)
            {
                return NotFound();
            }
            return View(purchaseDetail);
        }
        // GET: PurchaseDetails/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: PurchaseDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PurchaseDetailID,TransactionID,PDSeat,TicketPrice,PopcornPoints,SeniorDiscount,TuesdayDiscount,PaymentMethod,IsGift,DiscountType")] PurchaseDetail purchaseDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseDetail);
        }
        // GET: PurchaseDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PurchaseDetails == null)
            {
                return NotFound();
            }
            var purchaseDetail = await _context.PurchaseDetails.FindAsync(id);
            if (purchaseDetail == null)
            {
                return NotFound();
            }
            return View(purchaseDetail);
        }
        // POST: PurchaseDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PurchaseDetailID,TransactionID,PDSeat,TicketPrice,PopcornPoints,SeniorDiscount,TuesdayDiscount,PaymentMethod,IsGift,DiscountType")] PurchaseDetail purchaseDetail)
        {
            if (id != purchaseDetail.PurchaseDetailID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseDetailExists(purchaseDetail.PurchaseDetailID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseDetail);
        }
        // GET: PurchaseDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PurchaseDetails == null)
            {
                return NotFound();
            }
            var purchaseDetail = await _context.PurchaseDetails
                .FirstOrDefaultAsync(m => m.PurchaseDetailID == id);
            if (purchaseDetail == null)
            {
                return NotFound();
            }
            return View(purchaseDetail);
        }
        // POST: PurchaseDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PurchaseDetails == null)
            {
                return Problem("Entity set 'AppDbContext.PurchaseDetails'  is null.");
            }
            var purchaseDetail = await _context.PurchaseDetails.FindAsync(id);
            if (purchaseDetail != null)
            {
                _context.PurchaseDetails.Remove(purchaseDetail);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool PurchaseDetailExists(int id)
        {
            return (_context.PurchaseDetails?.Any(e => e.PurchaseDetailID == id)).GetValueOrDefault();
        }
    }
}