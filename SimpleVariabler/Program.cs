using System;
using System.Linq;


namespace SimpleVariabler
{
    class Program
    {
        static void Main(string[] args)
        {



            System.Int32 i = 1;
            string t = i.ToString();
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            int ii;
            ii = 100;

            System.Boolean b = false;
            bool bb = false;

            // kommatal
            double d = 0;
            Console.WriteLine(d);
            System.Double dd;
            d = 343454.983593879379854;
            Console.WriteLine(d.ToString("N2"));

            System.DateTime da;
            da = System.DateTime.Now;
            Console.WriteLine(da.ToString("dddd"));

            // Dato beregninger
            System.DateTime d1 = System.DateTime.Now;
            System.DateTime d2 = new DateTime(2018, 12, 24);
            System.TimeSpan ts = d2.Subtract(d1);
            Console.WriteLine(ts.TotalDays.ToString());


            System.DateTime d3 = System.DateTime.Now.AddMonths(1);

            System.TimeSpan ts2 = new TimeSpan(15, 00, 00);
            System.TimeSpan ts3 = new TimeSpan(17, 00, 00);
            ts2 = ts2.Add(new TimeSpan(0, 20, 10));
            Console.WriteLine(ts2 > ts3);



            const int antalMåneder = 12;
            //antalMåneder = 11;

            const double momsPct = 0.25;    // xlm config, settings

            int q = 1;
            q++;
            
            q += 2;
            q *= 2;
            //q -= 8;
            q = q - 8;

            if (DateTime.Now.Millisecond % 2 == 0) {
                // lige
            } else {
                // ulige
            }

            // Hund d = new Hund();

            int a = 500000000;
            //checked
            //{
            //    short z = (short)a;
            //}

//            short z = System.Convert.ToInt16(a);
  //          short z2 = System.Convert.ToInt16("7575757");

            var x = "888";

            var navn = "mikkel";

            int[] tal = { 4, 2, 4, 10, 5, 7, 10, 6, 2 };
            var tal2 = tal.Where(s => s < 10).OrderBy(s => s).GroupBy(s => s);

            int antalm = 12;



            string personNavn = "Mikkel";
            //int personKøn = 1;  // 1 = mand, 0 = kvinde
            PersonKøn personKøn = PersonKøn.Kvinde;
            Console.WriteLine((int)personKøn);

            KortFarve k = KortFarve.Klør;

            switch (k)
            {
                case KortFarve.Spar:
                    break;
                case KortFarve.Hjerter:
                    break;
                case KortFarve.Ruder:
                    break;
                case KortFarve.Klør:
                    break;
                default:
                    break;
            }

            DayOfWeek d6 = DayOfWeek.Monday;
            switch (d6)
            {
                case DayOfWeek.Sunday:

                    break;
                case DayOfWeek.Monday:

                    break;
                case DayOfWeek.Tuesday:

                    break;
                case DayOfWeek.Wednesday:



                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }


            int Person1Alder = 20;
            string Person1Navn = "a";

            int Person2Alder = 50;
            string Person2Navn = "b";

            
            Person p1;
            //p1.Alder++;
            p1.Alder = 10;
            p1.Navn = "a";

            // initialiseret til default
            Person p2 = new Person();
            p2.Alder++;
            p2.Alder = 30;
            p2.Navn = "b";

        }
    }

    class Hund { }

    enum PersonKøn
    {
        Mand,
        Kvinde
    }

    enum KortFarve {
        Spar, Hjerter, Ruder, Klør
    }

    struct Person {

        public int Alder;
        public string Navn;

    }


}
