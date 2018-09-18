/*Victor Emiliano Fernandez Rubio
 * Antonio Luis Suarez Solis*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestBinario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ceroBinario()
        {
            Assert.AreEqual("0", Program.aBinario(0));
        }

        [TestMethod]
        public void numerosPrimosBinario()
        {
            Assert.AreEqual("11", Program.aBinario(3));
            Assert.AreEqual("10", Program.aBinario(2));
        }

        [TestMethod]
        public void numerosParesBinario()
        {
            Assert.AreEqual("1000110", Program.aBinario(70));
            Assert.AreEqual("111110", Program.aBinario(62));
        }    

        [TestMethod]
        public void numerosImparesBinarios()
        {
            Assert.AreEqual("110111", Program.aBinario(55));
            Assert.AreEqual("1101101", Program.aBinario(109));
        }
    }
}
