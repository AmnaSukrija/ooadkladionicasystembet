﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kviz.Entiteti;


namespace Kviz
{
    partial class DAL
    {
        public class DAOFactory             // Inner klasa 
        {
            // Method factory dizajn pattern
            // public enum FactoryTip { MySQL }
            // public static DAOFactory GetDAOFactory(FactoryTip tip){
            //    switch (tip)
            //    {
            //        case FactoryTip.MySQL:
            //            return new MySQLDAOFactory();
            //    }
            //}

            private static DAOFactory instanca = null;
            public static DAOFactory Instanca
            {
                get { return (instanca == null) ? instanca = new DAOFactory() : instanca; }
            }

            private DAOFactory() { }


        }
    }
}

