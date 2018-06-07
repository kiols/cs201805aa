using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    class Program
    {

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Debug("Start");
            logger.Debug("Kalder f1");
            try
            {
                f1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl");
                
            }
            logger.Debug("End");
        }

        static void f1() {
            logger.Debug("Enter");
            f2(32);
            logger.Debug("Exit");
        }
        static void f2(int i)
        {
            logger.Debug("Enter " + i);
            logger.Trace("Kald mod db - select * from ,.,,,,");
            try
            {
                string g = null;
                g.ToUpper();
            }
            catch (Exception ex)
            {
                logger.Error(ex);

                throw;
            }
            logger.Debug("Hentet 50 poster");
            logger.Debug("Exit");
        }


    }
}
