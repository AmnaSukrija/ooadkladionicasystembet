﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Clan /*: Osoba */
    {
        double IDClana;
        public Clan(double id/*, String i, String j*/)
        {
            IDClana = id;
            /*ImePrezime = i;
            JMBG = j;*/
        }
        ~Clan() { }

        public double DajIDClana
        {
            get { return IDClana; }
            set { IDClana = value; }
        }
    }

}