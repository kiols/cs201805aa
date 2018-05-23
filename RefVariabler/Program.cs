using Csv;
using System;
using System.IO;
using System.Linq;

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
            //a5 = null;

            for (int i = 0; i < a5.Length; i++)
            {
                Console.WriteLine(a5[i]);
            }

            foreach (int i in a5)
            {
                Console.WriteLine(i);
            }

            char t = 'A';
            string navn = "Mikkel";
            navn = navn.ToUpper();

            //string sti = "c:\temp\test.txt";
            //string sti = "c:\\temp\\test.txt";
            string sti = @"c:\temp\test.txt";

            string text = "dlfkjæsdlkfjg\r\ndgkdhgsdkjhg";
            Console.WriteLine(text);

            // csv assembly
            string csv2 = "324;223;234;2132;23";
            string[] aa = csv2.Split(';');

            string b = "dsfæfdk" + " " + text + "*";
            int alder = 10;
            string navn2 = "Mikkel";

            string c = $"Personen {navn2.ToUpper()} er {alder-1} år.";

            Console.WriteLine("Start");
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            string tmp = "";
            for (int i = 0; i < 100_000; i++)
            {
                tmp += "*";
            }
            s.Stop();
            Console.WriteLine($"Tid = {s.ElapsedMilliseconds}");

            System.Text.StringBuilder sb 
                = new System.Text.StringBuilder();
            s.Reset();
            s.Start();            
            for (int i = 0; i < 10000000; i++)
            {
                sb.Append("*");
            }
            s.Stop();
            Console.WriteLine($"Tid = {s.ElapsedMilliseconds}");

            var csv = File.ReadAllText("data.csv");
            foreach (var line in CsvReader.ReadFromText(csv))
            {
                // Header is handled, each line will contain the actual row data
                var firstCell = line[0];
                var byName = line["b"];
            }


            int y = 1;
            switch (y)
            {
                case 1:
                case 2:
                    // kode


                    break;
                case 3:
                    break;

                default:
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;

                Console.WriteLine(i);
                if (i == 7)
                    break;
            }



        }

      
    }



    

 
}
