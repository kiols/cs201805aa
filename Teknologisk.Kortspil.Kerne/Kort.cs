using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Kortspil.Kerne
{
    public class Kort
    {
        public int Værdi { get; private set; }
        public KortKulør Kulør { get; private set; }

        private static System.Random rnd;

        static Kort() {
            rnd = new Random();
        }

        public Kort()
        {
            this.Værdi = rnd.Next(2, 15);
            this.Kulør = (KortKulør)rnd.Next(0, 4);
        }

        public Kort(int værdi, KortKulør kulør)
        {
            if (værdi < 2 || værdi > 14)
                værdi = 2;
            this.Værdi = værdi;
            this.Kulør = kulør;
        }

        public KortFarve Farve() {
            if (this.Kulør == KortKulør.Hjerter || this.Kulør == KortKulør.Ruder)
                return KortFarve.Rød;
            else
                return KortFarve.Sort;
        }

        public Korttype Type() {

            if (this.Værdi <= 10)
                return Korttype.Tal;
            else
                return (Korttype)this.Værdi;

        }

        public string Skriv() {
            switch (this.Kulør)
            {
                case KortKulør.Hjerter:
                    return "h" + this.Værdi;                    
                case KortKulør.Ruder:
                    return "r" + this.Værdi;
                case KortKulør.Klør:
                    return "k" + this.Værdi;
                case KortKulør.Spar:
                    return "s" + this.Værdi;
                default:
                    return "?"; // fejl....
            }
        }
    }
}
