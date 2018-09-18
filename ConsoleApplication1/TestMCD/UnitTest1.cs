/*Victor Emiliano Fernandez Rubio
 * Antonio Luis Suarez Solis*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestMCD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ceroMCD()
        {
            Assert.AreEqual(0u, Program.MCD(0, 0));
        }

        [TestMethod]
        public void primos()
        {
            Assert.AreEqual(1u, Program.MCD(2, 5));
            Assert.AreEqual(1u, Program.MCD(3, 11));
        }

        [TestMethod]
        public void pares()
        {
            Assert.AreEqual(2u, Program.MCD(2, 8));
            Assert.AreEqual(6u, Program.MCD(6, 36));
        }

        [TestMethod]
        public void impar()
        {
            Assert.AreEqual(5u, Program.MCD(5, 25));
            Assert.AreEqual(7u, Program.MCD(7,63));
        }

        [TestMethod]
        public void numIgualesMCD()
        {
            Assert.AreEqual(5u, Program.MCD(5, 5));
            Assert.AreEqual(32u, Program.MCD(32, 32));
        }
    }
}
