using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejl2
{
    class Program
    {
        static void Main(string[] args)
        {

            Teknologisk.Kortspil.Kerne.Kort k = new Teknologisk.Kortspil.Kerne.Kort(2, Teknologisk.Kortspil.Kerne.KortKulør.Hjerter);
            Console.WriteLine(k.Skriv());

            try
            {
                Teknologisk.Kortspil.Kerne.Kort k2 = new Teknologisk.Kortspil.Kerne.Kort(20, Teknologisk.Kortspil.Kerne.KortKulør.Hjerter);
            }
            catch (System.IO.IOException ex) {

            }
            catch (NullReferenceException ex) {

            }
            catch (Teknologisk.Kortspil.Kerne.KortException ex)
            {
                
                Console.WriteLine("**** " + ex.Message + " "+ ex.TimeStamp);

            }
            catch (ApplicationException ex)
            {

            }
            
            catch (Exception ex)
            {
                // logge

                Console.WriteLine("Fejl " + ex.Message);

            }


            //try
            //{

            //    string g = null;
            //    g.ToString();

            //}
            //catch (Exception ex)
            //{
            //    // log ex
            //    Console.WriteLine("Fejl");

            //}


        }
    }
}
