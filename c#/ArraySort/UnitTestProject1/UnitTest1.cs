using ArraySort;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestBubble()
		{
			int[] arr = new int[] { 3, 5, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5 };

			Sorts.SortBubble(arr);
			CollectionAssert.AreEqual(expected, arr);
		}

		[TestMethod]
		public void TestSelect()
		{
			int[] arr = new int[] { 3, 5, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5 };

			Sorts.SortSelect(arr);
			CollectionAssert.AreEqual(expected, arr);
		}

		[TestMethod]
		public void TestInsert()
		{
			int[] arr = new int[] { 3, 5, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5 };

			Sorts.SortInsert(arr);
			CollectionAssert.AreEqual(expected, arr);
		}

		[TestMethod]
		public void TestMerge()
		{
			int[] arr = new int[] { 3, 5, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5 };

			Sorts.Merge(arr);
			CollectionAssert.AreEqual(expected, arr);
		}

		[TestMethod]
		public void TestQuick()
		{
			int[] arr = new int[] { 3, 5, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5 };

			Sorts.quickSort(arr, 0, 4);
			CollectionAssert.AreEqual(expected, arr);
		}

		[TestMethod]
		public void TestShell()
		{
			int[] arr = new int[] { 3, 5, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5 };

			Sorts.Shell(arr);
			CollectionAssert.AreEqual(expected, arr);
		}

		[TestMethod]
		public void TestHeap()
		{
			int[] arr = new int[] { 3, 5, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5 };

			Sorts.Heap(arr);
			CollectionAssert.AreEqual(expected, arr);
		}
	}
}
