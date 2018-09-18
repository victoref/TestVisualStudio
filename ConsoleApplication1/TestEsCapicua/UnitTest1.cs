/*Victor Emiliano Fernandez Rubio
 * Antonio Luis Suarez Solis*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestEsCapicua
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ceroCapicua()
        {
            Assert.AreEqual(true, Program.esCapicua(0));
        }

        [TestMethod]
        public void unNumero()
        {
            Assert.AreEqual(true, Program.esCapicua(2));
            Assert.AreEqual(true, Program.esCapicua(8));
        }


        [TestMethod]
        public void noEsCapicua() 
        {
            Assert.AreEqual(false, Program.esCapicua(354));
            Assert.AreEqual(false, Program.esCapicua(897465));
        }

        [TestMethod]
        public void esCapicua() 
        {
            Assert.AreEqual(true, Program.esCapicua(525));
            Assert.AreEqual(true, Program.esCapicua(78987));
        }

        [TestMethod]
        public void numIgualesCapicua()
        {
            Assert.AreEqual(true, Program.esCapicua(555));
            Assert.AreEqual(true, Program.esCapicua(7777));
        }
    }
}
