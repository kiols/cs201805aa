using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teknologisk.Kortspil.Test.UnitTest
{
    [TestClass]
    public class SpilleKortTest
    {
        [TestMethod]
        public void TestAfOpretKortDefault()
        {
            for (int i = 0; i < 1000; i++)
            {
                Kerne.Kort k1 = new Kerne.Kort();
                Assert.IsNotNull(k1);
                Assert.IsTrue(k1.Værdi >= 2 && k1.Værdi <= 14); 
            }

        }

        [TestMethod]
        public void TestAfOpretKortCustom()
        {
            Kerne.Kort k1 = new Kerne.Kort(2, Kerne.KortKulør.Hjerter);
            Assert.IsNotNull(k1);
            Assert.IsTrue(k1.Værdi == 2 && k1.Kulør== Kerne.KortKulør.Hjerter);


        }
    }
}
