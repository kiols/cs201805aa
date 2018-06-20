using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAction
{

    //public delegate void MinDelegate1();
    //public delegate void MinDelegate2(string t);
    // public delegate int MinDelegate3(int i);
    // public delegate int MinDelegate4(int i, int x);

    class Program
    {
        static void Main(string[] args)
        {
            // action = void
            // func = retur værdi

            //MinDelegate1 d = Test;
            Action d = Test;
            d();

            //MinDelegate2 d2 = Console.WriteLine;
            Action<string> d2 = Console.WriteLine;
            d2("TEST");

            Action<int, string, DateTime, Random> d3;

            Func<int, int> d4 = Test2;
            int r = Test2(3);


        }


        static int Test2(int a)
        {
            Console.WriteLine("I test2");
            return 1;
        }

        static void Test() {
            Console.WriteLine("I test");
        }
    }
}
