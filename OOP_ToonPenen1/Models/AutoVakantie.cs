using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    public class AutoVakantie : Reis
    {
        private const double EXTRAPRIJSHUUR = 10;

        public bool EigenWagen { get; set; }


        public AutoVakantie(bool eigenWagen, DateTime vertrekDatum, DateTime terugkeerDatum) : base(vertrekDatum, terugkeerDatum)
        {
            EigenWagen = eigenWagen;
        }

        public override double BerekenPrijs()
        {
            if (EigenWagen == false)
            {
                return base.BerekenPrijs() + (EXTRAPRIJSHUUR * AantalPersonen);
            }
            else
            {
                return base.BerekenPrijs();
            }
        }
    }   
}
