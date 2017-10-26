using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharAndString_2;

namespace CharAndStringTests
{
    [TestClass]
    public class part2Tests
    {
        [DataTestMethod]
        [DataRow(0, "0")]
        [DataRow(12345, "12345")]
        [DataRow(-12, "-12")]
        public void Test_IntToStr(int num, string exp)
        {
            Assert.AreEqual(exp, myConverter.IntToStr(num));
        }

        [DataTestMethod]
        [DataRow(1.5, "1.5")]
        [DataRow(0, "0")]
        [DataRow(0.27, "0.27")]
        public void Test_DoubleToString(double num, string exp)
        {
            Assert.AreEqual(exp, myConverter.DoubleToString(num));
        }

        [DataTestMethod]
        [DataRow("0", 0)]
        [DataRow("12345", 12345)]
        public void Test_StrToInt(string str, int exp)
        {
            Assert.AreEqual(exp, myConverter.StrToInt(str));
        }

        [DataTestMethod]
        [DataRow("-12")]
        [DataRow("1.2")]
        [ExpectedException(typeof(InvalidCastException))]
        public void Test_Ex_StrToInt(string str)
        {
            myConverter.StrToInt(str);
        }

        [DataTestMethod]
        [DataRow("1.5", 1.5)]
        [DataRow("0", 0)]
        [DataRow("0.27", 0.27)]
        public void Test_StrToDouble(string str, double exp)
        {
            Assert.AreEqual(exp, myConverter.StrToDouble(str), 0.0001);
        }

        [DataTestMethod]
        [DataRow("-1.5")]
        [DataRow("12.3abc")]
        [ExpectedException(typeof(InvalidCastException))]
        public void Test_Ex_StrToDouble(string str)
        {
            myConverter.StrToDouble(str);
        }
    }
}
