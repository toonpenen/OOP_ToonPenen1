using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    public class Persoon
    {
        public string Naam { get { return $"{VoorNaam} {FamilieNaam}"; } }
        public Adres Adres { get; set; }
        public string VoorNaam { get; set; }
        public string FamilieNaam { get; set; }
    }
}
