using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person() { Id = 1, Navn = "a" };
            p.Skriv();
            
            Instruktør i = new Instruktør() { Navn = "b", Løn = 100 };
            i.Skriv();

            Kursist k = new Kursist() { Navn = "c" };
            k.Skriv();

            HjælpeInstruktør h = new HjælpeInstruktør() { Navn = "d" };
            h.Skriv();

            

        }
    }

    public class Person
    {

        // public
        // private
        // protected

        public int Id { get; set; }
        public string Navn { get; set; }

        public void Skriv() {
            Console.WriteLine("Jeg er en person og hedder " + this.Navn);
            this.PrivatFunktion();
        }
        protected void PrivatFunktion() { }

    }

    public class Instruktør : Person {

        public double Løn { get; set; }
        public void SkrivLønSeddel() {
            
        }
    }

    public class Kursist : Person
    {

        public double KursistId { get; set; }
        public void MailTilLogin() { }
    }

    public sealed class HjælpeInstruktør : Instruktør {
        public int PraktikPeriode { get; set; }
        public void SpecielLogin() { }
    }

    //public class Elev : HjælpeInstruktør { }

    public class A {
        public A()
        {
            Console.WriteLine("Default i A");
        }
        public A(int a)
        {
            Console.WriteLine("Custom i A");
        }

        public A(int a, int b)
        {
            Console.WriteLine("Custom speciel i A");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("DefBult i B");
        }
        public B(int v) : base(v)
        {
            Console.WriteLine("Custom i B");
        }
        public B(int a, int b) : base(a,b)
        {
            Console.WriteLine("Custom speciel i A");
        }
    }

    public class C : B
    {
        public C()
        {
            Console.WriteLine("DefCult i C");
        }
        public C(int C)
        {
            Console.WriteLine("Custom i C");
        }
    }
}
