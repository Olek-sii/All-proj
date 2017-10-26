using System;
using System.Linq;

namespace TreeCollections
{
	public class BsTreeV : ITree
	{
		class Node
		{
			public int val;
			public Node left;
			public Node right;
			public Node(int val)
			{
				this.val = val;
			}
		}

		Node root = null;

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
			return CountHeight(root);
		}

		private int CountHeight(Node node)
		{
			if (node == null)
				return 0;

			return 1 + Math.Max(CountHeight(node.left), CountHeight(node.right));
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

		private bool CompareNodes(Node curTree, Node tree)
		{
			if (curTree == null && tree == null)
				return true;
			if (curTree == null || tree == null)
				return false;

			bool equal = false;
			equal = CompareNodes(curTree.left, tree.left);
			equal = equal & (curTree.val == tree.val);
			equal = CompareNodes(curTree.right, tree.right);
			return equal;
		}

		public bool Equals(ITree other)
		{
			return CompareNodes(root, (other as BsTreeV).root);
		}


		private void Visit(Node p, IVisitor v)
		{
			if (p == null)
				return;

			Visit(p.left, v);
			v.Action(p);
			Visit(p.right, v);
		}

		interface IVisitor
		{
			void Action(Node p);
		}

		class SizeVisitor : IVisitor
		{
			public int size = 0;
			public void Action(Node p)
			{
				size++;
			}
		}

		public int Size()
		{
			SizeVisitor v = new SizeVisitor();
			Visit(root, v);
			return v.size;
		}

		class ToArrayVisitor : IVisitor
		{
			public int[] arr;
			int i = 0;
			public ToArrayVisitor(int size)
			{
				arr = new int[size];
			}
			public void Action(Node p)
			{
				arr[i++] = p.val;
			}
		}

		public int[] ToArray()
		{
			ToArrayVisitor v = new ToArrayVisitor(Size());
			Visit(root, v);
			return v.arr;
		}

		class ToStringVisitor : IVisitor
		{
			public string str = "";
			public void Action(Node p)
			{
				str += p.val + ", ";
			}
		}

		public override string ToString()
		{
			ToStringVisitor v = new ToStringVisitor();
			Visit(root, v);
			return v.str.TrimEnd(new char[] { ',', ' ' });
		}

		class NodesVisitor : IVisitor
		{
			public int nodes = 0;
			public void Action(Node p)
			{
				if (p.left != null || p.right != null)
					nodes++;
			}
		}

		public int Nodes()
		{
			NodesVisitor v = new NodesVisitor();
			Visit(root, v);
			return v.nodes;
		}

		class LeafsVisitor : IVisitor
		{
			public int leafs = 0;
			public void Action(Node p)
			{
				if (p.left == null && p.right == null)
					leafs++;
			}
		}

		public int Leafs()
		{
			LeafsVisitor v = new LeafsVisitor();
			Visit(root, v);
			return v.leafs;
		}
	}
}