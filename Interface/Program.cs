using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund();
            UBåd u = new UBåd();
            Bil b = new Bil();

            IDbFunktioner i;
            i = h;

            IDbFunktioner[] a = new IDbFunktioner[2];
            a[0] = h;
            a[1] = u;

            //h = null;

            foreach (var item in a)
            {
                item.Gem();
                GemObjekt(item);
            }

            Console.WriteLine();
            IDbFunktioner w = FindObjekt();
            w.Gem();


            // Afkobling...


            Bil[] garage = new Bil[3];
            garage[0] = new Bil() { Mærke = "a", Motor = 2 };
            garage[1] = new Bil() { Mærke = "c", Motor = 1 };
            garage[2] = new Bil() { Mærke = "b", Motor = 8 };

            if (garage[0] is IComparable) { }

            //System.Array.Sort(garage);

            //IComparer s = new BilSorteringMotorDesc();
            System.Array.Sort(garage, new BilSorteringMotorDesc());



        }

        static IDbFunktioner FindObjekt() {
            if (DateTime.Now.Millisecond % 2 == 0) {
                return new Hund();
            } else {
                return new UBåd();
            }
        }

        static void GemObjekt(IDbFunktioner o) {
            o.Gem();
        }
    }

    class BilSorteringMotorDesc : IComparer
    {
        public int Compare(object x, object y)
        {
            Bil b1 = x as Bil;
            Bil b2 = y as Bil;
            if (b1.Motor < b2.Motor)
                return 1;
            if (b1.Motor > b2.Motor)
                return -1;
            return 0;
        }
    }

    class BilSorteringMotorAsc : IComparer
    {
        public int Compare(object x, object y)
        {
            Bil b1 = x as Bil;
            Bil b2 = y as Bil;
            if (b1.Motor > b2.Motor)
                return 1;
            if (b1.Motor < b2.Motor)
                return -1;
            return 0;
        }
    }

    class Bil : IComparable  {
        public string Mærke { get; set; }
        public int Motor { get; set; }

        public int CompareTo(object obj)
        {
            Bil b1 = this;
            Bil b2 = obj as Bil;
            if (b1.Motor > b2.Motor)
                return 1;
            if (b1.Motor < b2.Motor)
                return -1;
            return 0;
        }
    }


    class Hund : IDbFunktioner {
        public void Gem() {
            Console.WriteLine("Gemmer hund");
        }

        public int AntalPoster() {
            return 1;
        }
        public bool DbOk(int nummer) {
            return true;
        }
    }

    class UBåd : IDbFunktioner
    {
        public int AntalPoster()
        {
            return 1;
        }

        public bool DbOk(int nummer)
        {
            return true;
        }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd");   
        }
    }

    interface IDbFunktioner {
        void Gem();
        int AntalPoster();
        bool DbOk(int nummer);
    }

    interface ISikkerhed {
        bool ErAdmn();
    }
}
