using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListMsUnitTest
{
	[TestClass]
	public class AList1GrowUpTest : ListGrowUpTest
	{
		internal override IList MakeList()
		{
			return new AList1();
		}
	}

	[TestClass]
	public class AList2GrowUpTest : ListGrowUpTest
	{
		internal override IList MakeList()
		{
			return new AList2();
		}
	}

	[TestClass]
	public class AListRGrowUpTest : ListGrowUpTest
	{
		internal override IList MakeList()
		{
			return new AListR();
		}
	}

	[TestClass]
	public abstract class ListGrowUpTest
	{
		internal abstract IList MakeList();
		IList _list;
		public ListGrowUpTest()
		{
			_list = MakeList();
		}

		[DataTestMethod]
		[DataRow(30)]
		[DataRow(40)]
		[DataRow(50)]
		public void InitMore30(int n)
		{
			int[] arr = new int[n];
			int[] expected = new int[n];
			for (int i = 0; i < n; ++i)
			{
				arr[i] = i;
				expected[i] = i;
			}
			_list.Init(arr);
			CollectionAssert.AreEqual(expected, _list.ToArray());
		}

		[DataTestMethod]
		[DataRow(20, 10)]
		[DataRow(20, 20)]
		[DataRow(20, 30)]
		public void AddMore30(int ini_n, int add)
		{
			int[] arr = new int[ini_n];
			int[] expected = new int[ini_n + add];
			for (int i = 0; i < ini_n; ++i)
			{
				arr[i] = i;
				expected[i] = i;
			}

			_list.Init(arr);
			for (int i = ini_n; i < ini_n + add; ++i)
			{
				expected[i] = i;
				_list.AddEnd(i);
			}
			CollectionAssert.AreEqual(expected, _list.ToArray());
		}
	}
}