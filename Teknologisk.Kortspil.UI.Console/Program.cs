using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Kortspil.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Kerne.Kort k1 = new Kerne.Kort();
            System.Console.WriteLine(k1.Skriv());
            System.Console.WriteLine(k1.Farve());
            System.Console.WriteLine(k1.Type());

            Kerne.Kort k2 = new Kerne.Kort(2, Kerne.KortKulør.Spar);
            System.Console.WriteLine(k2.Skriv());
            System.Console.WriteLine(k2.Farve());
            System.Console.WriteLine(k2.Type());



        }
    }
}

