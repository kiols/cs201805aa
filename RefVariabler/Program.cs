using System;

namespace RefVariabler
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a1;
            a1 = new int[5];
            int[] a2 = new int[5];
            int[] a3 = { 1, 2, 7, 1, 4, 4, 3, 47 };

            a1[0] = 10;
            a1[3] = 100;
            a2[0] = 9;

            a1 = a2;

            a1[1] = 222;
            a2[2] = 999;

            a1 = a3;
            string[] a4 = { "" };

            a1 = null;
//            Console.WriteLine(a1[0]);

            // Statisk metode
            System.Array.Sort(a3);

            // Instans medlem
            Console.WriteLine(a3.Length);

            int[] a5 = { 1, 2, 7, 1, 4, 4, 3, 47 };
            a5 = null;

            for (int i = 0; i < a5.Length; i++)
            {
                Console.WriteLine(a5[i]);
            }

            foreach (int i in a5)
            {
                Console.WriteLine(i);
            }


        }
    }
}
