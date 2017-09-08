using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScrumCentral.Models;
using ScrumCentral.Helpers;

namespace ScrumCentral.Controllers
{
    public class PokerSessionController : Controller
    {
        private readonly PokerSessionContext _context;
        private static HTTPHelper hTTPHelper = HTTPHelper.Instance;
        public PokerSessionController(PokerSessionContext context)
        {
            _context = context;
        }

        // GET: PokerSession
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WaitingScreen()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult RecieveVote(int cardValue)
        {
            
            return View();
        }

        [HttpPost]
        public void StartSession(string sessionName)
        {
            hTTPHelper.CreatePokerSession(sessionName);
            DisplayScreen(sessionName);
        }

        public IActionResult NewSession()
        {
            return View();
        }

        public IActionResult DisplayScreen(string sessionName)
        {
            return View();
        }
        // // GET: PokerSession/Details/5
        // public async Task<IActionResult> Details(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var pokerSession = await _context.PokerSession
        //         .SingleOrDefaultAsync(m => m.ID == id);
        //     if (pokerSession == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(pokerSession);
        // }

        // // GET: PokerSession/Create
        // public IActionResult Create()
        // {
        //     return View();
        // }

        // // POST: PokerSession/Create
        // // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("Name,ID,TotalCount,Average,NumberOfVotes")] PokerSession pokerSession)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(pokerSession);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(pokerSession);
        // }

        // // GET: PokerSession/Edit/5
        // public async Task<IActionResult> Edit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var pokerSession = await _context.PokerSession.SingleOrDefaultAsync(m => m.ID == id);
        //     if (pokerSession == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(pokerSession);
        // }

        // // POST: PokerSession/Edit/5
        // // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, [Bind("Name,ID,TotalCount,Average,NumberOfVotes")] PokerSession pokerSession)
        // {
        //     if (id != pokerSession.ID)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(pokerSession);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!PokerSessionExists(pokerSession.ID))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(pokerSession);
        // }

        // // GET: PokerSession/Delete/5
        // public async Task<IActionResult> Delete(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var pokerSession = await _context.PokerSession
        //         .SingleOrDefaultAsync(m => m.ID == id);
        //     if (pokerSession == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(pokerSession);
        // }

        // // POST: PokerSession/Delete/5
        // [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> DeleteConfirmed(int id)
        // {
        //     var pokerSession = await _context.PokerSession.SingleOrDefaultAsync(m => m.Id == id);
        //     _context.PokerSession.Remove(pokerSession);
        //     await _context.SaveChangesAsync();
        //     return RedirectToAction(nameof(Index));
        // }

        // private bool PokerSessionExists(int id)
        // {
        //     return _context.PokerSession.Any(e => e.Id == id);
        // }
    }
}
