/*Victor Emiliano Fernandez Rubio
 * Antonio Luis Suarez Solis*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestFactorial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void factorialCero()
        {
            Assert.AreEqual(1u, Program.factorial(0));
        }

        [TestMethod]
        public void factorialUno()
        {
            Assert.AreEqual(1u, Program.factorial(1));
        }

        [TestMethod]
        public void numerosPares()
        {
            Assert.AreEqual(24u, Program.factorial(4));
            Assert.AreEqual(479001600u, Program.factorial(12));
        }

        [TestMethod]
        public void numerosImpares()
        {
            Assert.AreEqual(6u, Program.factorial(3));
            Assert.AreEqual(6227020800u, Program.factorial(13));
        }

        [TestMethod]
        public void numeroMasAlto()
        {
            Assert.AreEqual(9223372036854775808u, Program.factorial(65));
        }
    }
}
