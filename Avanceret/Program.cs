using System;
using System.Collections.Generic;
using System.Linq;
using cronberg;
namespace Avanceret
{
    class Program
    {
        static void Main(string[] args)
        {

            bool? i = null;
            if (i == null) { } else { }
            if (i.HasValue) { }

            double? o = null;

            string b = "*";
            string t = "a " + b + " !";
            double u = 33982.324;
            string l = $"a {b} ! {5 + 14 / 2}  = {u:N2}";
            Console.WriteLine(l);

            List<int> iw = new List<int>();
            string navn = "miKkEl";
            Console.WriteLine(cronberg.StringHelper.ProperString(navn));
            Console.WriteLine(navn.ProperString());

            var a = new { Navn = "a", Alder = 13 };

            Test(a);

            Hund h1 = new Hund() { Alder = 10 };
            Hund h2 = new Hund() { Alder = 20 };
            if (h1 > h2) {

            } else {

            }
            //h1.Gø();

            //h1.GetType().GetCustomAttributes


        }

        public static void Test(dynamic tmp) {
            Console.WriteLine(tmp.Navn);
        }
    }

    [Serializable]
    class Hund {

        public string Navn { get; set; }
        public int Alder { get; set; }

        public static bool operator >(Hund h1, Hund h2) {
            return h1.Alder > h2.Alder;
        }
        public static bool operator <(Hund h1, Hund h2)
        {
            return h1.Alder < h2.Alder;
        }

        [Obsolete("Brug istedet...", true)]
        public void Gø() { }

    }
}

namespace cronberg
{
    public static class StringHelper
    {

        public static string ProperString(this string txt)
        {
            string t = txt.ToLower();
            return txt.Substring(0, 1).ToUpper() + t.Substring(1);
        }
    }
}
