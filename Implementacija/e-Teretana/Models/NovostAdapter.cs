﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class NovostAdapter : IDodavanjeNovosti
    {
        public void dodajTreningNovost(Trening trening)
        {
            //kreira se nova novost i pozove metoda teretane za dodavanje te novosti
            Teretana.getInstance().dodajNovost(new Novost(trening.Trener.Ime + " " + trening.Trener.Prezime + "održava novi trening!", trening.Opis + "\nDatum održavanja: " + trening.DatumOdrzavanja, "", DateTime.Now)); //dodati defaultnu sliku kad dodamo bazu
        }
    }
}
