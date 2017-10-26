using System;
using NUnit.Framework;
using List;

namespace ListNUnitTest
{
	[TestFixture(typeof(AList0))]
	[TestFixture(typeof(AList1))]
	[TestFixture(typeof(AList2))]
	[TestFixture(typeof(AListR))]
	[TestFixture(typeof(LList1))]
	[TestFixture(typeof(LList2))]
	[TestFixture(typeof(LListR))]
	[TestFixture(typeof(LListF))]
	public class ListNUnitTests<TPage> where TPage : IList, new()
	{
		IList lst = new TPage();

		[SetUp]
		public void SetUp()
		{
			lst.Clear();
		}


		[TestCase(null, new int[] { })]
		[TestCase(new int[] { }, new int[] { })]
		[TestCase(new int[] { 1 }, new int[] { 1 })]
		[TestCase(new int[] { 1, 2 }, new int[] { 1, 2 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
		public void TestInit(int[] input, int[] expected)
		{
			lst.Init(expected);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		
		[TestCase(null, 0)]
		[TestCase(new int[] { }, 0)]
		[TestCase(new int[] { 1 }, 1)]
		[TestCase(new int[] { 1, 2 }, 2)]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 6)]
		public void TestSize(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.Size());
		}

		
		[TestCase(null)]
		[TestCase(new int[] { })]
		[TestCase(new int[] { 1 })]
		[TestCase(new int[] { 1, 2 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
		public void TestClear(int[] input)
		{
			lst.Init(input);
			lst.Clear();
			Assert.AreEqual(0, lst.Size());
		}

		
		[TestCase(null, "")]
		[TestCase(new int[] { }, "")]
		[TestCase(new int[] { 1 }, "1")]
		[TestCase(new int[] { 1, 2 }, "1 2")]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, "1 2 3 4 5")]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, "1 2 3 4 5 6")]
		public void TestToString(int[] input, string expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.ToString());
		}

		
		[TestCase(null, new int[] { })]
		[TestCase(new int[] { }, new int[] { })]
		[TestCase(new int[] { 1 }, new int[] { 1 })]
		[TestCase(new int[] { 1, 2 }, new int[] { 1, 2 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
		public void TestToArray(int[] input, int[] expected)
		{
			lst.Init(expected);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}


		
		[TestCase(null, new int[] { 1 })]
		[TestCase(new int[] { }, new int[] { 1 })]
		[TestCase(new int[] { 1 }, new int[] { 1, 1 })]
		[TestCase(new int[] { 1, 2 }, new int[] { 1, 1, 2 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 1, 2, 3, 4, 5 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 1, 2, 3, 4, 5, 6 })]
		public void TestAddStart(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.AddStart(1);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}


		
		[TestCase(null, new int[] { 1 })]
		[TestCase(new int[] { }, new int[] { 1 })]
		[TestCase(new int[] { 1 }, new int[] { 1, 1 })]
		[TestCase(new int[] { 1, 2 }, new int[] { 1, 2, 1 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 1 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6, 1 })]
		public void TestAddEnd(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.AddEnd(1);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		
		[TestCase(null, 0, new int[] { 1 })]
		[TestCase(new int[] { }, 0, new int[] { 1 })]
		[TestCase(new int[] { 1 }, 1, new int[] { 1, 1 })]
		[TestCase(new int[] { 1, 2 }, 1, new int[] { 1, 1, 2 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 1, 2, 3, 4, 5, 1 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, new int[] { 1, 1, 2, 3, 4, 5, 6 })]
		public void TestAddPos(int[] input, int pos, int[] expected)
		{
			lst.Init(input);
			lst.AddPos(pos, 1);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, -1)]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 8)]
		public void TestAddPosOutOfRange(int[] input, int pos)
		{
			lst.Init(input);
			Assert.Throws<ArgumentOutOfRangeException>(() => lst.AddPos(pos, 1));
		}


		
		[TestCase(null)]
		[TestCase(new int[] { })]
		public void TestDelStartNullEmpty(int[] input)
		{
			lst.Init(input);
			Assert.Throws<ArgumentOutOfRangeException>(() => lst.DelStart());
		}

		
		[TestCase(new int[] { 1 }, new int[] { }, 1)]
		[TestCase(new int[] { 1, 2 }, new int[] { 2 }, 1)]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 }, 1)]
		//		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 3, 4, 5, 6 }, 1)]
		public void TestDelStart(int[] input, int[] expectedList, int expectedVal)
		{
			lst.Init(input);
			int result = lst.DelStart();
			CollectionAssert.AreEqual(expectedList, lst.ToArray());
			Assert.AreEqual(expectedVal, result);
		}

		
		[TestCase(null)]
		[TestCase(new int[] { })]
		public void TestDelEndNullEmpty(int[] input)
		{
			lst.Init(input);
			Assert.Throws<ArgumentOutOfRangeException>(() => lst.DelEnd());
		}

		
		[TestCase(new int[] { 1 }, new int[] { }, 1)]
		[TestCase(new int[] { 1, 2 }, new int[] { 1 }, 2)]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 }, 5)]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5 }, 6)]
		public void TestDelEnd(int[] input, int[] expectedList, int expectedVal)
		{
			lst.Init(input);
			int result = lst.DelEnd();
			CollectionAssert.AreEqual(expectedList, lst.ToArray());
			Assert.AreEqual(expectedVal, result);
		}

		
		[TestCase(null)]
		[TestCase(new int[] { })]
		public void TestDelPosNullEmpty(int[] input)
		{
			lst.Init(input);
			Assert.Throws<ArgumentOutOfRangeException>(() => lst.DelPos(0));
		}

		
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, -1)]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 8)]
		public void TestDelPosOutOfRange(int[] input, int pos)
		{
			lst.Init(input);
			Assert.Throws<ArgumentOutOfRangeException>(() => lst.DelPos(pos));
		}

		
		[TestCase(new int[] { 1 }, 0, new int[] { }, 1)]
		[TestCase(new int[] { 1, 2 }, 1, new int[] { 1 }, 2)]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 4, 5 }, 3)]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 5, new int[] { 1, 2, 3, 4, 5 }, 6)]
		public void TestDelPos(int[] input, int pos, int[] expectedList, int expectedVal)
		{
			lst.Init(input);
			int result = lst.DelPos(pos);
			CollectionAssert.AreEqual(expectedList, lst.ToArray());
			Assert.AreEqual(expectedVal, result);
		}

		
		[TestCase(new int[] { })]
		[TestCase(null)]
		public void TestMinNullEmpty(int[] input)
		{
			lst.Init(input);
			Assert.Throws<EmptyArrayEx>(() => lst.Min());
		}

		
		[TestCase(new int[] { 1 }, 1)]
		[TestCase(new int[] { 1, 2 }, 1)]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
		[TestCase(new int[] { 5, 4, 3, 2, 1 }, 1)]
		public void TestMin(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.Min());
		}

		
		[TestCase(new int[] { })]
		[TestCase(null)]
		public void TestMaxNullEmpty(int[] input)
		{
			lst.Init(input);
			Assert.Throws<EmptyArrayEx>(() => lst.Max());
		}

		
		[TestCase(new int[] { 1 }, 1)]
		[TestCase(new int[] { 1, 4 }, 4)]
		[TestCase(new int[] { 1, 2, 1 }, 2)]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 1 }, 5)]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 1 }, 7)]
		public void TestMax(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.Max());
		}

		
		[TestCase(new int[] { })]
		[TestCase(null)]
		public void TestMinPosNullEmpty(int[] input)
		{
			lst.Init(input);
			Assert.Throws<EmptyArrayEx>(() => lst.MinPos());
		}

		
		[TestCase(new int[] { 4 }, 0)]
		[TestCase(new int[] { 3, 4 }, 0)]
		[TestCase(new int[] { 4, 3, 2, 1, 0 }, 4)]
		public void TestMinPos(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.MinPos());
		}

		
		[TestCase(new int[] { })]
		[TestCase(null)]
		public void TestMaxPosNullEmpty(int[] input)
		{
			lst.Init(input);
			Assert.Throws<EmptyArrayEx>(() => lst.MaxPos());
		}

		
		[TestCase(new int[] { 4 }, 0)]
		[TestCase(new int[] { 3, 4 }, 1)]
		[TestCase(new int[] { 4, 3, 2, 1, 0 }, 0)]
		public void TestMaxPos(int[] input, int expected)
		{
			lst.Init(input);
			Assert.AreEqual(expected, lst.MaxPos());
		}

		
		[TestCase(null, 0)]
		[TestCase(new int[] { }, 0)]
		[TestCase(new int[] { 1 }, -1)]
		[TestCase(new int[] { 1 }, 2)]
		public void TestSetOutOfRange(int[] input, int pos)
		{
			lst.Init(input);
			Assert.Throws<ArgumentOutOfRangeException>(() => lst.Set(pos, 0));
		}

		
		[TestCase(new int[] { 1 }, 0, 10, new int[] { 10 })]
		[TestCase(new int[] { 1, 2 }, 1, 10, new int[] { 1, 10 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 22, new int[] { 1, 2, 22, 4, 5 })]
		[TestCase(new int[] { 5, 4, 3, 2, 1 }, 4, 15, new int[] { 5, 4, 3, 2, 15 })]
		public void TestSet(int[] input, int pos, int val, int[] expected)
		{
			lst.Init(input);
			lst.Set(pos, val);
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		
		[TestCase(null, 0)]
		[TestCase(new int[] { }, 0)]
		[TestCase(new int[] { 1 }, -1)]
		[TestCase(new int[] { 1 }, 2)]
		public void TestGetOutOfRange(int[] input, int pos)
		{
			lst.Init(input);
			Assert.Throws<ArgumentOutOfRangeException>(() => lst.Get(pos));
		}

		
		[TestCase(new int[] { 1 }, 0, 1)]
		[TestCase(new int[] { 1, 2 }, 1, 2)]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 4)]
		[TestCase(new int[] { 5, 4, 3, 2, 1 }, 4, 1)]
		public void TestGet(int[] input, int pos, int val)
		{
			lst.Init(input);
			Assert.AreEqual(val, lst.Get(pos));
		}

		
		[TestCase(null, new int[] { })]
		[TestCase(new int[] { }, new int[] { })]
		[TestCase(new int[] { 1 }, new int[] { 1 })]
		[TestCase(new int[] { 3, 1 }, new int[] { 1, 3 })]
		[TestCase(new int[] { 5, 7, 3, 3, 1 }, new int[] { 1, 3, 3, 5, 7 })]
		public void TestSort(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.Sort();
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		
		[TestCase(null, new int[] { })]
		[TestCase(new int[] { }, new int[] { })]
		[TestCase(new int[] { 1 }, new int[] { 1 })]
		[TestCase(new int[] { 3, 1 }, new int[] { 1, 3 })]
		[TestCase(new int[] { 5, 7, 3, 3, 1 }, new int[] { 1, 3, 3, 7, 5 })]
		public void TestReverse(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.Reverse();
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		
		[TestCase(new int[] { }, new int[] { })]
		[TestCase(new int[] { 1 }, new int[] { 1 })]
		[TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
		public void TestHalfReverse(int[] input, int[] expected)
		{
			lst.Init(input);
			lst.HalfReverse();
			CollectionAssert.AreEqual(expected, lst.ToArray());
		}

		[TestCase(null)]
		[TestCase(new int[] { })]
		[TestCase(new int[] { 1 })]
		[TestCase(new int[] { 1, 2 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5 })]
		[TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
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