using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();  // default _a = 1;
            Console.WriteLine(a.GetA());
            a.SetA(10);

            Console.WriteLine(a.GetA());

            B b = new B();
            b.A = 10;
            Console.WriteLine(b.A);

            Person p = new Person();
            //p.Alder = -10;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);
            Console.WriteLine(p.NavnMedStort());

            Console.WriteLine(p.ToStringEx());


            // Reflection
            var res = p.GetType().GetProperties();


        }
    }

    class A
    {

        private int _a;     // 0 = default
        private string _b;  // null = default
        private bool _c;    // false = default

        public A()
        {
            this._a = 1;
            this._b = "";
        }

        public void SetA(int value)
        {
            // log
            // sikkerhed
            // validering
            if (value < 0)
                value = 0;

            this._a = value;
        }

        public int GetA()
        {
            // sikkerhed
            // log
            // ....
            return _a;
        }

        public void SetB(string value)
        {
            // ....
            // ...
            this._b = value;
        }

        public string GetB()
        {
            // ....
            // ...
            return this._b;
        }

    }

    class B
    {

        private int _a; // 0 = default

        public int A
        {
            get
            {
                // log
                // sikkerhed
                // validering
                return this._a;
            }
            set
            {
                // log
                // sikkerhed
                // validering
                this._a = value;
            }
        }
    }

}
