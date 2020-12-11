using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    public abstract class Reis
    {
        private double BASISDAGPRIJS = 40;

        private DateTime _vertrek;
        private DateTime _terugkeer;
        
        public int AantalPersonen { get; set; }

        public DateTime VertrekDatum 
        {
            get { return _vertrek; }
            set
            {
                if (value < DateTime.Now)
                {
                    Console.WriteLine("Gelieve een nieuwe vertrekdatum in te geven");
                }
                else
                {
                        _vertrek = value;
                }
            }
        }
        public DateTime TerugkeerDatum
        {
            get { return _terugkeer; }
            set
            {
                if (value < DateTime.Now)
                {
                    Console.WriteLine("Gelieve een nieuwe terugkeerdatum in te geven");
                }
                else
                {
                    _terugkeer = value;
                }
            }
        }       
        public int AantalDagen
        {
            get
            {
                AantalDagen totalDays = (TerugkeerDatum - VertrekDatum).Days;
                return totalDays.Days;
            }
        }

        public virtual double BerekenPrijs()       
        {
            return (AantalDagen * AantalPersonen * BASISDAGPRIJS);           
        }
        
        public Reis(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum)
        {
            AantalPersonen = aantalPersonen;
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
        }

        protected Reis(DateTime vertrekDatum, DateTime terugkeerDatum)        
        {
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
        }
    }
}
