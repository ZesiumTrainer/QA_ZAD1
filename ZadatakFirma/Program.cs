using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakFirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Sef s = new Sef("Era", 12, 3);
            Prodavac p1 = new Prodavac("a", 20);
            p1.Prodaj(1000);
            Prodavac p2 = new Prodavac("a", 20);
            p2.Prodaj(2000);
            Prodavac p3 = new Prodavac("a", 20);
            p3.Prodaj(3000);
            s.DodelaRadnika(p1);
            s.DodelaRadnika(p2);
            s.DodelaRadnika(p3);

            var x = s.Prihod();
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}
