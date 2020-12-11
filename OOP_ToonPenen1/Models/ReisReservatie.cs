using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    class ReisReservatie
    {
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public ReisBureau Reisbureau { get; set; }

        public LogMessage LogMessage { get; set; } 

        public ReisReservatie(Persoon persoon, Reis reis, ReisBureau reisBureau)
        {
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisBureau;
            LogMessage = new LogMessage();
            LoggerService.AddLogMessage(LogMessage);
        }

        public ReisReservatie(Reis reis, ReisBureau reisBureau, Persoon persoon)
        {
            Reis = reis;
            Reisbureau = reisBureau;
            Persoon = persoon;
        }
    }
}
