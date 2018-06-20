using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimerTest();

            //IOTest();

            Hund h = new Hund("x");
            h.NavnRettet += (s, e) =>
            {   
                Console.WriteLine("navn må rettet fra " + e.GammelNavn + " til " + e.NytNavn);
            };
            h.Navn = "b";
            h.Navn = "c";
            h.Navn = "c";


            
        }

        private static void IOTest()
        {
            System.IO.FileSystemWatcher f = new System.IO.FileSystemWatcher(@"c:\temp");
            f.EnableRaisingEvents = true;
            f.Created += (s, e) => { Console.WriteLine("Fil oprettet " + e.FullPath); };
            f.Deleted += (w, q) => { Console.WriteLine("Fil slettet " + q.FullPath); };
            do
            {

            } while (true);
        }

        private static void TimerTest()
        {
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 500;
            t.Enabled = true;
            //t.Elapsed += Tick;
            t.Elapsed += (s, e) => { Console.WriteLine("Tick " + e.SignalTime); };
            do
            {

            } while (true);
        }

        private static void Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Tick " + e.SignalTime);
        }
    }

    class Hund
    {
        //public event EventHandler NavnRettet;
        public event EventHandler<NavnRettetEventArgs> NavnRettet;

        private string _navn;

        public string Navn
        {
            get { return _navn; }
            set
            {
                if (NavnRettet != null)
                    NavnRettet(this, new NavnRettetEventArgs() { GammelNavn = this._navn, NytNavn = value });
                _navn = value;
            }
        }


        public Hund(string navn)
        {
            this.Navn = navn;
        }
    }

    class NavnRettetEventArgs : EventArgs {
        public string GammelNavn { get; set; }
        public string NytNavn { get; set; }
    }
}
