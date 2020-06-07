using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using e_Teretana.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;

namespace e_Teretana.Controllers
{
    public class ClanController : Controller
    {
        private readonly TeretanaContext context;
        private Clan prijavljeniClan;

        public ClanController(TeretanaContext context)
        {
            this.context = context;
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

            var dbClan = await context.Clan
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

        [Route("/Clan/Index/{id}")]
        public IActionResult Index(int id)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();

            prijavljeniClan = new Clan(k, c);

            List <Novost> novosti = Teretana.getInstance().Novosti;
            ViewData["novosti"] = novosti;
            ViewData["username"] = prijavljeniClan.Ime;
            

            return View(k);
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
                context.Add(dbClan);
                await context.SaveChangesAsync();
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

            var dbClan = await context.Clan.FindAsync(id);
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
                    context.Update(dbClan);
                    await context.SaveChangesAsync();
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

            var dbClan = await context.Clan
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
            var dbClan = await context.Clan.FindAsync(id);
            context.Clan.Remove(dbClan);
            await  context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DbClanExists(int id)
        {
            return context.Clan.Any(e => e.DbClanID == id);
        }

     
        [Route("/Clan/Postavke/{id}")]
        public async Task<IActionResult> Postavke(int id)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();

            prijavljeniClan = new Clan(k, c);

            DateTime date = prijavljeniClan.DatumUclanjivanja;
            if (prijavljeniClan.Clanarina == TipClanarine.JEDNOMJESECNA) date = date.AddDays(30);
            else if (prijavljeniClan.Clanarina == TipClanarine.TROMJESECNA) date = date.AddDays(90);
            else if (prijavljeniClan.Clanarina == TipClanarine.SESTOMJESECNA) date =  date.AddDays(180);
            ViewData["date"] = date.Date.ToShortDateString();
            ViewData["clan"] = c;
            ViewData["username"] = prijavljeniClan.Ime;
            //ViewData["korisnik"] = k;
            return View(prijavljeniClan);
        }
        [Route("/Clan/Profil/{id}")]
        public async Task<IActionResult> Profil(int id)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();

            prijavljeniClan = new Clan(k, c);
            ViewData["clan"] = c;
            List<DbClanTrening> clanTrening = context.ClanTrening.ToList();
            List<int> treninziID = new List<int>();
            foreach (DbClanTrening dct in clanTrening)
            {
                if (dct.DbClanID == id)
                {
                    treninziID.Add(dct.DbTreningID);
                }
            }
            Dictionary<Trening, Trener> treninzi = new Dictionary<Trening,Trener>();
            List<DbTrening> treninziZaIteriranje = context.Trening.ToList();
            foreach (DbTrening t in treninziZaIteriranje)
            {
                if (treninziID.Contains(t.DbTreningID))
                {
                    treninzi.Add(new Trening(t), new Trener(context.Korisnik.Where(tr => tr.DbKorisnikID == t.DbTrenerID).FirstOrDefault()));
                    //treninzi.Add(new Trening(t));
                }
            }

            List<DbOprema> iznajmljenaOprema = context.Oprema.Where(o => o.KorisnikOpreme != null &&  o.KorisnikOpreme.DbKorisnikID == id && o.TipZauzetosti == TipZauzetostiOpreme.IZNAJMLJENO).ToList();
            List<Oprema> oprema = new List<Oprema>();

            foreach(DbOprema o in iznajmljenaOprema)
            {
                oprema.Add(new Oprema(context.Oprema.Where(x => x.DbOpremaID == o.DbOpremaID).FirstOrDefault()));
            }

            ViewData["oprema"] = oprema;
            ViewData["treninzi"] = treninzi;
            ViewData["username"] = prijavljeniClan.Ime;
            return View(prijavljeniClan);
        }

        [Route("/Clan/PrijavaTreninga/{id}")]
        public async Task<IActionResult> PrijavaTreninga(int id)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();

            prijavljeniClan = new Clan(k, c);
            ViewData["clan"] = c;
            Dictionary<Trening, Trener> treninzi = new Dictionary<Trening, Trener>();
            List<DbTrening> treninziZaIteriranje = context.Trening.ToList();
            foreach (DbTrening t in treninziZaIteriranje)
            {
                if (t.DatumOdrzavanja > new DateTime())
                {
                    System.Diagnostics.Debug.WriteLine("DB" + t.DbTreningID);
                    Trening treningNovi = new Trening(t);
                    System.Diagnostics.Debug.WriteLine("NEDB" + treningNovi.ID);
                    treninzi.Add(treningNovi, new Trener(context.Korisnik.Where(tr => tr.DbKorisnikID == t.DbTrenerID).FirstOrDefault()));
                    //treninzi.Add(new Trening(t));
                }
            }
            System.Diagnostics.Debug.WriteLine(treninzi.Count);
            ViewData["treninzi"] = treninzi;
            ViewData["username"] = prijavljeniClan.Ime;
            return View(prijavljeniClan);
        }

        [Route("/Clan/IznajmljivanjeOpreme/{id}")]
        public async Task<IActionResult> IznajmljivanjeOpreme(int id)
        {
           DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
           DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();
       
           prijavljeniClan = new Clan(k, c);
           ViewData["clan"] = c;
           List < DbOprema > opremaZaIznajmljivanje = context.Oprema.ToList();
           List<Oprema> oprema = new List<Oprema>();
       
       
           foreach (DbOprema o in opremaZaIznajmljivanje)
           {
                System.Diagnostics.Debug.WriteLine("DB" + o.DbOpremaID);
                Oprema oo = new Oprema(o);
                System.Diagnostics.Debug.WriteLine("DB" + oo.ID);
                if (o.TipZauzetosti == TipZauzetostiOpreme.SLOBODNO && context.Oprema.Where(x => x.DbOpremaID == o.DbOpremaID).FirstOrDefault() != null) { 
               oprema.Add(new Oprema(context.Oprema.Where(x => x.DbOpremaID == o.DbOpremaID).FirstOrDefault()));
           }
           }
           System.Diagnostics.Debug.WriteLine("desilo se");
           ViewData["oprema"] = oprema;
            ViewData["username"] = prijavljeniClan.Ime;
            return View(prijavljeniClan);
        }

        [Route("/Clan/ZauzimanjeOpreme/{id}")]
        public async Task<IActionResult> ZauzimanjeOpreme(int id)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();

            prijavljeniClan = new Clan(k, c);
            ViewData["clan"] = c;
            List<DbOprema> opremaZaZauzimanje = context.Oprema.ToList();
            List<Oprema> oprema = new List<Oprema>();


            foreach (DbOprema o in opremaZaZauzimanje)
            {
                System.Diagnostics.Debug.WriteLine("DB" + o.DbOpremaID);
                Oprema oo = new Oprema(o);
                System.Diagnostics.Debug.WriteLine("DB" + oo.ID);
                if (o.TipZauzetosti == TipZauzetostiOpreme.SLOBODNO && context.Oprema.Where(x => x.DbOpremaID == o.DbOpremaID).FirstOrDefault() != null)
                {
                    oprema.Add(new Oprema(context.Oprema.Where(x => x.DbOpremaID == o.DbOpremaID).FirstOrDefault()));
                }
            }
            System.Diagnostics.Debug.WriteLine("desilo se");
            ViewData["oprema"] = oprema;
            ViewData["username"] = prijavljeniClan.Ime;
            return View(prijavljeniClan);
        }

        [Route("/Clan/TreningDetalji/{id}")]
        public async Task<IActionResult> TreningDetalji(int id, int treningID)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();
            System.Diagnostics.Debug.WriteLine("primljeni id" + treningID);
            Trening trening = new Trening(context.Trening.Where(x => x.DbTreningID == treningID).FirstOrDefault());
            prijavljeniClan = new Clan(k, c);
            ViewData["clan"] = c;
            ViewData["trening"] = trening;
            ViewData["username"] = prijavljeniClan.Ime;
            return View(prijavljeniClan);
        }

        [Route("/Clan/IznajmiOpremuDetalji/{id}")]
        public async Task<IActionResult> IznajmiOpremuDetalji(int id, int opremaID)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();
            System.Diagnostics.Debug.WriteLine("primljeni id" + opremaID);
            Oprema oprema = new Oprema(context.Oprema.Where(x => x.DbOpremaID == opremaID).FirstOrDefault());
            prijavljeniClan = new Clan(k, c);
            ViewData["clan"] = c;
            ViewData["oprema"] = oprema;
            ViewData["username"] = prijavljeniClan.Ime;
            return View(prijavljeniClan);
        }

        public IActionResult IznajmiOpremu(string id, string opremaID)
        {
            System.Diagnostics.Debug.WriteLine("UPDATE.[dbo].[Oprema] SET TipZauzetosti = 1 , KorisnikOpremeDbKorisnikID = " + Int32.Parse(id) +  " WHERE DbOpremaID = " + Int32.Parse(opremaID) + "; ");
            context.Database.ExecuteSqlCommand("UPDATE.[dbo].[Oprema] SET TipZauzetosti = 1 , KorisnikOpremeDbKorisnikID = " + Int32.Parse(id) + ", KrajnjiDatum = DATEADD(day, 15, SYSDATETIME())   WHERE DbOpremaID = " + Int32.Parse(opremaID) + "; "  );
            context.SaveChanges();
            System.Diagnostics.Debug.WriteLine("DODJE DO OVOG DIJELA TU ");
            return RedirectToAction("IznajmljivanjeOpreme", new { id = Int32.Parse(id) });
        }

        [Route("/Clan/ZauzmiOpremuDetalji/{id}")]
        public async Task<IActionResult> ZauzmiOpremuDetalji(int id, int opremaID)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(id)).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(id)).First();
            System.Diagnostics.Debug.WriteLine("primljeni id" + opremaID);
            Oprema oprema = new Oprema(context.Oprema.Where(x => x.DbOpremaID == opremaID).FirstOrDefault());
            prijavljeniClan = new Clan(k, c);
            ViewData["clan"] = c;
            ViewData["oprema"] = oprema;
            ViewData["username"] = prijavljeniClan.Ime;
            return View(prijavljeniClan);
        }

        public IActionResult ZauzmiOpremu(string id, string opremaID)
        {
            System.Diagnostics.Debug.WriteLine("UPDATE.[dbo].[Oprema] SET TipZauzetosti = 2 , KorisnikOpremeDbKorisnikID = " + Int32.Parse(id) + " WHERE DbOpremaID = " + Int32.Parse(opremaID) + "; ");
            context.Database.ExecuteSqlCommand("UPDATE.[dbo].[Oprema] SET TipZauzetosti = 2 , KorisnikOpremeDbKorisnikID = " + Int32.Parse(id) + ", KrajnjiDatum = DATEADD(hour, 1, SYSDATETIME())   WHERE DbOpremaID = " + Int32.Parse(opremaID) + "; ");
            context.SaveChanges();
            System.Diagnostics.Debug.WriteLine("DODJE DO OVOG DIJELA TU ");
            return RedirectToAction("ZauzimanjeOpreme", new { id = Int32.Parse(id) });
        }


        public IActionResult PromijeniClanarinu (string id, IFormCollection fc)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(Int32.Parse(id))).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(Int32.Parse(id))).First();

            prijavljeniClan = new Clan(k, c);
            if (ModelState.IsValid)
            {
                if (Convert.ToString(fc["clanarina"]) != null)
                {
                    string typeValue = Convert.ToString(fc["clanarina"]);

                    DateTime date = prijavljeniClan.DatumUclanjivanja;
                    if (prijavljeniClan.Clanarina == TipClanarine.JEDNOMJESECNA) date = date.AddDays(30);
                    else if (prijavljeniClan.Clanarina == TipClanarine.TROMJESECNA) date = date.AddDays(90);
                    else if (prijavljeniClan.Clanarina == TipClanarine.SESTOMJESECNA) date = date.AddDays(180);

                    TipClanarine tipClanarine = TipClanarine.JEDNOMJESECNA;
                    if (typeValue.Equals("tromjesecna")) tipClanarine = TipClanarine.TROMJESECNA;  
                    else if (typeValue.Equals("sestomjesecna")) tipClanarine = TipClanarine.SESTOMJESECNA; 

                    Teretana.getInstance().promijeniAtributeKorisnika(Int32.Parse(id), new Clan(prijavljeniClan.Ime, prijavljeniClan.Prezime, prijavljeniClan.EMail, prijavljeniClan.KorisnickoIme, prijavljeniClan.Sifra, tipClanarine, date, prijavljeniClan.BrojPosjeta, prijavljeniClan.TrenutnoPrisutan, prijavljeniClan.PlanIshrane));
                    
                }
            }
            return RedirectToAction("Postavke", new { id = Int32.Parse(id) });
        }

        public IActionResult PrijavaNaTrening(string id, string treningID)
        {
            //DbClan clan = context.Clan.Where(x => x.DbClanID == Int32.Parse(id)).FirstOrDefault();
            //DbTrening trening = context.Trening.Where(x => x.DbTreningID == Int32.Parse(treningID)).FirstOrDefault();
            DbClanTrening prijavaClanaNaTrening= new DbClanTrening(Int32.Parse(id), Int32.Parse(treningID));
            context.ClanTrening.Add(prijavaClanaNaTrening);
            context.SaveChanges();
            System.Diagnostics.Debug.WriteLine("DODJE DO OVOG DIJELA TU ");
            return RedirectToAction("Index", new { id = Int32.Parse(id) });
        }

        [HttpPost]
        public IActionResult Promijeni(string id, string ime, string prezime, string email, string sifra, string ponovljenaSifra)
        {
            DbKorisnik k = context.Korisnik.Where(o => o.DbKorisnikID.Equals(Int32.Parse(id))).First();
            DbClan c = context.Clan.Where(o => o.DbClanID.Equals(Int32.Parse(id))).First();

            prijavljeniClan = new Clan(k, c);
            if (ime == null || prezime == null || sifra == null || ponovljenaSifra == null || email == null)
            {
                string poruka = "Potrebno je popuniti sva polja!";
                ViewBag.Podaci = poruka;
                return View();
            }

            if (!ponovljenaSifra.Equals(sifra))
            {
                string poruka = "Šifre nisu jednake!";
                ViewBag.Podaci = poruka;
                return View();
            }


            var korisnici = context.Korisnik.Where(o => o.EMail.Equals(email));
            if (korisnici.Count() != 0 && email!=prijavljeniClan.EMail)
            {
                string poruka = "Već postoji račun sa navedenom email adresom!";
                ViewBag.Podaci = poruka;
                return View();
            }
            System.Diagnostics.Debug.WriteLine(prijavljeniClan.Ime + " - " + ime);
            Teretana.getInstance().promijeniAtributeKorisnika(Int32.Parse(id), new Clan(ime, prezime, email, prijavljeniClan.KorisnickoIme, sifra, prijavljeniClan.Clanarina, prijavljeniClan.DatumUclanjivanja,prijavljeniClan.BrojPosjeta,prijavljeniClan.TrenutnoPrisutan,prijavljeniClan.PlanIshrane));

            return RedirectToAction("Postavke", new { id = Int32.Parse(id) });
        }

    }
}
