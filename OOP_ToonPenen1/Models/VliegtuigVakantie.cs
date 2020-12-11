using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    public class VliegtuigVakantie : Reis
    {
        private double VliegtuigTicketPrijs { get; set;}

        public VliegtuigVakantie(DateTime dateTime, double vliegtuigTicket, DateTime vertrekDatum, DateTime terugkeerDatum, double vliegtuigTicketPrijs) : base(vertrekDatum, terugkeerDatum)
        {
            VliegtuigTicketPrijs = vliegtuigTicketPrijs;
        }

        public override double BerekenPrijs()
        {
            return base.BerekenPrijs();
        }

    }
}
