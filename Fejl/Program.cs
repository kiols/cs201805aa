using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejl
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    string g = null;
            //    Console.WriteLine(g.ToUpper());

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Fejl " +ex.Message);
            //    // log ex

            //}

       

            try
            {
                Run();
            }
            //catch (NullReferenceException ex) {
            //    Console.WriteLine("Null ref");
            //}
            //catch (System.IO.IOException ex) { }
            catch (Exception ex)
            {
                // LOG
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }




            Console.WriteLine("Videre");
        }

        static void Run() {
            f2();
        }
        static void f2() {
            f3();
        }
        static void f3() {
            //try
            //{
                string g = null;
                Console.WriteLine(g.ToUpper());
            //}
            //catch (Exception ex)
            //{
            //    ApplicationException a 
            //        = new ApplicationException("Fejl grundet ......", ex);
            // log
            //    throw a;
            //}

            try
            {

            }
            catch (Exception)
            {
                // log
                // logik
                    ApplicationException a 
                        = new ApplicationException("Fejl grundet ......");
                throw a;

                //throw new ApplicationException("");
            }
        }
    }
}
