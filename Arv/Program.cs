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

            Person w = new Instruktør();

            Person[] a = new Person[3];
            a[0] = new Person() { Navn = "a" };
            a[1] = new Instruktør() { Navn = "b" };
            a[2] = new Kursist() { Navn = "c" };
            foreach (Person person in a)
            {
                person.Skriv();
            }

            Console.WriteLine();

            A a1 = new A();
            a1.Test();

            B b1 = new B();
            b1.Test();

            A a2 = new B();
            a2.Test();

            Test r = new Test();
            
        }
    }

    class Dyr { }

    public class Person
    {

        // public
        // private
        // protected

        public int Id { get; set; }
        public string Navn { get; set; }

        public virtual void Skriv() {
            Console.WriteLine("Jeg er en person og hedder " + this.Navn);
            this.PrivatFunktion();
        }
        protected void PrivatFunktion() { }

    }

    public class Instruktør : Person {

        public double Løn { get; set; }
        public void SkrivLønSeddel() {
            
        }

        public override void Skriv()
        {
            Console.WriteLine("Jeg er en instruktør og hedder " + this.Navn);
            
        }
    }

    public class Kursist : Person
    {

        public double KursistId { get; set; }
        public void MailTilLogin() { }

        public override void Skriv()
        {
            Console.WriteLine("Jeg er en kursist og hedder " + this.Navn);

        }
    }

    public sealed class HjælpeInstruktør : Instruktør {
        public int PraktikPeriode { get; set; }
        public void SpecielLogin() { }
        public override void Skriv()
        {
            Console.WriteLine("Jeg er en hjælpeinstruktør og hedder " + this.Navn);

        }
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

        public virtual void Test() {
            Console.WriteLine("Test i A");
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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Test()
        {
            Console.WriteLine("Test i B");
        }

        public override string ToString()
        {
            return base.ToString();
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

    partial class Test {
        public void T1() { }
    }
    partial class Test {
        public void T2() { }
    }

    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using Teknolgisk;
    //
    //    var debitor = Debitor.FromJson(jsonString);

    // https://app.quicktype.io/#l=cs&r=json2csharp
    namespace Teknolgisk
    {
        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class Debitor
        {
            [JsonProperty("navn")]
            public string Navn { get; set; }

            [JsonProperty("alder")]
            public long Alder { get; set; }

            [JsonProperty("iDk")]
            public bool IDk { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("fakturaer")]
            public Fakturaer[] Fakturaer { get; set; }
        }

        public partial class Fakturaer
        {
            [JsonProperty("fakturaid")]
            public long Fakturaid { get; set; }
        }

        public partial class Debitor
        {
            public static Debitor FromJson(string json) => JsonConvert.DeserializeObject<Debitor>(json, Teknolgisk.Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this Debitor self) => JsonConvert.SerializeObject(self, Teknolgisk.Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }
    }

}
