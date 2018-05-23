using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHeapOpg
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Navn = "a";
            Person p2 = new Person();
            p2.Navn = "b";
            Console.WriteLine($"p1.navn {p1.Navn}");
            Console.WriteLine($"p2.navn {p2.Navn}");
            Console.WriteLine();

            p1 = p2;
            Console.WriteLine($"p1.navn {p1.Navn}");
            Console.WriteLine($"p2.navn {p2.Navn}");
            Console.WriteLine();

            p2.Navn = "c";
            Console.WriteLine($"p1.navn {p1.Navn}");
            Console.WriteLine($"p2.navn {p2.Navn}");
            Console.WriteLine();

            p1.Navn = "d";
            Console.WriteLine($"p1.navn {p1.Navn}");
            Console.WriteLine($"p2.navn {p2.Navn}");
            Console.WriteLine();
        }
    }

    class Person
    {
        public string Navn;

    }


}
