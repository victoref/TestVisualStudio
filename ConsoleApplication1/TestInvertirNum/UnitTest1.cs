/*Victor Emiliano Fernandez Rubio
 * Antonio Luis Suarez Solis*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestInvertirNum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void invertirCero()
        {
            Assert.AreEqual(0u, Program.invertirNumero(0));
        }

        [TestMethod]
        public void capicuas() 
        {
            Assert.AreEqual(282u, Program.invertirNumero(282));
            Assert.AreEqual(323u, Program.invertirNumero(323));
        }


        [TestMethod]
        public void numIgualesInvertir()
        {
            Assert.AreEqual(111u, Program.invertirNumero(111));
            Assert.AreEqual(555u, Program.invertirNumero(555));
        }

        [TestMethod]
        public void numNormalesInvertir()
        {
            Assert.AreEqual(43u, Program.invertirNumero(34));
            Assert.AreEqual(654u, Program.invertirNumero(456));
        }

        [TestMethod]
        public void potenciasDe10()
        {
            Assert.AreEqual(1u, Program.invertirNumero(10));
            Assert.AreEqual(1u, Program.invertirNumero(10000));
        }
    }
}
