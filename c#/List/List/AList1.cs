using System;
using System.Collections;
using System.Collections.Generic;

namespace List
{
	public class AList1 : IList
	{
		private void AddMemory(int n)
		{
			double new_size = n * 1.3;
			int[] temp = new int[(int)new_size];
			for (int i = 0; i < _data.Length; ++i)
			{
				temp[i] = _data[i];
			}
			_data = temp;
		}

		public void Init(int[] ini)
		{
			if (ini == null)
			{
				_top = 0;
			}
			else
			{
				_top = ini.Length;
				if (_top >= _data.Length)
					AddMemory(ini.Length);
				for (int i = 0; i < ini.Length; i++)
				{
					_data[i] = ini[i];
				}
			}
		}

		public int Size()
		{
			return _top;
		}

		public void Clear()
		{
			_top = 0;
		}

		public override String ToString()
		{
			string result = "";
			for (int i = 0; i < _top; i++)
			{
				result += _data[i] + " ";
			}
			return result.Trim();
		}

		public int[] ToArray()
		{
			int[] temp = new int[_top];
			for (int i = 0; i < _top; ++i)
			{
				temp[i] = _data[i];
			}
			return temp;
		}


		public void AddStart(int val)
		{
			AddPos(0, val);
		}

		public void AddEnd(int val)
		{
			AddPos(_top, val);
		}

		public void AddPos(int pos, int val)
		{
			if (pos > _top || pos < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (_top >= Size() - 1)
				AddMemory(_data.Length);
			for (int i = _top - 1; i >= pos; --i)
			{
				_data[i + 1] = _data[i];
			}
			_data[pos] = val;
			_top++;
		}

		public int DelStart()
		{
			return DelPos(0);
		}

		public int DelEnd()
		{
			return DelPos(_top - 1);
		}

		public int DelPos(int pos)
		{
			if (pos < 0 || pos >= _top)
			{
				throw new ArgumentOutOfRangeException();
			}

			int[] temp = new int[_top - 1];
			int result = _data[pos];
			for (int i = 0; i < pos; i++)
			{
				temp[i] = _data[i];
			}
			for (int i = pos + 1; i < _top; i++)
			{
				temp[i - 1] = _data[i];
			}
			_data = temp;
			_top--;
			return result;
		}

		public int Min()
		{
			if (_top == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = _data[0];
			for (int i = 0; i < _top; i++)
			{
				if (_data[i] < result)
				{
					result = _data[i];
				}
			}
			return result;
		}

		public int Max()
		{
			if (_top == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = _data[0];
			for (int i = 0; i < _top; i++)
			{
				if (_data[i] > result)
				{
					result = _data[i];
				}
			}
			return result;
		}

		public int MinPos()
		{
			if (_top == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = 0;
			for (int i = 0; i < _top; i++)
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
			if (_top == 0)
			{
				throw new EmptyArrayEx();
			}
			int result = 0;
			for (int i = 0; i < _top; i++)
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
			if (pos < 0 || pos >= _top)
			{
				throw new ArgumentOutOfRangeException();
			}
			_data[pos] = val;
		}

		public int Get(int pos)
		{
			if (pos < 0 || pos >= _top)
			{
				throw new ArgumentOutOfRangeException();
			}
			return _data[pos];
		}

		public void Sort()
		{
			for (int i = 0; i < _top; i++)
			{
				for (int j = 0; j < _top - 1; j++)
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
			int size = _top;
			for (int i = 0; i < size / 2; ++i)
			{
				int temp = _data[i];
				_data[i] = _data[size - i - 1];
				_data[size - i - 1] = temp;
			}
		}

		public void HalfReverse()
		{
			int size = _top;
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
			for (int i = 0; i < _top; i++)
			{
				yield return _data[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		int[] _data = new int[10];
		int _top = 0;
	}
}