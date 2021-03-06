﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Oprema 
    {
        private string nazivOpreme, opis;
        private TipZauzetostiOpreme tipZauzetosti;
        private bool naCekanju;
        private DateTime pocetniDatum, krajnjiDatum;
        private Clan korisnikOpreme;
        private int sifra;
        private int id;
        public Oprema(string nazivOpreme, TipZauzetostiOpreme tipZauzetosti, string opis, bool naCekanju, DateTime pocetniDatum, DateTime krajnjiDatum, Clan korisnikOpreme, int sifra)
        {
            NazivOpreme = nazivOpreme;
            TipZauzetosti = tipZauzetosti;
            Opis = opis;
            NaCekanju = naCekanju;
            PocetniDatum = pocetniDatum;
            KrajnjiDatum = krajnjiDatum;
            KorisnikOpreme = korisnikOpreme;
            Sifra = sifra;
            id = 0;
        }

        public Oprema (DbOprema dbOprema)
        {
            NazivOpreme = dbOprema.NazivOpreme;
            TipZauzetosti = dbOprema.TipZauzetosti;
            Opis = dbOprema.Opis;
            NaCekanju = dbOprema.NaCekanju;
            PocetniDatum = dbOprema.PocetniDatum;
            KrajnjiDatum = dbOprema.KrajnjiDatum;
            //KorisnikOpreme = korisnikOpreme;
            Sifra = dbOprema.Sifra;
            id = dbOprema.DbOpremaID;
        }
        public int ID { get => id; set=> id = value; }

        public string NazivOpreme { get => nazivOpreme; set => nazivOpreme = value; }
        public TipZauzetostiOpreme TipZauzetosti { get => tipZauzetosti; set => tipZauzetosti = value; }
        public string Opis { get => opis; set => opis = value; }
        public bool NaCekanju { get => naCekanju; set => naCekanju = value; }
        public DateTime PocetniDatum
        {
            get => pocetniDatum;
            set
            {
                if (TipZauzetosti.Equals(TipZauzetostiOpreme.ZAUZETO) || TipZauzetosti.Equals(TipZauzetostiOpreme.IZNAJMLJENO)) pocetniDatum = value;
            }
        }
        public DateTime KrajnjiDatum
        {
            get => krajnjiDatum;
            set
            {
                if (TipZauzetosti.Equals(TipZauzetostiOpreme.ZAUZETO) || TipZauzetosti.Equals(TipZauzetostiOpreme.IZNAJMLJENO)) krajnjiDatum = value;
            }
        }
        public Clan KorisnikOpreme
        {
            get => korisnikOpreme;
            set
            {
                if (TipZauzetosti.Equals(TipZauzetostiOpreme.ZAUZETO) || TipZauzetosti.Equals(TipZauzetostiOpreme.IZNAJMLJENO)) korisnikOpreme = value;
            }
        }
        public int Sifra { get => sifra; set => sifra = value; }

        public Oprema dajOpremu(int sifraOpreme)
        {
            return this;
        }

        public override string ToString()
        {
            return nazivOpreme + "    " + sifra + "    " + tipZauzetosti;
        }

        public override bool Equals(object obj)
        {
            if (obj is Oprema)
            {
                Oprema o = (Oprema)obj;
                return sifra == o.sifra;
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
