﻿using System;
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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;

namespace e_Teretana.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TeretanaContext context;
        private Korisnik prijavljeniKorisnik;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            context = new TeretanaContext();
        }

        public IActionResult Index()
        {
            List<Novost> novosti = Teretana.getInstance().Novosti;
            ViewData["Novost1"] = novosti[novosti.Count - 1];
            ViewData["Novost2"] = novosti[novosti.Count - 2];
            ViewData["Novost3"] = novosti[novosti.Count - 3];
            ViewData["Novost4"] = novosti[novosti.Count - 4];
            ViewData["Novost5"] = novosti[novosti.Count - 5];
            ViewData["Novost6"] = novosti[novosti.Count - 6];
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
        public async Task<IActionResult> Register(string ime, string prezime, string email, string sifra, string ponovljenaSifra, IFormCollection fc)
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
                    string typeValue = Convert.ToString(fc["clanarina"]);

                    TipClanarine tipClanarine = TipClanarine.JEDNOMJESECNA;
                    if (typeValue.Equals("tromjesecna")) tipClanarine = TipClanarine.TROMJESECNA;
                    else if (typeValue.Equals("sestomjesecna")) tipClanarine = TipClanarine.SESTOMJESECNA;
                    DbKorisnik korisnik = new DbKorisnik { Ime = ime, Prezime = prezime, EMail = email, KorisnickoIme = ime + prezime, Sifra = sifra };
                    DbClan clan = new DbClan { Clanarina = tipClanarine, DatumUclanjivanja = DateTime.Now, BrojPosjeta = 0, TrenutnoPrisutan = false, DbClanID = 0 };
                    Teretana.getInstance().dodajClana(korisnik, clan);

                    MailMessage mail = new MailMessage();
                    mail.To.Add(email);
                    mail.From = new MailAddress("teretanae@gmail.com");
                    mail.Subject = "E-Teretana: Pristupni podaci";
                    string Body = "Dobrodošli u e-Teretanu! Vaše korisnicko ime je: " + ime + prezime;
                    mail.Body = Body;
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("teretanae@gmail.com", "koliko00");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    return RedirectToAction("Login");
                }
            }
            return View();

        }


        [Route("/Home")]
        [Route("~/")]
        [Route("/Home/Login")]
        [HttpPost]

        public IActionResult Login(string korisnickoIme, string sifra)
        {
            if (sifra == null || korisnickoIme == null || sifra.Count() == 0 || korisnickoIme.Count() == 0)
            {
                string poruka = "Potrebno je unijeti sva polja!";
                ViewBag.Log = poruka;

                return View();
            }

            var kk = context.Korisnik.Where(o => o.KorisnickoIme.Equals(korisnickoIme) && o.Sifra.Equals(sifra));
            if (kk.Count() == 0)
            {
                string poruka = "Pogrešni pristupni podaci!";
                ViewBag.Log = poruka;

                return View();
            }

            DbKorisnik k = context.Korisnik.Where(i => i.KorisnickoIme.Equals(korisnickoIme) && i.Sifra.Equals(sifra)).Single();

            var clan = context.Clan.Where(c => c.DbClanID.Equals(k.DbKorisnikID));

            if (clan.Count() != 0) { prijavljeniKorisnik = new Clan(k, clan.First()); return RedirectToAction("Index", new RouteValueDictionary(
                       new { controller = "Clan", action = "Index", id = k.DbKorisnikID}));
            }

            //    var trener = context.Trener.Where(t => t.DbTrenerID.Equals(k.DbKorisnikID));

            //   if (trener.Count() != 0) { prijavljeniKorisnik = new Trener(k, trener.First()); return RedirectToAction("Index"); }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
