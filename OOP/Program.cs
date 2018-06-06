using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p;
            p = new Person();

            Person p2;
            p2 = p;
            p = null;

            Console.WriteLine(p2.ToString());


            //// struct...!!!
            //Dyr d;
            //d.antalBen++;

            Bil b = new Bil();
            b._antalHjul = 4;
            Console.WriteLine(b._model.ToUpper());

            Bil b2 = new Bil(4, "");


        }
    }

    struct Dyr
    {
        public int antalBen;
    }
    public class Person
    {

        public int alder;
        private bool test;

        private bool erILive() { return true; }

        public void SætVærdiTiltest(bool v)
        {
            // log
            // validering
            // sikkerhed
            this.test = v;
        }

        public bool HentVærdiFratest()
        {
            // log
            // validering
            // sikkerhed
            return this.test;
        }
        public void Test()
        {

        }
        private void Test2() { }
    }
    public class Bil
    {

        // mangler log, sikkerhed, validering...
        public int _antalHjul;
        public string _model;

        // default constructor (ingen argumenter)
        public Bil() : this(4, "")
        {

            // initialisering

            // log
            // sikkerhed
            // validering
            // kode
            //this.antalHjul = 4;
            //this.model = string.Empty;

        }

        public Bil(int antalHjul) : this(antalHjul, "")
        {
        }

        public Bil(int antalHjul, string model)
        {

            // log
            // sikkerhed
            // validering
            if (antalHjul > 8)
                antalHjul = 4;
            this._antalHjul = antalHjul;
            this._model = model;
        }
    }

    public class Skib
    {
        private readonly int motorStørrelse;
        private readonly string navn;

        public Skib()
        {
        }

        public Skib(string navn, int motorStørrelse)
        {
            this.motorStørrelse = motorStørrelse;
            this.navn = navn;
        }
    }




}
