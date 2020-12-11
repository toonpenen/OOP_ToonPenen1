using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    public class LogMessage
    {
       
        public int ID { get; set; } 

        private readonly string BoodSchap = "Dit is de boodschap";
        public string boodschap { get { return BoodSchap; } }

        private static readonly Random GenereerID = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (GenereerID) 
            {
                return GenereerID.Next(min, max);
            }
        }
    }
}
