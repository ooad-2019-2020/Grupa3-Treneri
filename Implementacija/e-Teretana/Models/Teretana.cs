﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Teretana
    {
        private Admin admin;
        private Dictionary<Clan, string> racuniClanova;
        private List<Clan> clanovi;
        private List<Korisnik> zaposleni;
        private Dictionary<int, Clan> zahtjeviZaIznajmljivanje;
        private List<Trening> aktivniTreninzi, prosliTreninzi;
        private List<Novost> novosti = new List<Novost>();
        private ProxyOprema oprema;

        private TeretanaContext context;

        private static Teretana uniqueInstance;
        private Teretana() {
            using (var db = new TeretanaContext()) { 
                List<DbNovost> novosti2 = db.Novost.ToList(); 
                foreach(DbNovost n in novosti2)
                {
                    novosti.Add(new Novost(n));
                }
                clanovi = new List<Clan>();
                context = new TeretanaContext();
            }

        }
        public Admin Admin { get => admin; set => admin=value; }
        public Dictionary<Clan, string> RacuniClanova { get => racuniClanova; set => racuniClanova=value; }
        public List<Clan> Clanovi { get => clanovi; set => clanovi=value; }
        public ProxyOprema Oprema { get => oprema; set => oprema=value; }
        public List<Korisnik> Zaposleni { get => zaposleni; set => zaposleni=value; }
        public Dictionary<int, Clan> ZahtjeviZaIznajmljivanje { get => zahtjeviZaIznajmljivanje; set => zahtjeviZaIznajmljivanje=value; }
        public List<Trening> AktivniTreninzi { get => aktivniTreninzi; set => aktivniTreninzi=value; }
        public List<Trening> ProsliTreninzi { get => prosliTreninzi; set => prosliTreninzi=value; }
        public List<Novost> Novosti { get => novosti; set => novosti=value; }

        public static Teretana getInstance()
        {
            if (uniqueInstance == null) uniqueInstance = new Teretana();
            return uniqueInstance;
        }
        public static void removeInstance()
        {
            if (uniqueInstance == null) return;
            uniqueInstance = null;
        }

        public List<String> dajSlobodnuOpremu()
        {
            return oprema.dajIzvjestaj(TipZauzetostiOpreme.SLOBODNO);
        }
        public List<String> dajIznajmljenuOpremu()
        {
            return oprema.dajIzvjestaj(TipZauzetostiOpreme.IZNAJMLJENO);
        }
        public List<String> dajOpremuKojaSeKoristi()
        {
            return oprema.dajIzvjestaj(TipZauzetostiOpreme.ZAUZETO);
        }
        public List<String> dajIzvjestajZaOpremu()
        {
            return oprema.dajIzvjestaj();
        }
        public List<String> dajIznajmljenuOpremuZaClana (Clan clan)
        {
            return oprema.dajIzvjestajZaClana(clan);
        }
        public List<Trening> dajAktivneTreningeZaClana (Clan clan)
        {
            return aktivniTreninzi.FindAll(trening => trening.PrijavljeniClanovi.Contains(clan));
        }
        public List<Trening> dajProsleTreningeZaClana (Clan clan)
        {
            return prosliTreninzi.FindAll(trening => trening.PrijavljeniClanovi.Contains(clan));
        }
        public List<Trening> dajAktivneTreningeZaTrenera(Trener trener)
        {
            return aktivniTreninzi.FindAll(trening => trening.Trener.Equals(trener));
        }
        public List<Trening> dajProsleTreningeZaTrenera(Trener trener)
        {
            return prosliTreninzi.FindAll(trening => trening.Trener.Equals(trener));
        }
        public void iznajmiOpremu (Clan clan, int sifra)
        {
            zahtjeviZaIznajmljivanje.Add(sifra, clan);
            oprema.pristupi(clan, false);
            Oprema o = oprema.dajOpremu(sifra);
            o.NaCekanju = true;
        }

        public void odobriIznajmljivanje(Clan clan, int sifra)
        {
            if (zahtjeviZaIznajmljivanje.ContainsKey(sifra))
            {
                zahtjeviZaIznajmljivanje.Remove(sifra);
            }
            oprema.pristupi(clan, false);
            Oprema o = oprema.dajOpremu(sifra);
            o.TipZauzetosti = TipZauzetostiOpreme.IZNAJMLJENO;
            o.KorisnikOpreme = clan;
            o.PocetniDatum = DateTime.Now;
            o.PocetniDatum = DateTime.Now.AddDays(15);
        }
        public void zauzmiOpremu (Clan clan, int sifra)
        {
            oprema.pristupi(clan, true);
            Oprema o = oprema.dajOpremu(sifra);
            o.TipZauzetosti = TipZauzetostiOpreme.ZAUZETO;
            o.KorisnikOpreme = clan;
            o.PocetniDatum = DateTime.Now;
            o.PocetniDatum = DateTime.Now.AddHours(2);
        }
        public void oslobodiOpremu(Clan clan, int sifra)
        {
            oprema.pristupi(clan, false);
            Oprema o = oprema.dajOpremu(sifra);
            o.KorisnikOpreme = null;
            o.PocetniDatum = DateTime.Now;
            o.PocetniDatum = DateTime.Now;
            o.TipZauzetosti = TipZauzetostiOpreme.SLOBODNO;
        }
        public void dodajTrening (Trening trening)
        {
            AktivniTreninzi.Add(trening);
        }
        public void osvjeziTreninge()
        {
            foreach(Trening a in aktivniTreninzi)
            {
                if (a.DatumOdrzavanja < DateTime.Now)
                {
                    prosliTreninzi.Add(a);
                    aktivniTreninzi.Remove(a);
                }
            }
        }
        public void prijaviClanaNaTrening (Clan clan, Trening trening)
        {
        }
        public List<Trening> dajDanasnjeTreninge()
        {
            List<Trening> danasnjiTreninzi = new List<Trening>();
            foreach(Trening t in aktivniTreninzi)
            {
                if (t.DatumOdrzavanja.Date.DayOfYear == DateTime.Now.Date.DayOfYear && t.DatumOdrzavanja.Date.Year == DateTime.Now.Date.Year)
                {
                    danasnjiTreninzi.Add(t);
                }
            }
            return danasnjiTreninzi;
        }
        public void posaljiPristupnePodatke (Korisnik korisnik)
        {
            //bice kul
        }
        public void evidentirajClana (Clan clan, bool prijava)
        {
            clan.TrenutnoPrisutan = prijava;
            if (prijava)
            {
                clan.BrojPosjeta += 1;
            }
        }
        public List<Clan> dajPrisutneClanove()
        {
            List<Clan> prisutniClanovi = new List<Clan>();
            foreach (Clan c in clanovi)
            {
                if (c.TrenutnoPrisutan)
                {
                    prisutniClanovi.Add(c);
                }
            }
            return prisutniClanovi;
        }
        public List<Clan> dajOdsutneClanove()
        {
            List<Clan> prisutniClanovi = new List<Clan>();
            foreach (Clan c in clanovi)
            {
                if (!c.TrenutnoPrisutan)
                {
                    prisutniClanovi.Add(c);
                }
            }
            return prisutniClanovi;
        }
        public void ukloniKorisnika (Korisnik korisnik)
        {
            if (korisnik is Clan) 
            {
                if (clanovi.Contains((Clan)korisnik))
                {
                    clanovi.Remove((Clan)korisnik);
                }
            }else
            {
                if (zaposleni.Contains(korisnik))
                {
                    zaposleni.Remove(korisnik);
                }
            }
        }
        public void promijeniAtributeKorisnika (int id, Korisnik noviKorisnik)
        {
            //System.Diagnostics.Debug.WriteLine(stariKorisnik.Ime + " - " + noviKorisnik.Ime);
            context.Database.OpenConnection();
            try
            {
                if (noviKorisnik is Clan)
                {
                    int tip = 0;
                    if(((Clan)noviKorisnik).Clanarina == TipClanarine.TROMJESECNA)
                    {
                        tip = 1;
                    }else if (((Clan)noviKorisnik).Clanarina == TipClanarine.SESTOMJESECNA)
                    {
                        tip = 2;
                    }
                    //context.Korisnik.Find()
                    //System.Diagnostics.Debug.WriteLine(stariKorisnik.KorisnickoIme + " - " + noviKorisnik.KorisnickoIme);
                    System.Diagnostics.Debug.WriteLine("UPDATE Clan SET Clanarina = '" + ((Clan)noviKorisnik).Clanarina + "' WHERE DbCLanID = " + id + "; ");
                    context.Database.ExecuteSqlCommand("UPDATE Clan SET Clanarina = " + tip + " WHERE DbCLanID = " + id + "; ");
                    context.SaveChanges();
                }
                //System.Diagnostics.Debug.WriteLine(stariKorisnik.KorisnickoIme + " - " + noviKorisnik.KorisnickoIme);
                context.Database.ExecuteSqlCommand("UPDATE Korisnik SET Ime = '" + noviKorisnik.Ime + "', Prezime = '" + noviKorisnik.Prezime + "', EMail = '" + noviKorisnik.EMail + "', Sifra = '" + noviKorisnik.Sifra + "' WHERE DbKorisnikID = '" + id + "'; ");
                context.SaveChanges();
                
            }
            finally
            {
                context.Database.CloseConnection();
            }
            //stariKorisnik.Ime = noviKorisnik.Ime;
            //stariKorisnik.Prezime = noviKorisnik.Prezime;
            //stariKorisnik.EMail = noviKorisnik.EMail;
            //stariKorisnik.Sifra = noviKorisnik.Sifra;
        }
        public void dodajRacun (Clan clan, string racun)
        {
            racuniClanova.Add(clan, racun);
        }
        public string dajRacunZaClana (Clan clan)
        {
            return RacuniClanova[clan];
        }
        public void dodajNovost (Novost novost)
        {
            novosti.Add(novost);
        }
        public void ocijeniTrenera (Trener trener, int ocjena, DateTime datum)
        {
        }
        public void dodajClana(DbKorisnik korisnik, DbClan clan)
        {
            context.Korisnik.Add(korisnik);
            context.SaveChanges();

            var kk = context.Korisnik.Where(o => o.EMail.Equals(korisnik.EMail));

            clan.DbClanID = kk.FirstOrDefault().DbKorisnikID;

            context.Database.OpenConnection();
            try
            {
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Clan ON");

                context.Clan.Add(clan);
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Clan OFF");
                clanovi.Add(new Clan(korisnik, clan));
            }
            finally
            {
                context.Database.CloseConnection();
            }

        }
        

        }

    }

