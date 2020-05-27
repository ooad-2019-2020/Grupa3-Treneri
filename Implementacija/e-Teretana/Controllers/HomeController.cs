using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using e_Teretana.Models;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace e_Teretana.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TeretanaContext context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            context = new TeretanaContext();
        }

        public IActionResult Index()
        {
            List<Novost> novosti = Teretana.getInstance().Novosti;
            ViewData["Novost1"] = novosti[0];
            ViewData["Novost2"] = novosti[1];
            ViewData["Novost3"] = novosti[2];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string ime, string prezime, string email, string sifra, string ponovljenaSifra, IFormCollection fc)
        {
          
            if (ime == null || prezime == null || sifra == null || ponovljenaSifra == null || email == null)
            {
                string poruka = "Potrebno je popuniti sva polja!";
                ViewBag.Registracija = poruka;
                return View();
            }

            if (!ponovljenaSifra.Equals(sifra))
            {
                string poruka = "Šifre nisu jednake!";
                ViewBag.Registracija = poruka;
                return View();
            }

        
            var k = context.Korisnik.Where(o => o.EMail.Equals(email));
            if (k.Count() != 0)
            {
                string poruka = "Već postoji račun sa navedenom email adresom!";
                ViewBag.Registracija = poruka;
                return View();
            }

            if (ModelState.IsValid)
            {
                if (Convert.ToString(fc["clanarina"]) != null)
                {
                    string radiovalue = Convert.ToString(fc["clanarina"]);

                    var korisnik = new DbKorisnik { Ime = ime, Prezime = prezime, EMail = email, KorisnickoIme = ime + prezime, Sifra = sifra };

                    context.Korisnik.Add(korisnik);
                    context.SaveChanges();

                    var kk = context.Korisnik.Where(o => o.EMail.Equals(email));

                    var clan = new DbClan { Clanarina = TipClanarine.JEDNOMJESECNA, DatumUclanjivanja = DateTime.Now, BrojPosjeta = 0, TrenutnoPrisutan = false, DbClanID = kk.FirstOrDefault().DbKorisnikID };


                    
                    context.Clan.Add(clan);
                    context.SaveChanges();
                    return RedirectToAction("Login");
                }
            }
            return View();

        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
