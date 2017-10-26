﻿using System;
using System.Collections.Generic;

namespace List
{
	public interface IList : IEnumerable<int>
	{
		void Init(int[] ini);
		int Size();
		void Clear();
		String ToString();
		int[] ToArray();


		void AddStart(int val);
		void AddEnd(int val);
		void AddPos(int pos, int val);

		int DelStart();
		int DelEnd();
		int DelPos(int pos);

		int Min();
		int Max();
		int MinPos();
		int MaxPos();

		void Set(int pos, int val);
		int Get(int pos);

		void Sort();
		void Reverse();
		void HalfReverse();
	}
}