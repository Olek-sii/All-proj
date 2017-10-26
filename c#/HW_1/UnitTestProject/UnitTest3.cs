using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMinNull()
        {
            HW_1._3.min(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMinEmpty()
        {
            HW_1._3.min(new int[] { });
        }

        [DataTestMethod]
        [DataRow(new int[] { 42 }, 42)]
        [DataRow(new int[] { 0, 42 }, 0)]
        [DataRow(new int[] { 128, 42, 7, 144, 32 }, 7)]
        public void TestMin(int[] input, int expected)
        {
            Assert.AreEqual(expected, HW_1._3.min(input));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxNull()
        {
            HW_1._3.max(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxEmpty()
        {
            HW_1._3.max(new int[] { });
        }

        [DataTestMethod]
        [DataRow(new int[] { 42 }, 42)]
        [DataRow(new int[] { 0, 42 }, 42)]
        [DataRow(new int[] { 128, 42, 7, 144, 32 }, 144)]
        public void TestMax(int[] input, int expected)
        {
            Assert.AreEqual(expected, HW_1._3.max(input));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMinIndexNull()
        {
            HW_1._3.minIndex(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMinIndexEmpty()
        {
            HW_1._3.minIndex(new int[] { });
        }

        [DataTestMethod]
        [DataRow(new int[] { 42 }, 0)]
        [DataRow(new int[] { 0, 42 }, 0)]
        [DataRow(new int[] { 128, 42, 7, 144, 32 }, 2)]
        public void TestMinIndex(int[] input, int expected)
        {
            Assert.AreEqual(expected, HW_1._3.minIndex(input));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxIndexNull() {
            HW_1._3.maxIndex(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxIndexEmpty() {
            HW_1._3.maxIndex(new int[] { });
        }

        [DataTestMethod]
        [DataRow(new int[] { 42 }, 0)]
        [DataRow(new int[] { 0, 42 }, 1)]
        [DataRow(new int[] { 128, 42, 7, 144, 32 }, 3)]
        public void TestMaxIndex(int[] input, int expected) {
            Assert.AreEqual(expected, HW_1._3.maxIndex(input));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSumOddIndexNull() {
            HW_1._3.sumOddIndex(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSumOddIndexEmpty() {
            HW_1._3.sumOddIndex(new int[] { });
        }

        [DataTestMethod]
        [DataRow(new int[] { 42 }, 0)]
        [DataRow(new int[] { 0, 42 }, 42)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 12)]
        public void TestSumOddIndex(int[] input, int expected) {
            Assert.AreEqual(expected, HW_1._3.sumOddIndex(input));
        }

        [TestMethod]
        public void TestArrayReverseNull() {
            int[] input = null;
            HW_1._3.reverse(input);
            CollectionAssert.AreEqual(null, input);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 42 }, new int[] { 42 })]
        [DataRow(new int[] { 0, 42 }, new int[] { 42, 0 })]
        [DataRow(new int[] { 128, 42, 7, 144, 32 }, new int[] { 32, 144, 7, 42, 128 })]
        public void TestArrayReverse(int[] input, int[] expected) {
            HW_1._3.reverse(input);
            CollectionAssert.AreEqual(expected, input);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestOddSumNull() {
            HW_1._3.getOddNum(null);
        }

        [DataTestMethod]
        [DataRow(new int[] {  }, 0)]
        [DataRow(new int[] { 42 }, 0)]
        [DataRow(new int[] { 0, 42, 13 }, 1)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 3)]
        public void TestOddSum(int[] input, int expected) {
            Assert.AreEqual(expected, HW_1._3.getOddNum(input));
        }


        [TestMethod]
        public void TestArrayHalfReverseNull() {
            int[] input = null;
            HW_1._3.halfReverse(input);
            CollectionAssert.AreEqual(null, input);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 42 }, new int[] { 42 })]
        [DataRow(new int[] { 0, 42 }, new int[] { 42, 0 })]
        [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [DataRow(new int[] { 1, 2, 5, 3, 4 }, new int[] { 3, 4, 5, 1, 2 })]
        public void TestArrayHalfReverse(int[] input, int[] expected) {
            HW_1._3.halfReverse(input);
            CollectionAssert.AreEqual(expected, input);
        }


        [TestMethod]
        public void TestArrayBSNull() {
            int[] input = null;
            HW_1._3.bubbleSort(input);
            CollectionAssert.AreEqual(null, input);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 42 }, new int[] { 42 })]
        [DataRow(new int[] { 42, 0 }, new int[] { 0, 42 })]
        [DataRow(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [DataRow(new int[] { 2, 1, 5, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        public void TestArrayBS(int[] input, int[] expected) {
            HW_1._3.bubbleSort(input);
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestArraySSNull() {
            int[] input = null;
            HW_1._3.selectSort(input);
            CollectionAssert.AreEqual(null, input);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 42 }, new int[] { 42 })]
        [DataRow(new int[] { 42, 0 }, new int[] { 0, 42 })]
        [DataRow(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [DataRow(new int[] { 2, 1, 5, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        public void TestArraySS(int[] input, int[] expected) {
            HW_1._3.selectSort(input);
            CollectionAssert.AreEqual(expected, input);
        }


        [TestMethod]
        public void TestArrayISNull() {
            int[] input = null;
            HW_1._3.insertSort(input);
            CollectionAssert.AreEqual(null, input);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 42 }, new int[] { 42 })]
        [DataRow(new int[] { 42, 0 }, new int[] { 0, 42 })]
        [DataRow(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [DataRow(new int[] { 2, 1, 5, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        public void TestArrayIS(int[] input, int[] expected) {
            HW_1._3.insertSort(input);
            CollectionAssert.AreEqual(expected, input);
        }

		[TestMethod]
		public void TestArrayMergeSortNull()
		{
			int[] input = null;
			HW_1._3.MergeSort(input);
			CollectionAssert.AreEqual(null, input);
		}
		[DataTestMethod]
		[DataRow(new int[] { }, new int[] { })]
		[DataRow(new int[] { 42 }, new int[] { 42 })]
		[DataRow(new int[] { 42, 0 }, new int[] { 0, 42 })]
		[DataRow(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
		[DataRow(new int[] { 2, 1, 5, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
		public void TestArrayMergeSort(int[] input, int[] expected)
		{
			HW_1._3.MergeSort(input);
			CollectionAssert.AreEqual(expected, input);
		}
	}
}
