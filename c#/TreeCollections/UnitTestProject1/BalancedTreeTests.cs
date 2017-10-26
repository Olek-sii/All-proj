using NUnit.Framework;
using TreeCollections;

namespace UnitTestProject1
{
	[TestFixture(typeof(AvlBsTree))]
	public class BalancedTreeNUnitTest<TTree> where TTree : ITree, new()
	{
		ITree lst = null;

		[SetUp]
		public void SetUp()
		{
			lst = new TTree();
		}

		[TestCase(null, new int[] { })]
		[TestCase(new int[] { }, new int[] { })]
		[TestCase(new int[] { 2 }, new int[] { 2 })]
		[TestCase(new int[] { 5, 6 }, new int[] { 5, 6 })]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, new int[] { 1, 3, 4, 7, 9 })]
		public void TestToArray(int[] input, int[] res)
		{
			lst.Init(input);
			CollectionAssert.AreEqual(res, lst.ToArray());
		}

		[TestCase(null, new int[] { })]
		[TestCase(new int[] { }, new int[] { })]
		[TestCase(new int[] { 2 }, new int[] { 2 })]
		[TestCase(new int[] { 5, 6 }, new int[] { 5, 6 })]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, new int[] { 1, 3, 4, 7, 9 })]
		public void TestInit(int[] input, int[] res)
		{
			lst.Init(input);
			CollectionAssert.AreEqual(res, lst.ToArray());
		}

		[TestCase(null, "")]
		[TestCase(new int[] { }, "")]
		[TestCase(new int[] { 2 }, "2")]
		[TestCase(new int[] { 5, 6 }, "5, 6")]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, "1, 3, 4, 7, 9")]
		public void TestToString(int[] input, string res)
		{
			lst.Init(input);
			Assert.AreEqual(res, lst.ToString());
		}

		[TestCase(null, 0)]
		[TestCase(new int[] { }, 0)]
		[TestCase(new int[] { 2 }, 1)]
		[TestCase(new int[] { 5, 6 }, 2)]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, 5)]
		public void TestSize(int[] input, int res)
		{
			lst.Init(input);
			Assert.AreEqual(res, lst.Size());
		}

		[Test]
		[TestCase(null, 0)]
		[TestCase(new int[] { }, 0)]
		[TestCase(new int[] { 2 }, 1)]
		[TestCase(new int[] { 5, 6 }, 2)]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, 3)]
		[TestCase(new int[] { 3, 7, 4, 9, 1, 12, 2, -5, 5 }, 4)]
		public void TestHeight(int[] input, int res)
		{
			lst.Init(input);
			Assert.AreEqual(res, lst.Height());
		}

		[Test]
		[TestCase(null, 0)]
		[TestCase(new int[] { }, 0)]
		[TestCase(new int[] { 2 }, 1)]
		[TestCase(new int[] { 5, 6 }, 1)]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, 2)]
		[TestCase(new int[] { 3, 7, 4, 9, 1, 12, 2, -5, 5 }, 4)]
		public void TestWidth(int[] input, int res)
		{
			lst.Init(input);
			Assert.AreEqual(res, lst.Width());
		}

		[Test]
		[TestCase(null, 0)]
		[TestCase(new int[] { }, 0)]
		[TestCase(new int[] { 2 }, 0)]
		[TestCase(new int[] { 5, 6 }, 1)]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, 3)]
		public void TestNodes(int[] input, int res)
		{
			lst.Init(input);
			Assert.AreEqual(res, lst.Nodes());
		}

		[Test]
		[TestCase(null, 0)]
		[TestCase(new int[] { }, 0)]
		[TestCase(new int[] { 2 }, 1)]
		[TestCase(new int[] { 5, 6 }, 1)]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, 2)]
		public void TestLeafs(int[] input, int res)
		{
			lst.Init(input);
			Assert.AreEqual(res, lst.Leafs());
		}

		[TestCase(null, new int[] { 1 }, 1)]
		[TestCase(new int[] { }, new int[] { 2 }, 2)]
		[TestCase(new int[] { 2 }, new int[] { 2, 0 }, 0)]
		[TestCase(new int[] { 5, 8 }, new int[] { 5, 8, 6 }, 6)]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, new int[] { 4, 1, 0, 3, 7, 9 }, 0)]
		public void TestAdd(int[] input, int[] res, int val)
		{
			ITree compare = new TTree();
			compare.Init(res);
			lst.Init(input);
			lst.Add(val);
			Assert.IsTrue(lst.Equals(compare));
		}

		[TestCase(new int[] { 2 }, new int[] { }, 2)]
		[TestCase(new int[] { 5, 8 }, new int[] { 5 }, 8)]
		[TestCase(new int[] { 3, 7, 1, 0, 9, 2, 8 }, new int[] { 3, 1, 8, 0, 7, 9 }, 2)]
		[TestCase(new int[] { 3, 7, 1, 0, 9, 2, 8 }, new int[] { 3, 2, 7, 0, 9, 8 }, 1)]
		public void TestDel(int[] input, int[] res, int val)
		{
			ITree compare = new TTree();
			compare.Init(res);
			lst.Init(input);
			lst.Del(val);
			Assert.IsTrue(lst.Equals(compare));
		}

		[TestCase(null, new int[] { })]
		[TestCase(new int[] { }, new int[] { })]
		[TestCase(new int[] { 2 }, new int[] { 2 })]
		[TestCase(new int[] { 5, 6 }, new int[] { 6, 5 })]
		[TestCase(new int[] { 3, 7, 4, 9, 1 }, new int[] { 9, 7, 4, 3, 1 })]
		public void TestReverse(int[] input, int[] res)
		{
			lst.Init(input);
			lst.Reverse();
			CollectionAssert.AreEqual(res, lst.ToArray());
		}

		[TestCase(null)]
		[TestCase(new int[] { })]
		[TestCase(new int[] { 1 })]
		[TestCase(new int[] { 1, 2 })]
		[TestCase(new int[] { 3, 7, 4, 9, 1 })]
		public void TestEquals(int[] input)
		{
			ITree compare = new TTree();
			compare.Init(input);
			lst.Init(input);
			Assert.IsTrue(lst.Equals(compare));
			lst.Add(10);
			Assert.IsFalse(lst.Equals(compare));
		}
	}
}