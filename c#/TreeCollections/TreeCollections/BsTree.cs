using System;
using System.Linq;

namespace TreeCollections
{
	public class BsTree : ITree
	{
		protected class Node
		{
			public int val;
			public Node left;
			public Node right;
			public Node(int val)
			{
				this.val = val;
			}
		}

		protected Node root = null;

		private void AddNode(Node node, int val)
		{
			if (val < node.val)
			{
				if (node.left == null)
					node.left = new Node(val);
				else
					AddNode(node.left, val);
			}
			else if (val > node.val)
			{
				if (node.right == null)
					node.right = new Node(val);
				else
					AddNode(node.right, val);
			}
		}

		public void Add(int val)
		{
			if (root == null)
				root = new Node(val);
			else
				AddNode(root, val);
		}

		public void Del(int val)
		{
			root = DoDelete(root, val);
		}

		private Node DoDelete(Node node, int val)
		{
			if (node == null)
				return node;

			if (val < node.val)
				node.left = DoDelete(node.left, val);
			else if (val > node.val)
				node.right = DoDelete(node.right, val);
			else
			{
				if (node.left == null)
					return node.right;
				else if (node.right == null)
					return node.left;

				Node min = Min(node.right);
				node.val = min.val;
				node.right = DoDelete(node.right, min.val);

			}
			return node;
		}

		private Node Min(Node node)
		{
			if (node == null)
				throw new ArgumentNullException();

			if (node.left == null)
				return node;
			return Min(node.left);
		}

		public int Height()
		{
			return CountHeight(root, 0);
		}

		private int CountHeight(Node node, int depth)
		{
			if (node == null)
				return depth;

			return Math.Max(CountHeight(node.left, depth + 1), CountHeight(node.right, depth + 1));
		}

		public void Init(int[] ini)
		{
			if (ini == null)
				return;

			for (int i = 0; i < ini.Length; i++)
			{
				Add(ini[i]);
			}
		}

		public int Leafs()
		{
			return CountLeafs(root);
		}

		private int CountLeafs(Node node)
		{
			if (node == null)
				return 0;

			int res = 0;
			if (node.left == null && node.right == null)
				res = 1;

			return CountLeafs(node.left) + CountLeafs(node.right) + res;
		}

		public int Nodes()
		{
			return CountNodes(root);
		}

		private int CountNodes(Node node)
		{
			if (node == null)
				return 0;

			int res = 0;
			if (node.left != null || node.right != null)
				res = 1;

			return CountNodes(node.left) + CountNodes(node.right) + res;
		}

		public void Reverse()
		{
			DoReverse(root);
		}

		private void DoReverse(Node node)
		{
			if (node != null)
			{
				Node temp = node.left;
				node.left = node.right;
				node.right = temp;

				DoReverse(node.left);
				DoReverse(node.right);
			}
		}

		public int Size()
		{
			return CountSize(root);
		}

		private int CountSize(Node node)
		{
			if (node == null)
				return 0;
			return CountSize(node.left) + CountSize(node.right) + 1;
		}

		public int[] ToArray()
		{
			int[] res = new int[Size()];
			int i = 0;
			NodeToArray(root, res, ref i);
			return res;
		}

		private void NodeToArray(Node node, int[] res, ref int i)
		{
			if (node == null)
				return;

			NodeToArray(node.left, res, ref i);
			res[i++] = node.val;
			NodeToArray(node.right, res, ref i);
		}

		public int Width()
		{
			if (root == null)
				return 0;

			int[] ret = new int[Height()];
			GetWidth(root, ret, 0);
			return ret.Max();
		}
		private void GetWidth(Node node, int[] levels, int level)
		{
			if (node == null)
				return;

			GetWidth(node.left, levels, level + 1);
			levels[level]++;
			GetWidth(node.right, levels, level + 1);
		}

		public override String ToString()
		{
			return NodeToString(root).TrimEnd(new char[] { ',', ' ' });
		}

		private String NodeToString(Node node)
		{
			if (node == null)
				return "";

			String str = "";
			str += NodeToString(node.left);		//L
			str += node.val + ", ";				//V
			str += NodeToString(node.right);	//R
			return str;
		}

		private bool CompareNodes(Node p1, Node p2)
		{
			if (p1 == null && p2 == null)
				return true;
			if (p1 == null || p2 == null)
				return false;

			bool equal = p1.val == p2.val;
			return equal && CompareNodes(p1.left, p2.left) && CompareNodes(p1.right, p2.right);
		}

		public bool Equals(ITree other)
		{
			return CompareNodes(root, (other as BsTree).root);
		}
	}
}