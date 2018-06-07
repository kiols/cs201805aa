using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {

            YatzyTerning t1 = new YatzyTerning();
            Console.WriteLine(t1.ToString());

            YatzyTerning t2 = new YatzyTerning(6);
            Console.WriteLine(t2.ToString());

            for (int i = 0; i < 10; i++)
            {
                LudoTerning l1 = new LudoTerning();
                Console.WriteLine(l1.ToString());
            }

            Console.WriteLine();
            Terning t5 = new LudoTerning();
            Console.WriteLine(t5.ToString());

        }
    }

    abstract class Terning
    {
        public int Værdi { get; private set; }
        private static System.Random rnd = new Random();

        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                værdi = 1;
            this.Værdi = værdi;
        }
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);

        }
        //public virtual string Skriv() {
        //    return "[" + this.Værdi + "]";
        //}

        public override string ToString()
        {
            return "[" + this.Værdi + "]";
        }
    }

    class LudoTerning : Terning {

        public bool ErGlobus() {
            return this.Værdi == 5;
        }

        public bool ErStjerne()
        {
            return this.Værdi == 3;
        }
        public LudoTerning() : base()
        {

        }
        public LudoTerning(int værdi) : base(værdi)
        {

        }

        public override string ToString() {
            //return base.Skriv();
            if (this.ErStjerne())
                return "[S]";
            if (this.ErGlobus())
                return "[G]";

            return base.ToString();
        }
    }

    class YatzyTerning : Terning {
        public YatzyTerning() : base()
        {

        }

        public YatzyTerning(int værdi) : base(værdi)
        {

        }

    }
}
