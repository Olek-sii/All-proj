using System;

namespace HW_1
{
	public class _3
	{
		public static int min(int[] arr)
		{
			if (arr == null || arr.Length == 0)
			{
				throw new ArgumentException();
			}

			int min = arr[0];
			foreach (int i in arr)
			{
				if (i < min)
				{
					min = i;
				}
			}
			return min;
		}

		public static int max(int[] arr)
		{
			if (arr == null || arr.Length == 0)
			{
				throw new ArgumentException();
			}

			int max = arr[0];
			foreach (int i in arr)
			{
				if (i > max)
				{
					max = i;
				}
			}
			return max;
		}


		public static int minIndex(int[] arr)
		{
			if (arr == null || arr.Length == 0)
			{
				throw new ArgumentException();
			}

			int min = 0;
			int currI = 0;
			foreach (int i in arr)
			{
				if (i < arr[min])
				{
					min = currI;
				}
				++currI;
			}
			return min;
		}

		public static int maxIndex(int[] arr)
		{
			if (arr == null || arr.Length == 0)
			{
				throw new ArgumentException();
			}

			int max = 0;
			int currI = 0;
			foreach (int i in arr)
			{
				if (i > arr[max])
				{
					max = currI;
				}
				++currI;
			}
			return max;
		}

		public static int sumOddIndex(int[] input)
		{
			if (input == null || input.Length == 0)
			{
				throw new ArgumentException();
			}

			int result = 0;
			for (int i = 1; i < input.Length; i += 2)
			{
				result += input[i];
			}
			return result;
		}

		public static void reverse(int[] input)
		{
			if (input == null)
			{
				return;
			}
			int size = input.Length;
			for (int i = 0; i < size / 2; ++i)
			{
				int temp = input[i];
				input[i] = input[size - i - 1];
				input[size - i - 1] = temp;
			}
		}

		public static int getOddNum(int[] input)
		{
			if (input == null)
			{
				throw new ArgumentNullException();
			}

			int count = 0;
			foreach (int i in input)
			{
				if (i % 2 == 1)
				{
					++count;
				}
			}
			return count;
		}

		public static void halfReverse(int[] input)
		{
			if (input == null)
			{
				return;
			}

			int size = input.Length;
			int halfSize = size / 2 + size % 2;
			for (int i = 0; i < halfSize - size % 2; ++i)
			{
				int temp = input[i];
				input[i] = input[halfSize + i];
				input[halfSize + i] = temp;
			}
		}

		public static void insertSort(int[] input)
		{
			if (input == null)
			{
				return;
			}
			for (int i = 1; i < input.Length; i++)
			{
				int temp = input[i];
				int j = i - 1;
				while ((j >= 0) && (input[j] > temp))
				{
					input[j + 1] = input[j];
					j--;
				}
				input[j + 1] = temp;
			}
		}

		public static void selectSort(int[] input)
		{
			if (input == null)
			{
				return;
			}

			for (int i = 0; i < input.Length - 1; i++)
			{
				int min = i;
				for (int j = i + 1; j < input.Length; j++)
				{
					if (input[j] < input[min])
					{
						min = j;
					}
				}

				int temp = input[i];
				input[i] = input[min];
				input[min] = temp;
			}
		}

		public static void bubbleSort(int[] input)
		{
			if (input == null)
			{
				return;
			}
			for (int i = 0; i < input.Length; i++)
			{
				for (int j = 0; j < input.Length - i - 1; j++)
				{
					if (input[j] > input[j + 1])
					{
						int temp = input[j];
						input[j] = input[j + 1];
						input[j + 1] = temp;
					}
				}
			}
		}

		public static int[] MergeSort(int[] source)
		{
			return Split(source);
		}

		private static int[] Split(int[] from)
		{
			if (from.Length == 1)
			{
				// size <= 1 considered sorted
				return from;
			}
			else
			{
				int iMiddle = from.Length / 2;
				int[] left = new int[iMiddle];
				for (int i = 0; i < iMiddle; i++)
				{
					left[i] = from[i];
				}
				int[] right = new int[from.Length - iMiddle];
				for (int i = iMiddle; i < from.Length; i++)
				{
					right[i - iMiddle] = from[i];
				}

				// Single threaded version
				int[] sLeft = Split(left);
				int[] sRight = Split(right);

				int[] sorted = Merge(sLeft, sRight);

				return sorted;
			}
		}

		private static int[] Merge(int[] left, int[] right)
		{
			// each array will individually be sorted.
			// Do a sort of card merge to merge them in a sorted sequence
			int leftLen = left.Length;
			int rightLen = right.Length;
			int[] sorted = new int[leftLen + rightLen];

			int lIndex = 0;
			int rIndex = 0;
			int currentIndex = 0;

			while (lIndex < leftLen || rIndex < rightLen)
			{
				// If either has had all elements taken, just take remaining from the other.
				// If not, compare the two current and take the lower.
				if (lIndex >= leftLen)
				{
					sorted[currentIndex] = right[rIndex];
					rIndex++;
					currentIndex++;
				}
				else if (rIndex >= rightLen)
				{
					sorted[currentIndex] = left[lIndex];
					lIndex++;
					currentIndex++;
				}
				else if (left[lIndex].CompareTo(right[rIndex]) >= 0)
				{
					// l > r, so r goes into dest
					sorted[currentIndex] = right[rIndex];
					rIndex++;
					currentIndex++;
				}
				else
				{
					sorted[currentIndex] = left[lIndex];
					lIndex++;
					currentIndex++;
				}
			}

			return sorted;
		}

		private void ShellSort(int[] array)
		{
			int n = array.Length;
			int gap = n / 2;
			int temp;

			while (gap > 0)
			{
				for (int i = 0; i + gap < n; i++)
				{
					int j = i + gap;
					temp = array[j];

					while (j - gap >= 0 && temp < array[j - gap])
					{
						array[j] = array[j - gap];
						j = j - gap;
					}

					array[j] = temp;
				}
				gap = gap / 2;
			}
		}

	}
}