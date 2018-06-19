using System;

namespace usingdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            //Bil b = new Bil();
            //try
            //{

            //}
            //catch (Exception)
            //{

            //}
            //finally
            //{
            //    b.Dispose();
            //}

            using (Bil b = new Bil())
            {
                //b.gem
            } // dispose bliver kaldt, og den 
              // skal sørge for at lukke og rydde op...



            Console.WriteLine("Slut");


            Bil t = new Bil();
            t.Dispose();


            Console.WriteLine();

            //System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection("...");
            //cn.Open();
            //cn.Dispose();

            using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection("..."))
            {
                cn.Open();
                using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("select * ", cn))
                {
                    

                } // dispose
            }

            //using (System.Random rnd = new Random())
            //{

            //}

            var a = System.IO.File.ReadAllLines(@"c:\temp\data.csv");



        }
    }

    class Bil : IDisposable
    {

        public Bil()
        {
            Console.WriteLine("Jeg fødes");
        }

        //~Bil()
        //{
        //    // io, db, tcp
        //    Console.WriteLine("Jeg dør");
        //}

        public void Dispose()
        {
            Console.WriteLine("Rydder op - og så må jeg dø");
        }
    }
}
