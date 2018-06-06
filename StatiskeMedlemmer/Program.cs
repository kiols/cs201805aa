

namespace StatiskeMedlemmer
{
    class Program
    {
        static void Main(string[] args)
        {


            System.Console.WriteLine("lkjsdf");
            //System.Math.Cosh

            // Hjælpemetoder
            var res = System.IO.Directory.GetFiles(@"c:\temp");

            // Instans
            System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(@"c:\temp");
            // d.

            int res2 = Beregninger.Beregn(4);
            //Beregninger b = new Beregninger();

            Person p = new Person() { Navn = "a", Alder = 1 };
            p.Skriv();


            Person p3 = Person.TilfældigPerson();
            //Person p4 = Person.Hent(3);
            //p4.Alder = 30;
            //p4.Gem();

            Vare v = new Vare() { Navn = "a", PrisFørMoms = 100 };
            System.Console.WriteLine(v.PrisEfterMoms);

            //Person p5 = Person.TilfældigPerson();
            //p5.Gem();

            Person p6 = Person.Hent(889231);


        }
    }

    // Hjælpebibliotek
    public static class Beregninger
    {
        public static int Beregn(int a)
        {
            return 1;
        }
    }

    public class Vare
    {
        public string Navn { get; set; }
        public double PrisFørMoms { get; set; }

        // statiske data
        private static double moms;

        static Vare()
        {
            moms = 0.25; // fra db eller config...
        }

        public double PrisEfterMoms
        {
            get
            {
                return (this.PrisFørMoms * (1 + moms));
            }
        }
    }

    public class Person
    {

        private static System.Random rnd = new System.Random();
        public int Id { get; set; }
        public int Alder { get; set; }
        public string Navn { get; set; }
        public void Skriv() { }

        public string[] Biler;

        public Person()
        {
            Biler = new string[3];
            Biler[0] = "Volvo";
            Biler[1] = "GFie";
            Biler[2] = "Maza";
        }

        public static Person TilfældigPerson()
        {
            Person p = new Person();
            p.Id = rnd.Next(1, 1000000);
            p.Alder = rnd.Next(1, 100);
            string[] navne = { "Mikkel", "Anette", "Mathias" };
            p.Navn = navne[rnd.Next(0, 3)];
            return p;
        }

        public void Gem() {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(@"c:\temp\person" + this.Id + ".json", json);
        }
        public static Person Hent(int id)
        {
            string json = System.IO.File.ReadAllText(@"c:\temp\person" + id + ".json");
            Person p = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(json);
            return p;
        }
    }
}
