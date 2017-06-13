using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakFirma
{
    public class Sef : Radnik
    {
        private int brRadnika;
        private Radnik[] podredjeni;
        

        public Sef(string ime, double procenat, int maxBrRadnika) : base(ime, procenat)
        {
            podredjeni = new Radnik[maxBrRadnika];

        }
        public override double Prihod()
        {
            double p = 0;
            foreach (Radnik r in podredjeni)
            {
                p += r.Prihod();
            }
            return p;
        }
        public bool DodelaRadnika(Radnik r)
        {
            
            if (brRadnika < podredjeni.Length)
            {
                podredjeni[brRadnika] = r;
                brRadnika++;

                return true;
            }
            else
            { 
                return false;
            }

        }


    }
}
