using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestEvens1_99Sum()
        {
            Assert.AreEqual(2450, HW_1._2.getEvensSum());
        }
        [TestMethod]
        public void TestEvens1_99Count()
        {
            Assert.AreEqual(49, HW_1._2.getNEvens());
        }


        [DataTestMethod]
        [DataRow((uint)13, true)]
        [DataRow((uint)14, false)]
        [DataRow((uint)0, false)]
        public void TestPrime(uint input, bool expected)
        {
            Assert.AreEqual(expected, HW_1._2.isPrime(input));
        }

        [DataTestMethod]
        [DataRow((uint)0, (uint)0)]
        [DataRow((uint)1, (uint)1)]
        [DataRow((uint)4, (uint)2)]
        [DataRow((uint)30, (uint)5)]
        public void TestSqrt(uint input, uint expected)
        {
            Assert.AreEqual(expected, HW_1._2.sqrt(input));
        }

        [DataTestMethod]
        [DataRow((uint)0, (uint)0)]
        [DataRow((uint)1, (uint)1)]
        [DataRow((uint)4, (uint)2)]
        [DataRow((uint)30, (uint)5)]
        public void TestSqrtBS(uint input, uint expected)
        {
            Assert.AreEqual(expected, HW_1._2.sqrtBS(input));
        }

        [DataTestMethod]
        [DataRow((uint)0, (ulong)1)]
        [DataRow((uint)1, (ulong)1)]
        [DataRow((uint)7, (ulong)5040)]
        public void TestFactorial(uint input, ulong expected)
        {
            Assert.AreEqual(expected, HW_1._2.factorial(input));
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(42, 6)]
        [DataRow(-42, 6)]
        public void TestCaclDigits(int input, int expected)
        {
            Assert.AreEqual(expected, HW_1._2.CalcDigits(input));
        }


        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(23, 32)]
        [DataRow(42, 24)]
        [DataRow(-42, -24)]
        public void TestGetMirror(int input, int expected)
        {
            Assert.AreEqual(expected, HW_1._2.getMirror(input));
        }
    }
}
