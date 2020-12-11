using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    public class Cruise:Reis
    {
        private const double CRUISEPRIJSEXTRADAGKOST = 10;

        public bool VIP { get; set; }

        public Cruise(DateTime dateTime, DateTime dateTime1, int v, bool vIP)
        {
            VIP = vIP;
        }

        public override double BerekenPrijs()
        {
            if (VIP == true)
            {
                return base.BerekenPrijs() + ((CRUISEPRIJSEXTRADAGKOST * AantalPersonen) *1.5);
            }
            else
            {
                return base.BerekenPrijs();
            }
        }
    }
}
