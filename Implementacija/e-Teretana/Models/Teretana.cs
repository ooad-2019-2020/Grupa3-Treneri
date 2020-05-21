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
        private Teretana uniqueInstance;
        private Teretana() { }
        public Admin Admin { get; set; }
        public Dictionary<Clan, string> RacuniClanova { get; set; }
        public List<Clan> Clanovi { get; set; }
        public ProxyOprema Oprema { get; set; }
        public List<Korisnik> Zaposleni { get; set; }
        public Dictionary<Clan, int> ZahtjeviZaIznajmljivanje { get; set; }
        public List<Trening> AktivniTreninzi { get; set; }
        public List<Trening> ProsliTreninzi { get; set; }
        public List<Novost> Novosti { get; set; }

        public Teretana getInstance()
        {
            if (uniqueInstance == null) uniqueInstance = new Teretana();
            return uniqueInstance;
        }
        public List<String> dajSlobodnuOpremu()
        {
            return null;
        }
        public List<String> dajIznajmljenuOpremu()
        {
            return null; 
        }
        public List<String> dajOpremuKojaSeKoristi()
        {
            return null;
        }
        public List<String> dajIzvjestajZaOpremu()
        {
            return null;
        }
        public List<String> dajIznajmljenuOpremuZaClana (Clan clan)
        {
            return null;
        }
        public List<Trening> dajAktivneTreningeZaClana (Clan clan)
        {
            return null;
        }
        public List<Trening> dajProsleTreningeZaClana (Clan clan)
        {
            return null;
        }
        public List<Trening> dajAktivneTreningeZaTrenera(Trener trener)
        {
            return null;
        }
        public List<Trening> dajProsleTreningeZaTrenera(Trener trener)
        {
            return null;
        }
        public void iznajmiOpremu (Clan clan, int sifra)
        {

        }
        public void zauzmiOpremu (Clan clan, int sifra)
        {

        }
        public void oslobodiOpremu(Clan clan, int sifra)
        {

        }
        public void dodajTrening (Trening trening)
        {
            AktivniTreninzi.Add(trening);
        }
        public void osvjeziTreninge()
        {

        }
        public void prijaviClanaNaTrening (Clan clan, Trening trening)
        {
            trening.prijaviClana(clan);
        }
        public List<Trening> dajDanasnjeTreninge()
        {
            return null;
        }
        public void posaljiPristupnePodatke (Korisnik korisnik)
        {

        }
        public void evidentirajClana (Clan clan, bool prijava)
        {

        }
        public List<Clan> dajPrisutneClanove()
        {
            return null;
        }
        public List<Clan> dajOdsutneClanove()
        {
            return null;
        }
        public void ukloniKorisnika (Korisnik korisnik)
        {

        }
        public void promijeniAtributeKorisnika (Korisnik stariKorisnik, Korisnik noviKorisnik)
        {

        }
        public void dodajRacun (Clan clan, string racun)
        {

        }
        public string dajRacunZaClana (Clan clan)
        {
            return RacuniClanova[clan];
        }
        public void dodajNovost (Novost novost)
        {

        }
        public void ocijeniTrenera (Trener trener, int ocjena, DateTime datum)
        {
            trener.dodajOcjenu(ocjena, datum);
        }

    }
}
