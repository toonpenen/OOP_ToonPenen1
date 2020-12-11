using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    public class ReisBureau
    {


        public string NaamReisBureau { get; set; }
        public ReisBureau AdresReisBureau { get; set; }

        public int HuisNummerReisBureau { get; set; }
        public int PostCodeReisBureau { get; set; }
        
        public string GemeenteReisBureau { get; set; }
        public string StraatReisBureau { get; set; }
    }
}
