/*Victor Emiliano Fernandez Rubio
 * Antonio Luis Suarez Solis*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestEsBisiesto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ejemplo()
        {
            Assert.AreEqual(true, Program.esBisiesto(2000));
        }

        [TestMethod]
        public void ceroBisiesto()
        {
            Assert.AreEqual(true, Program.esBisiesto(0));
        }

        [TestMethod]
        public void noEsBisiesto()
        {
            Assert.AreEqual(false, Program.esBisiesto(15));
            Assert.AreEqual(false, Program.esBisiesto(2015));
        }

        [TestMethod]
        public void siEsBisiesto()
        {
            Assert.AreEqual(true, Program.esBisiesto(2016));
            Assert.AreEqual(true, Program.esBisiesto(4));
        }
                
        [TestMethod]
        public void añosFuturos()
        {
            Assert.AreEqual(true, Program.esBisiesto(655432));
            Assert.AreEqual(false, Program.esBisiesto(12343));
            Assert.AreEqual(false, Program.esBisiesto(5433));
        }
    }
}
