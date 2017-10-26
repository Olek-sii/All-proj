using System;
using System.Linq;

namespace TreeCollections
{
	public class AvlBsTree : ITree
	{
		protected class Node
		{
			public int val;
			public int height;
			public Node left;
			public Node right;
			public Node(int val)
			{
				this.val = val;
				this.height = 1;
			}
		}

		protected Node root = null;

		private int NodeHeight(Node p)
		{
			if (p == null)
				return 0;
			return p.height;
		}

		private int bfactor(Node p)
		{
			return NodeHeight(p.right) - NodeHeight(p.left);
		}

		private void fixheight(Node p)
		{
			int leftHeight = NodeHeight(p.left);
			int rightHeight = NodeHeight(p.right);
			p.height = Math.Max(leftHeight, rightHeight) + 1;
		}

		private Node rotateright(Node p) // правый поворот вокруг p
		{
			Node q = p.left;
			p.left = q.right;
			q.right = p;
			fixheight(p);
			fixheight(q);
			return q;
		}

		private Node rotateleft(Node q) // левый поворот вокруг q
		{
			Node p = q.right;
			q.right = p.left;
			p.left = q;
			fixheight(q);
			fixheight(p);
			return p;
		}

		Node balance(Node p) // балансировка узла p
		{
			fixheight(p);
			if (bfactor(p) == 2)
			{
				if (bfactor(p.right) < 0)
					p.right = rotateright(p.right);
				return rotateleft(p);
			}
			if (bfactor(p) == -2)
			{
				if (bfactor(p.left) > 0)
					p.left = rotateleft(p.left);
				return rotateright(p);
			}
			return p; // балансировка не нужна
		}

		Node AddNode(Node p, int val)
		{
			if (p == null)
				return new Node(val);

			if (val < p.val)
				p.left = AddNode(p.left, val);
			else
				p.right = AddNode(p.right, val);

			return balance(p);
		}

		public void Add(int val)
		{
			root = AddNode(root, val);
		}

		public void Del(int val)
		{
			root = DoDelete(root, val);
		}

		private Node DoDelete(Node p, int val)
		{
			if (p == null)
				return p;

			if (val < p.val)
				p.left = DoDelete(p.left, val);
			else if (val > p.val)
				p.right = DoDelete(p.right, val);
			else
			{
				if (p.right == null)
					return p.left;

				Node min = Min(p.right);
				p.val = min.val;
				p.right = DoDelete(p.right, min.val);
			}
			return balance(p);
		}

		private Node Min(Node node)
		{
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
			str += NodeToString(node.left);     //L
			str += node.val + ", ";             //V
			str += NodeToString(node.right);    //R
			return str;
		}

		private bool CompareNodes(Node curTree, Node tree)
		{
			if (curTree == null && tree == null)
				return true;
			if (curTree == null || tree == null)
				return false;

			bool equal = true;
			equal &= CompareNodes(curTree.left, tree.left);
			equal &= (curTree.val == tree.val);
			equal &= CompareNodes(curTree.right, tree.right);
			return equal;
		}

		public bool Equals(ITree other)
		{
			return CompareNodes(root, (other as AvlBsTree).root);
		}
	}
}