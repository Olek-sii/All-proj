using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
	public class AList0 : IList
	{
		public void Init(int[] ini)
		{
			if (ini == null)
			{
				_data = new int[0];
			}
			else
			{
				_data = new int[ini.Length];
				for (int i = 0; i < ini.Length; i++)
				{
					_data[i] = ini[i];
				}
			}

		}

		public int Size()
		{
			return _data.Length;
		}

		public void Clear()
		{
			_data = new int[0];
		}

		public override String ToString()
		{
			string result = "";
			for (int i = 0; i < _data.Length; i++)
			{
				result += _data[i] + " ";
			}
			return result.Trim();
		}

		public int[] ToArray()
		{
			return _data;
		}


		public void AddStart(int val)
		{
			AddPos(0, val);
		}

		public void AddEnd(int val)
		{
			AddPos(_data.Length, val);
		}

		public void AddPos(int pos, int val)
		{
			if (pos < 0 || pos > _data.Length)
			{
				throw new ArgumentOutOfRangeException();
			}

			int[] temp = new int[_data.Length + 1];
			temp[pos] = val;
			for (int i = 0; i < pos; i++)
			{
				temp[i] = _data[i];
			}
			for (int i = pos + 1; i < temp.Length; i++)
			{
				temp[i] = _data[i - 1];
			}
			_data = temp;
		}

		public int DelStart()
		{
			return DelPos(0);
		}

		public int DelEnd()
		{
			return DelPos(_data.Length - 1);
		}

		public int DelPos(int pos)
		{
			if (pos < 0 || pos >= _data.Length)
			{
				throw new ArgumentOutOfRangeException();
			}

			int[] temp = new int[_data.Length - 1];
			int result = _data[pos];
			for (int i = 0; i < pos; i++)
			{
				temp[i] = _data[i];
			}
			for (int i = pos + 1; i < _data.Length; i++)
			{
				temp[i - 1] = _data[i];
			}
			_data = temp;
			return result;
		}

		public int Min()
		{
			if (_data.Length == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = _data[0];
			foreach (int i in _data)
			{
				if (i < result)
				{
					result = i;
				}
			}
			return result;
		}

		public int Max()
		{
			if (_data.Length == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = _data[0];
			foreach (int i in _data)
			{
				if (i > result)
				{
					result = i;
				}
			}
			return result;
		}

		public int MinPos()
		{
			if (_data.Length == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = 0;
			for (int i = 0; i < _data.Length; i++)
			{
				if (_data[i] < _data[result])
				{
					result = i;
				}
			}
			return result;
		}

		public int MaxPos()
		{
			if (_data.Length == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = 0;
			for (int i = 0; i < _data.Length; i++)
			{
				if (_data[i] > _data[result])
				{
					result = i;
				}
			}
			return result;
		}

		public void Set(int pos, int val)
		{
			if (pos < 0 || pos >= _data.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			_data[pos] = val;
		}

		public int Get(int pos)
		{
			if (pos < 0 || pos >= _data.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			return _data[pos];
		}

		public void Sort()
		{
			for (int i = 0; i < _data.Length; i++)
			{
				for (int j = 0; j < _data.Length - 1; j++)
				{
					if (_data[j] > _data[j + 1])
					{
						int temp = _data[j + 1];
						_data[j + 1] = _data[j];
						_data[j] = temp;
					}
				}
			}
		}

		public void Reverse()
		{
			int size = _data.Length;
			for (int i = 0; i < size / 2; ++i)
			{
				int temp = _data[i];
				_data[i] = _data[size - i - 1];
				_data[size - i - 1] = temp;
			}
		}

		public void HalfReverse()
		{
			int size = _data.Length;
			int halfSize = size / 2 + size % 2;
			for (int i = 0; i < halfSize - size % 2; ++i)
			{
				int temp = _data[i];
				_data[i] = _data[halfSize + i];
				_data[halfSize + i] = temp;
			}
		}

		public IEnumerator<int> GetEnumerator()
		{
			foreach(int item in _data)
			{
				yield return item;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		int[] _data = null;
	}
}