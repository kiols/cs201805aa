using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;
            //SwapInt(ref a, ref b);

            Swap<int>(ref a, ref b);

            double x = 100;
            double y = 200;
            Swap<double>(ref x, ref y);

            Swap(ref a, ref b);

            Punkt<byte> p = new Punkt<byte>();
            

        }

        static void Swap<T>(ref T a, ref T b) {
            T tmp = a;
            a = b;
            b = tmp;
        }

        static void SwapInt(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;

        }

        static void SwapDouble(ref double a, ref double b)
        {
            double tmp = a;
            a = b;
            b = tmp;

        }

        static void SwapByte(ref byte a, ref byte b)
        {
            byte tmp = a;
            a = b;
            b = tmp;

        }



    }

    class Punkt<T> where T:IDisposable {
        public T x;
        public T y;
        public void Beregn(T a) {

        }
    }
}
