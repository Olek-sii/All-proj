using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class MathTests
    {
        public double Delta = 0.01;

        [DataTestMethod]
        [DataRow(45d, 54d, 22.94d)]
        [DataRow(0d, 54d, 0d)]
        [DataRow(45d, 0d, 0d)]
        [DataRow(-45d, 54d, -22.94)]
        public void Test_CountDistanceOfThrowByDeg(double degree, double speed, double exp)
        {
            Assert.AreEqual(exp, myMath.myMath.CountDistanceOfThrowByDeg(degree, speed), Delta);
        }

        [TestMethod]
        [DataRow(45d, -54d, 0d)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Ex_CountDistanceOfThrowByDeg(double degree, double speed, double exp)
        {
            myMath.myMath.CountDistanceOfThrowByDeg(degree, speed);
        }

        [DataTestMethod]
        [DataRow(Math.PI / 4, 54d, 22.94)]
        [DataRow(0d, 54d, 0d)]
        [DataRow(Math.PI / 4, 0d, 0d)]
        [DataRow(Math.PI * (-1) / 4, 54d, -22.94)]
        public void Test_CountDistanceOfThrowByRad(double radians, double speed, double exp)
        {
            Assert.AreEqual(exp, myMath.myMath.CountDistanceOfThrowByRad(radians, speed), Delta);
        }

        [DataTestMethod]
        [DataRow(Math.PI / 4, -54d, 0d)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Ex_CountDistanceOfThrowByRad(double radians, double speed, double exp)
        {
            myMath.myMath.CountDistanceOfThrowByRad(radians, speed);
        }

        [DataTestMethod]
        [DataRow(60d, 70d, 2.5, 1d, 326d)]
        public void Test_CountDistanceBetweenCars(double v1, double v2, double t, double s, double exp)
        {
            Assert.AreEqual(exp, myMath.myMath.CountDistanceBetweenCars(v1, v2, t, s), Delta);
        }

        [DataTestMethod]
        [DataRow(-1d, 70d, 2.5, 1d)]
        [DataRow(60d, -1d, 2.5, 1d)]
        [DataRow(60d, 70d, -1d, 1d)]
        [DataRow(60d, 70d, 2.5, -1d)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Ex_CountDistanceBetweenCars(double v1, double v2, double t, double s)
        {
            myMath.myMath.CountDistanceBetweenCars(v1, v2, t, s);
        }

        [DataTestMethod]
        [DataRow(0, 0, true)]
        [DataRow(0, -1, true)]
        [DataRow(2, 2, true)]
        [DataRow(-2, 2, true)]
        [DataRow(1, 1, true)]
        [DataRow(-1, 1, true)]
        [DataRow(2d / 3, 0, true)]
        [DataRow(-2d / 3, 0, true)]
        [DataRow(1, 2, false)]
        [DataRow(-1, 2, false)]
        [DataRow(1, -1, false)]
        [DataRow(-1, -1, false)]
        public void Test_IsPointInsideShadedArea(double x, double y, bool exp)
        {
            Assert.AreEqual(exp, myMath.myMath.IsPointInsideShadedArea(x, y));
        }

        [DataTestMethod]
        [DataRow(1, 0)]
        [DataRow(8.37, Math.PI)]
        public void Test_CountValue(double exp, double x)
        {
            Assert.AreEqual(exp, myMath.myMath.CountValue(x), Delta);
        }
    }
}
