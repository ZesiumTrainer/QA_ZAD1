using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakFirma
{
    public abstract class Radnik
    {
        
        private string Ime { get; set; }
        private double Procenat { get; set; }

        public Radnik(string ime, double procenat)
        {
            this.Ime = ime;
            this.Procenat = procenat;
        }
        public abstract double Prihod();
  
        public double Plata()
        {
            return Prihod() * Procenat/ 100;
        }
        public String Stampaj()
        {
            return "Ime: " + Ime + " / " + Plata();
        }
    }
}
