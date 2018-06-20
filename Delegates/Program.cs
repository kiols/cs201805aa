using System;

namespace Delegates
{
    // definition af delegates
    public delegate void delegate_void();
    public delegate void delegate_voidstring(string txt);
    public delegate void delegate_voidint(int a);
    public delegate int delegate_intintint(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {

            // direkte
            Test1();
            Test2(2);
            int res1 = Test3(5, 1);

            Console.WriteLine("---");
            delegate_void d1 = new delegate_void(Test1);
            d1 += Test1;
            d1 += Test1;
            d1 += Test1a;
            d1 += Test1b;
            //Test1();
            d1.Invoke();
            Console.WriteLine("---");

            Console.WriteLine();
            delegate_voidint d2 = new delegate_voidint(Test2);
            Test2(54);
            d2.Invoke(6);

            Console.WriteLine();
            delegate_intintint d3 = new delegate_intintint(Test3);
            Console.WriteLine(Test3(6, 7));
            Console.WriteLine(d3.Invoke(6, 7));

            Console.WriteLine();
            StartMaskine(6, d1);

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(150);
                delegate_void d4 = FindFunktion();
                d4.Invoke();
            }

            Console.WriteLine();
            MinMaskine m = new MinMaskine();
            m.LogFunktion = new delegate_voidstring(Test6);
            m.LogFunktion += Test5;
            m.LogFunktion += Console.WriteLine;
            m.LogFunktion += DebugSkriv;
            //m.LogFunktion += (t) => { System.Diagnostics.Debug.WriteLine(t); };
            m.Start();
            m.Stop();

            // ny syntaks

            Console.WriteLine("********");
            //delegate_void n1 = new delegate_void(Test1);
            delegate_void n1 = Test1;
            //StartMaskine(76, new delegate_void(Test1));
            StartMaskine(76, Test1);
            //n1.Invoke();
            n1();


        }

        static void StartMaskine(int antal, delegate_void nårDuErFærdigFunktion) {
            Console.WriteLine("Maskine starter");
            // logik...
            // færdig...
            if (nårDuErFærdigFunktion != null)
                nårDuErFærdigFunktion.Invoke();
        }

        static delegate_void FindFunktion() {
            // logik...
            if (DateTime.Now.Millisecond % 2 == 0) {
                return new delegate_void(Test1a);
            } else {
                return new delegate_void(Test1b);
            }
        }

        static void Test1()
        {
            Console.WriteLine("I Test1");
        }


        static void Test5(string txt) {
            Console.WriteLine("I test5 med " + txt);
        }

        static void Test6(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }

        static void DebugSkriv(string txt) {
            System.Diagnostics.Debug.WriteLine(txt);
        }

        static void Test1a()
        {
            Console.WriteLine("I Test1a");
        }

        static void Test1b()
        {
            Console.WriteLine("I Test1b");
        }

        static void Test2(int a)
        {
            Console.WriteLine("I Test2 a="+a);
        }

        static int Test3(int a, int b)
        {
            Console.WriteLine("I Test3 a=" + a + " b= " +b);
            return a + b;
        }
    }

    class MinMaskine {

        public delegate_voidstring LogFunktion { get; set; }

        public void Start() {
            if (LogFunktion != null)
                LogFunktion.Invoke("nu starter jeg");
            
        }
        public void Stop() {
            if (LogFunktion != null)
                LogFunktion.Invoke("nu stopper jeg");
            
        }
    }

}
