using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
	public class LList1 : IList
	{
		class Node
		{
			public int Val { get; set; }
			public Node Next { get; set; }
			public Node(int val)
			{
				Val = val;
				Next = null;
			}
		}

		Node _root = null;

		public void Init(int[] ini)
		{
			if (ini == null)
				ini = new int[0];

			for (int i = ini.Length - 1; i >= 0; i--)
			{
				AddStart(ini[i]);
			}
		}

		public int Size()
		{
			int result = 0;
			Node temp = _root;
			while (temp != null)
			{
				result++;
				temp = temp.Next;
			}
			return result;
		}

		public void Clear()
		{
			_root = null;
		}

		public int[] ToArray()
		{
			int[] result = new int[Size()];
			Node temp = _root;
			int i = 0;
			while (temp != null)
			{
				result[i++] = temp.Val;
				temp = temp.Next;
			}
			return result;
		}

		public override String ToString()
		{
			string result = "";
			Node temp = _root;
			while (temp != null)
			{
				result += temp.Val + " ";
				temp = temp.Next;
			}
			return result.Trim();
		}

		public void AddStart(int val)
		{
			Node temp = new Node(val);
			temp.Next = _root;
			_root = temp;
		}

		public void AddEnd(int val)
		{
			AddPos(Size(), val);
		}

		public void AddPos(int pos, int val)
		{
			if (pos < 0 || pos > Size())
			{
				throw new ArgumentOutOfRangeException();
			}

			if (pos == 0)
			{
				AddStart(val);
			}
			else
			{
				Node temp = _root;
				int i = 0;
				while (i != pos - 1)
				{
					i++;
					temp = temp.Next;
				}
				Node newNode = new Node(val);
				newNode.Next = temp.Next;
				temp.Next = newNode;
			}
		}
		public int DelStart()
		{
			if (_root == null)
			{
				throw new ArgumentOutOfRangeException();
			}

			int result = _root.Val;
			_root = _root.Next;
			return result;
		}

		public int DelEnd()
		{
			return DelPos(Size() - 1);
		}

		public int DelPos(int pos)
		{
			if (pos < 0 || pos >= Size())
			{
				throw new ArgumentOutOfRangeException();
			}
			int result = 0;

			if (pos == 0)
			{
				result = DelStart();
			}
			else
			{
				Node temp = _root;
				int i = 0;
				while (i != pos - 1)
				{
					i++;
					temp = temp.Next;
				}
				result = temp.Next.Val;
				temp.Next = temp.Next.Next;
			}

			return result;
		}

		public int Min()
		{
			if (_root == null || Size() == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = _root.Val;
			Node temp = _root.Next;
			while (temp != null)
			{
				if (result > temp.Val)
				{
					result = temp.Val;
				}
				temp = temp.Next;
			}
			return result;
		}

		public int MinPos()
		{
			if (_root == null || Size() == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = 0;
			int i = 0;
			int minValue = _root.Val;
			Node temp = _root.Next;
			while (temp != null)
			{
				i++;
				if (minValue > temp.Val)
				{
					result = i;
					minValue = temp.Val;
				}
				temp = temp.Next;
			}
			return result;
		}

		public int Max()
		{
			if (_root == null || Size() == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = _root.Val;
			Node temp = _root.Next;
			while (temp != null)
			{
				if (result < temp.Val)
				{
					result = temp.Val;
				}
				temp = temp.Next;
			}
			return result;
		}

		public int MaxPos()
		{
			if (_root == null || Size() == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = 0;
			int i = 0;
			int maxValue = _root.Val;
			Node temp = _root.Next;
			while (temp != null)
			{
				i++;
				if (maxValue < temp.Val)
				{
					result = i;
					maxValue = temp.Val;
				}
				temp = temp.Next;
			}
			return result;
		}
		public void Set(int pos, int val)
		{
			if (pos < 0 || pos > Size() - 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			Node temp = _root;
			int i = 0;
			while (i != pos)
			{
				i++;
				temp = temp.Next;
			}
			temp.Val = val;
		}

		public int Get(int pos)
		{
			if (pos < 0 || pos > Size() - 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			Node temp = _root;
			int i = 0;
			while (i != pos)
			{
				i++;
				temp = temp.Next;
			}
			return temp.Val;
		}

		public void Sort()
		{
			int i = 0;
			Node tempI = _root;
			while (tempI != null)
			{
				int j = 0;
				Node tempJ = _root;
				while (tempJ.Next != null)
				{
					if (tempJ.Val > tempJ.Next.Val)
					{
						swap(tempJ, tempJ.Next);
					}
					tempJ = tempJ.Next;
				}
				tempI = tempI.Next;
			}
		}

		private void swap(Node lhs, Node rhs)
		{
			int temp = lhs.Val;
			lhs.Val = rhs.Val;
			rhs.Val = temp;
		}

		public void Reverse()
		{
			if (_root != null)
			{
				Node temp = new Node(_root.Val);
				temp.Next = _root.Next;
				Clear();
				while (temp != null)
				{
					AddStart(temp.Val);
					temp = temp.Next;
				}
			}
		}

		public void HalfReverse()
		{
			int size = Size();
			if (size == 1 || size == 0)
				return;

			Node last = _root;
			while (last.Next != null)
			{
				last = last.Next;
			}
			Node mid = _root;
			for (int i = 0; i < size / 2 - 1; i++)
			{
				mid = mid.Next;
			}
			if (size % 2 == 0)
			{
				last.Next = _root;
				_root = mid.Next;
				mid.Next = null;
			} else
			{
				Node temp = _root;
				last.Next = mid.Next;
				_root = mid.Next.Next;
				mid.Next.Next = temp;
				mid.Next = null;
			}
		}

		public IEnumerator<int> GetEnumerator()
		{
			Node temp = _root;
			while (temp != null)
			{
				yield return  temp.Val;
				temp = temp.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}