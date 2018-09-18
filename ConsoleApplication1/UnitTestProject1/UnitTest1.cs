/*Victor Emiliano Fernandez Rubio
 * Antonio Luis Suarez Solis*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace TestNumSegundos
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ceroSegundos()
        {
            Assert.AreEqual(0u, Program.numSegundos(0, 0, 0));
        }

        [TestMethod]
        public void soloSegundos()
        {
            Assert.AreEqual(54u, Program.numSegundos(0, 0, 54));
            Assert.AreEqual(108u, Program.numSegundos(0, 0, 108));
        }

        [TestMethod]
        public void soloMinutos()
        {
            Assert.AreEqual(180u, Program.numSegundos(0, 3, 0));
            Assert.AreEqual(720u, Program.numSegundos(0, 12, 0));
        }

        [TestMethod]
        public void soloHoras()
        {
            Assert.AreEqual(3600u, Program.numSegundos(1, 0, 0));
            Assert.AreEqual(18000u, Program.numSegundos(5, 0, 0));
        }

        [TestMethod]
        public void numeroSegundos()
        {
            Assert.AreEqual(9902u, Program.numSegundos(2, 45, 2));
        }
    }
}


