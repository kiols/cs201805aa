using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITilfældighedsGenerator r = new TilfældighedsGeneratorMock();
            ITilfældighedsGenerator r = TilfældighedsGeneratorHjælper.FindGenerator();
            Terning t = new Terning(r);
            Console.WriteLine(t);

        }
    }

    class Terning
    {
        public int Værdi { get; private set; }
        private ITilfældighedsGenerator rnd;

        public Terning(ITilfældighedsGenerator i)
        {
            this.rnd = i;
            Ryst();
        }

        public Terning(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                throw new ApplicationException("Forkert værdi på terning");
            this.Værdi = værdi;
        }
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);

        }

        public override string ToString()
        {
            return "[" + this.Værdi + "]";
        }
    }

    interface ITilfældighedsGenerator
    {
        int Next(int min, int max);
    }

    static class TilfældighedsGeneratorHjælper
    {
        public static ITilfældighedsGenerator FindGenerator()
        {
            //if(DateTime.Now.Millisecond%2==0)
            //    return new TilfældighedsGeneratorMock();
            //else
            //    return new TilfældighedsGeneratorSystemRandom();

            string v = System.Configuration.ConfigurationManager.AppSettings["generator"];

            if (v == "mock")
                return new TilfældighedsGeneratorMock();
            else if (v == "random")
                return new TilfældighedsGeneratorSystemRandom();
            else
                throw new ApplicationException("Forkert generator");
        }


    }

    class TilfældighedsGeneratorSystemRandom : ITilfældighedsGenerator
    {
        private static System.Random rnd = new Random();

        public int Next(int min, int max)
        {
            return rnd.Next(min, max);
        }
    }

    class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {


        public int Next(int min, int max)
        {
            return 6;
        }
    }

    // Gammel terning
    class Terning2
    {
        public int Værdi { get; private set; }
        // hmmmmm - vi bundet System.Random
        private static System.Random rnd = new Random();

        public Terning2()
        {
            Ryst();
        }

        public Terning2(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                throw new ApplicationException("Forkert værdi på terning");
            this.Værdi = værdi;
        }
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);

        }

        public override string ToString()
        {
            return "[" + this.Værdi + "]";
        }
    }
}
