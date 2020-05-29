using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using e_Teretana.Models;

namespace e_Teretana.Controllers
{
    public class ClanController : Controller
    {
        private readonly TeretanaContext _context;

        public ClanController(TeretanaContext context)
        {
            _context = context;
        }

        // GET: Clan
   //     public async Task<IActionResult> Index()
   //     {
   //         return View(await _context.Clan.ToListAsync());
   //     }


        // GET: Clan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbClan = await _context.Clan
                .FirstOrDefaultAsync(m => m.DbClanID == id);
            if (dbClan == null)
            {
                return NotFound();
            }

            return View(dbClan);
        }

        // GET: Clan/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<Novost> novosti = Teretana.getInstance().Novosti;
            ViewData["Novost1"] = novosti[0];
            ViewData["Novost2"] = novosti[1];
            ViewData["Novost3"] = novosti[2];
            ViewData["Novost4"] = novosti[0];
            ViewData["Novost5"] = novosti[1];
            ViewData["Novost6"] = novosti[2];
            ViewData["Novost7"] = novosti[0];
            ViewData["Novost8"] = novosti[1];
            ViewData["Novost9"] = novosti[2];
            ViewData["Novost10"] = novosti[0];
       
            return View();
        }

        // POST: Clan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Clanarina,DatumUclanjivanja,BrojPosjeta,TrenutnoPrisutan")] DbClan dbClan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dbClan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dbClan);
        }

        // GET: Clan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbClan = await _context.Clan.FindAsync(id);
            if (dbClan == null)
            {
                return NotFound();
            }
            return View(dbClan);
        }

        // POST: Clan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Clanarina,DatumUclanjivanja,BrojPosjeta,TrenutnoPrisutan")] DbClan dbClan)
        {
            if (id != dbClan.DbClanID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dbClan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DbClanExists(dbClan.DbClanID))
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
            return View(dbClan);
        }

        // GET: Clan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbClan = await _context.Clan
                .FirstOrDefaultAsync(m => m.DbClanID == id);
            if (dbClan == null)
            {
                return NotFound();
            }

            return View(dbClan);
        }

        // POST: Clan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dbClan = await _context.Clan.FindAsync(id);
            _context.Clan.Remove(dbClan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DbClanExists(int id)
        {
            return _context.Clan.Any(e => e.DbClanID == id);
        }

        public async Task<IActionResult> Postavke()
        {
            return View();
        }

        public IActionResult Profil()
        {
            return View();
        }
    }
}
