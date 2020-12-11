using OOP_ToonPenen1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1
{
    class Program
    {
        private static ReisBureau[] reisBureaus = new ReisBureau[3];
        private static Reis[] reizen = new Reis[4];
        private static Persoon[] personen = new Persoon[3];
        private static ReisReservatie[] reisReservaties = new ReisReservatie[4];



        static void Main(string[] args)
        {
            IReisBureaus();
            IPersonen();
            IReis();
            IReisReservaties();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("De Kostprijs van deze reis 1:  {0:2} Euro", reisReservaties[0], Reis.BerekenPrijs());
        }
        #region IReisBureau
        static void IReisBureaus()
        {
            reisBureaus[0] = new ReisBureau
            {
                NaamReisBureau = "Jetair",
                AdresReisBureau = new ReisBureau
                {
                    StraatReisBureau = "Hofstraat",
                    GemeenteReisBureau = "Antwerpen",
                    HuisNummerReisBureau = 186,
                    PostCodeReisBureau = 2000
                }
            };
        }
        #endregion
        #region IPersonen
        static void IPersonen()
        {
            personen[0] = new Persoon
            {
                VoorNaam = "Toon",
                FamilieNaam = "Penen",
                Adres = new Adres
                {
                    Straat = "Statiestraat",
                    Gemeente = "Beveren",
                    HuisNummer = "12",
                    PostCode = "3010"
                }
            };
        }
        #endregion
        #region IReis
        static void IReis()
        {
            reizen[0] = new Cruise(new DateTime(2020, 12, 7), new DateTime(2020, 01, 6), 0, true);
            reizen[1] = new VliegtuigVakantie(new DateTime(2020, 03, 2), new DateTime(2020, 03, 29), 0, 120);
        }
        #endregion
        #region IReisreservaties
        static void IReisReservaties()
        {
            reisReservaties[0] = new ReisReservatie(reizen[0], reisBureaus[0], personen[0]);
        }
        #endregion
    }

}