using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListMsUnitTest
{
	[TestClass]
	public class TestAList0 : TestList
	{
		internal override IList MakeList()
		{
			return new AList0();
		}
	}

	[TestClass]
	public class TestAList1 : TestList
	{
		internal override IList MakeList()
		{
			return new AList1();
		}
	}

	[TestClass]
	public class TestAList2 : TestList
	{
		internal override IList MakeList()
		{
			return new AList2();
		}
	}

	[TestClass]
	public class TestLList1 : TestList
	{
		internal override IList MakeList()
		{
			return new LList1();
		}
	}

	[TestClass]
	public class TestLList2 : TestList
	{
		internal override IList MakeList()
		{
			return new LList2();
		}
	}

	[TestClass]
	public class TestLListR : TestList
	{
		internal override IList MakeList()
		{
			return new LListR();
		}
	}

	[TestClass]
	public class TestAListR : TestList
	{
		internal override IList MakeList()
		{
			return new AListR();
		}
	}

	[TestClass]
	public class TestLListF : TestList
	{
		internal override IList MakeList()
		{
			return new LListF();
		}
	}

	[TestClass]
	public abstract class TestList
	{
		IList lst;
		internal abstract IList MakeList();

		public TestList()
		{
			lst = MakeList();
		}

		//[TestInitialize]
		//public void ClearList() {
		//	_list.Clear();
		//}

		[DataTestMethod]
		[DataRow(null, new int[] { })]
		[DataRow(new int[] { }, new int[] { })]
		[DataRow(new int[] { 1 }, new int[] { 1 })]
		[DataRow(new int[] { 1, 2 }, new int[] { 1, 2 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
		public void TestInit(int[] input, int[] expected)
		{
			lst.Init(expected);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		[DataTestMethod]
		[DataRow(null, 0)]
		[DataRow(new int[] { }, 0)]
		[DataRow(new int[] { 1 }, 1)]
		[DataRow(new int[] { 1, 2 }, 2)]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 5)]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 6)]
		public void TestSize(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.Size());
		}

		[DataTestMethod]
		[DataRow(null)]
		[DataRow(new int[] { })]
		[DataRow(new int[] { 1 })]
		[DataRow(new int[] { 1, 2 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 })]
		public void TestClear(int[] input)
		{
			lst.Init(input);
			lst.Clear();
			Assert.AreEqual(0, lst.Size());
		}

		[DataTestMethod]
		[DataRow(null, "")]
		[DataRow(new int[] { }, "")]
		[DataRow(new int[] { 1 }, "1")]
		[DataRow(new int[] { 1, 2 }, "1 2")]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, "1 2 3 4 5")]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, "1 2 3 4 5 6")]
		public void TestToString(int[] input, string expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.ToString());
		}

		[DataTestMethod]
		[DataRow(null, new int[] { })]
		[DataRow(new int[] { }, new int[] { })]
		[DataRow(new int[] { 1 }, new int[] { 1 })]
		[DataRow(new int[] { 1, 2 }, new int[] { 1, 2 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
		public void TestToArray(int[] input, int[] expected)
		{
			lst.Init(expected);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}


		[DataTestMethod]
		[DataRow(null, new int[] { 1 })]
		[DataRow(new int[] { }, new int[] { 1 })]
		[DataRow(new int[] { 1 }, new int[] { 1, 1 })]
		[DataRow(new int[] { 1, 2 }, new int[] { 1, 1, 2 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 1, 2, 3, 4, 5 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 1, 2, 3, 4, 5, 6 })]
		public void TestAddStart(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.AddStart(1);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}


		[DataTestMethod]
		[DataRow(null, new int[] { 1 })]
		[DataRow(new int[] { }, new int[] { 1 })]
		[DataRow(new int[] { 1 }, new int[] { 1, 1 })]
		[DataRow(new int[] { 1, 2 }, new int[] { 1, 2, 1 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 1 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6, 1 })]
		public void TestAddEnd(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.AddEnd(1);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		[DataTestMethod]
		[DataRow(null, 0, new int[] { 1 })]
		[DataRow(new int[] { }, 0, new int[] { 1 })]
		[DataRow(new int[] { 1 }, 1, new int[] { 1, 1 })]
		[DataRow(new int[] { 1, 2 }, 1, new int[] { 1, 1, 2 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 1, 2, 3, 4, 5, 1 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 0, new int[] { 1, 1, 2, 3, 4, 5, 6 })]
		public void TestAddPos(int[] input, int pos, int[] expected)
		{
			lst.Init(input);
			lst.AddPos(pos, 1);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		[DataTestMethod]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, -1)]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 8)]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestAddPosOutOfRange(int[] input, int pos)
		{
			lst.Init(input);
			lst.AddPos(pos, 1);
		}


		[DataTestMethod]
		[DataRow(null)]
		[DataRow(new int[] { })]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestDelStartNullEmpty(int[] input)
		{
			lst.Init(input);
			lst.DelStart();
		}

		[DataTestMethod]
		[DataRow(new int[] { 1 }, new int[] { }, 1)]
		[DataRow(new int[] { 1, 2 }, new int[] { 2 }, 1)]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 }, 1)]
//		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 3, 4, 5, 6 }, 1)]
		public void TestDelStart(int[] input, int[] expectedList, int expectedVal)
		{
			lst.Init(input);
			int result = lst.DelStart();
			CollectionAssert.AreEqual(expectedList, lst.ToArray());
			Assert.AreEqual(expectedVal, result);
		}

		[DataTestMethod]
		[DataRow(null)]
		[DataRow(new int[] { })]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestDelEndNullEmpty(int[] input)
		{
			lst.Init(input);
			lst.DelEnd();
		}

		[DataTestMethod]
		[DataRow(new int[] { 1 }, new int[] { }, 1)]
		[DataRow(new int[] { 1, 2 }, new int[] { 1 }, 2)]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 }, 5)]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5 }, 6)]
		public void TestDelEnd(int[] input, int[] expectedList, int expectedVal)
		{
			lst.Init(input);
			int result = lst.DelEnd();
			CollectionAssert.AreEqual(expectedList, lst.ToArray());
			Assert.AreEqual(expectedVal, result);
		}

		[DataTestMethod]
		[DataRow(null)]
		[DataRow(new int[] { })]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestDelPosNullEmpty(int[] input)
		{
			lst.Init(input);
			lst.DelPos(0);
		}

		[DataTestMethod]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, -1)]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 8)]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestDelPosOutOfRange(int[] input, int pos)
		{
			lst.Init(input);
			lst.DelPos(pos);
		}

		[DataTestMethod]
		[DataRow(new int[] { 1 }, 0, new int[] { }, 1)]
		[DataRow(new int[] { 1, 2 }, 1, new int[] { 1 }, 2)]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 4, 5 }, 3)]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 5, new int[] { 1, 2, 3, 4, 5 }, 6)]
		public void TestDelPos(int[] input, int pos, int[] expectedList, int expectedVal)
		{
			lst.Init(input);
			int result = lst.DelPos(pos);
			CollectionAssert.AreEqual(expectedList, lst.ToArray());
			Assert.AreEqual(expectedVal, result);
		}

		[DataTestMethod]
		[DataRow(new int[] { })]
		[DataRow(null)]
		[ExpectedException(typeof(EmptyArrayEx))]
		public void TestMinNullEmpty(int[] input)
		{
			lst.Init(input);
			lst.Min();
		}

		[DataTestMethod]
		[DataRow(new int[] { 1 }, 1)]
		[DataRow(new int[] { 1, 2 }, 1)]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 1)]
		[DataRow(new int[] { 5, 4, 3, 2, 1 }, 1)]
		public void TestMin(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.Min());
		}

		[DataTestMethod]
		[DataRow(new int[] { })]
		[DataRow(null)]
		[ExpectedException(typeof(EmptyArrayEx))]
		public void TestMaxNullEmpty(int[] input)
		{
			lst.Init(input);
			lst.Max();
		}

		[DataTestMethod]
		[DataRow(new int[] { 1 }, 1)]
		[DataRow(new int[] { 1, 4 }, 4)]
		[DataRow(new int[] { 1, 2, 1 }, 2)]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 1 }, 5)]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 1 }, 7)]
		public void TestMax(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.Max());
		}

		[DataTestMethod]
		[DataRow(new int[] { })]
		[DataRow(null)]
		[ExpectedException(typeof(EmptyArrayEx))]
		public void TestMinPosNullEmpty(int[] input)
		{
			lst.Init(input);
			lst.MinPos();
		}

		[DataTestMethod]
		[DataRow(new int[] { 4 }, 0)]
		[DataRow(new int[] { 3, 4 }, 0)]
		[DataRow(new int[] { 4, 3, 2, 1, 0 }, 4)]
		public void TestMinPos(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.MinPos());
		}

		[DataTestMethod]
		[DataRow(new int[] { })]
		[DataRow(null)]
		[ExpectedException(typeof(EmptyArrayEx))]
		public void TestMaxPosNullEmpty(int[] input)
		{
			lst.Init(input);
			lst.MaxPos();
		}

		[DataTestMethod]
		[DataRow(new int[] { 4 }, 0)]
		[DataRow(new int[] { 3, 4 }, 1)]
		[DataRow(new int[] { 4, 3, 2, 1, 0 }, 0)]
		public void TestMaxPos(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.MaxPos());
		}

		[DataTestMethod]
		[DataRow(null, 0)]
		[DataRow(new int[] { }, 0)]
		[DataRow(new int[] { 1 }, -1)]
		[DataRow(new int[] { 1 }, 2)]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestSetOutOfRange(int[] input, int pos)
		{
			lst.Init(input);
			lst.Set(pos, 0);
		}

		[DataTestMethod]
		[DataRow(new int[] { 1 }, 0, 10, new int[] { 10 })]
		[DataRow(new int[] { 1, 2 }, 1, 10, new int[] { 1, 10 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, 22, new int[] { 1, 2, 22, 4, 5 })]
		[DataRow(new int[] { 5, 4, 3, 2, 1 }, 4, 15, new int[] { 5, 4, 3, 2, 15 })]
		public void TestSet(int[] input, int pos, int val, int[] expected)
		{
			lst.Init(input);
			lst.Set(pos, val);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		[DataTestMethod]
		[DataRow(null, 0)]
		[DataRow(new int[] { }, 0)]
		[DataRow(new int[] { 1 }, -1)]
		[DataRow(new int[] { 1 }, 2)]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestGetOutOfRange(int[] input, int pos)
		{
			lst.Init(input);
			lst.Get(pos);
		}

		[DataTestMethod]
		[DataRow(new int[] { 1 }, 0, 1)]
		[DataRow(new int[] { 1, 2 }, 1, 2)]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 3, 4)]
		[DataRow(new int[] { 5, 4, 3, 2, 1 }, 4, 1)]
		public void TestGet(int[] input, int pos, int val)
		{
			lst.Init(input);
			Assert.AreEqual(val, lst.Get(pos));
		}

		[DataTestMethod]
		[DataRow(null, new int[] { })]
		[DataRow(new int[] { }, new int[] { })]
		[DataRow(new int[] { 1 }, new int[] { 1 })]
		[DataRow(new int[] { 3, 1 }, new int[] { 1, 3 })]
		[DataRow(new int[] { 5, 7, 3, 3, 1 }, new int[] { 1, 3, 3, 5, 7 })]
		public void TestSort(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.Sort();
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		[DataTestMethod]
		[DataRow(null, new int[] { })]
		[DataRow(new int[] { }, new int[] { })]
		[DataRow(new int[] { 1 }, new int[] { 1 })]
		[DataRow(new int[] { 3, 1 }, new int[] { 1, 3 })]
		[DataRow(new int[] { 5, 7, 3, 3, 1 }, new int[] { 1, 3, 3, 7, 5 })]
		public void TestReverse(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.Reverse();
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		[DataTestMethod]
		[DataRow(new int[] { }, new int[] { })]
		[DataRow(new int[] { 1 }, new int[] { 1 })]
		[DataRow(new int[] { 1, 2 }, new int[] { 2, 1 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
		public void TestHalfReverse(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.HalfReverse();
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		[DataTestMethod]
		[DataRow(null)]
		[DataRow(new int[] { })]
		[DataRow(new int[] { 1 })]
		[DataRow(new int[] { 1, 2 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 })]
		public void TestForeach(int[] input)
		{
			lst.Init(input);
			int i = 0;
			foreach (int item in lst)
			{
				Assert.AreEqual(input[i++], item);
			}
		}
	}
}