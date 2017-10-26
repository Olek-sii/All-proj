using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject {
    [TestClass]
    public class UnitTest1 {
        [DataTestMethod]
        [DataRow(1, 4, 5)]
        [DataRow(2, 4, 8)]
        public void TestCalculate(int a, int b, int expected) {
            Assert.AreEqual(expected, HW_1._1.calculate(a, b));
        }

        [DataTestMethod]
        [DataRow(2, 4, 1)]
        [DataRow(-2, 4, 2)]
        [DataRow(-2, -4, 3)]
        [DataRow(2, -4, 4)]
        public void TestQuadrant(int x, int y, int expected)
        {
            Assert.AreEqual(expected, HW_1._1.getQuadrant(x, y));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadrantX0()
        {
            int result = HW_1._1.getQuadrant(0, 4);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadrantY0()
        {
            int result = HW_1._1.getQuadrant(2, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadrantX0Y0()
        {
            int result = HW_1._1.getQuadrant(0, 0);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 6)]
        [DataRow(1, 2, -3, 3)]
        [DataRow(1, -2, -3, 1)]
        [DataRow(-1, -2, -3, 0)]
        [DataRow(0, 2, 3, 5)]
        [DataRow(0, 0, 3, 3)]
        [DataRow(0, 0, 0, 0)]
        public void TestSumOnlyPositive(int a, int b, int c, int expected)
        {
            Assert.AreEqual(expected, HW_1._1.sumOnlyPositive(a, b, c));
        }


        [DataTestMethod]
        [DataRow(5,5,5,128)]
        [DataRow(1, 1, 1, 6)]
        [DataRow(0, 0, 0, 3)]
        public void TestCalcGreater(int a, int b, int c, int expected)
        {
            Assert.AreEqual(expected, HW_1._1.calculate(a, b, c));
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRating0()
        {
            HW_1._1.getNote(-1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRating101()
        {
            HW_1._1.getNote(101);
        }
        [DataTestMethod]
        [DataRow(0, 'F')]
        [DataRow(10, 'F')]
        [DataRow(19, 'F')]
        [DataRow(20, 'E')]
        [DataRow(30, 'E')]
        [DataRow(20, 'E')]
        [DataRow(40, 'D')]
        [DataRow(50, 'D')]
        [DataRow(59, 'D')]
        [DataRow(60, 'C')]
        [DataRow(67, 'C')]
        [DataRow(74, 'C')]
        [DataRow(75, 'B')]
        [DataRow(80, 'B')]
        [DataRow(89, 'B')]
        [DataRow(90, 'A')]
        [DataRow(95, 'A')]
        [DataRow(100, 'A')]
        public void TestRating(int input, char expected)
        {
            Assert.AreEqual(expected, HW_1._1.getNote(input));
        }
    }
}
