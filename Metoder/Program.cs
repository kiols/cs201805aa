using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Statiske metoder
            Metode1();
            Metode2(6, "a");
            int a = 1;
            string b = "b";
            Metode2(a, b);
            Metode3(5);
            int res = Metode3(5);
            Console.WriteLine(res);
            Console.WriteLine(Metode3(6));

            // instans
            Person p1 = new Person();
            p1.Alder = 100;
            p1.Skriv();

            Metode1();

            MinReturVærdi r = Metode4(7);


            int c = 100;
            Metode5(c);

            Person aa = new Person();
            aa.Alder = 10;
            Metode6(aa);

            int u = 100;
            Metode7(ref u);


            Metode8(ref aa);

            int[] t = { 5, 10, 1, 2, 50, 3, 0, 8 };

            int mi = FindMindsteTal(t);

            Metode9(1, 5, 1, 74, 6, 56, 1);

            Metode10(1, true);
            Metode10(1);
            Metode10();

            int ts = Metode11(false);
        }

        static void Metode1()
        {

            if (true)
                return;

            // kode...

            if (true)
                return;


            // kode

        }
        static void Metode2(int i, string x)
        {
            Console.WriteLine(i);
            Console.WriteLine(x);

        }

        static int Metode3(int i)
        {
            int y = 100;

            Console.WriteLine(i);
            return i * 2 + y;

        }

        static MinReturVærdi Metode4(int i)
        {
            // kode

            MinReturVærdi v = new MinReturVærdi();
            v.ErOk = true;
            v.Navn = "a";
            v.Værdi = 10;
            return v;

            
        }

        static void Metode5(int a)  // by value
        {
            // kode

            a++;

            return;

        }

        static void Metode6(Person a)  // by refence
        {
            // kode

            a.Alder = 9090909;



        }

        static void Metode7(ref int a)
        {
            // kode
            a++;


        }

        static void Metode8(ref Person a)
        {
            a = new Person();
            a.Alder = 99;
        }

        static int FindMindsteTal(int[] tal)
        {
            int[] tmp = (int[])tal.Clone();
            System.Array.Sort(tmp);
            return tmp[0];
        }

        static void Metode9(params int[] værdier)
        {

        }

        static void Metode10(int a = 10, bool b = false)
        {

        }

        static void Metode11()
        {

        }
        static void Metode11(int a)
        {

        }

        static void Metode11(string g)
        {

        }

        static int Metode11(bool v)
        {
            return 0;
        }



    }
}
