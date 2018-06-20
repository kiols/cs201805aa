using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            a.ForEach(Skriv);
            Console.WriteLine();
            a.ForEach((int x) =>
            {
                Console.WriteLine(": " + x);
            });
            Console.WriteLine();
            a.ForEach(x =>
            {
                Console.WriteLine(": " + x);
            });

            // ---
            List<int> res = a.FindAll(FindTal);
            Console.WriteLine(string.Join(" ", res));
            res = a.FindAll((int i) => { return i < 10; });
            Console.WriteLine(string.Join(" ", res));
            res = a.FindAll(i => i < 10);
            Console.WriteLine(string.Join(" ", res));

        }

        static void Skriv(int i)
        {
            Console.WriteLine("= " + i);
        }

        static bool FindTal(int t)
        {
            return t < 10;
        }
    }
}
