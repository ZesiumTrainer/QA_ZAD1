using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakFirma
{
    
    public class Prodavac : Radnik
    {
        private int prodataRoba { get; set; }

        public Prodavac(string ime, double procenat) : base(ime, procenat)
        {
        }

        public override double Prihod()
        {
            return prodataRoba;
        }
        public int Prodaj(int roba)
        {
            return this.prodataRoba += roba;
        }
    }
}
