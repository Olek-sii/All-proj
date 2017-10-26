using System;

namespace ArraySort
{
	public class Sorts
	{
		public static void SortBubble(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length - 1 - i; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j + 1];
						arr[j + 1] = arr[j];
						arr[j] = temp;
					}
				}
			}
		}
		public static void SortSelect(int[] arr)
		{
			int i, j, min;
			for (i = 0; i < arr.Length; i++)
			{
				min = i;
				for (j = 0; j < arr.Length; j++)
				{
					if (arr[j] > arr[min])
					{
						min = j;
						int temp = arr[i];
						arr[i] = arr[min];
						arr[min] = temp;
					}
				}
			}
		}
		public static void SortInsert(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				for (int q = i; q > 0 && array[q - 1] > array[q]; q--)
				{
					int key = array[q - 1];
					array[q - 1] = array[q];
					array[q] = key;
				}
			}
		}
		//10. Сортировка слиянием.Merge
		public static void Merge(int[] arr)
		{
			if (arr == null)
				return;
			SortMerge(arr, 0, arr.Length - 1);
		}
		private static void ForMerge(int[] arr, int l, int m, int r)
		{
			// Find sizes of two subarrays to be merged
			int n1 = m - l + 1;
			int n2 = r - m;

			/* Create temp arrays */
			int[] L = new int[n1];
			int[] R = new int[n2];

			/*Copy data to temp arrays*/
			for (int z = 0; z < n1; ++z)
				L[z] = arr[l + z];
			for (int y = 0; y < n2; ++y)
				R[y] = arr[m + 1 + y];


			/* Merge the temp arrays */

			// Initial indexes of first and second subarrays
			int i = 0, j = 0;

			// Initial index of merged subarry array
			int k = l;
			while (i < n1 && j < n2)
			{
				if (L[i] <= R[j])
				{
					arr[k] = L[i];
					i++;
				}
				else
				{
					arr[k] = R[j];
					j++;
				}
				k++;
			}

			/* Copy remaining elements of L[] if any */
			while (i < n1)
			{
				arr[k] = L[i];
				i++;
				k++;
			}

			/* Copy remaining elements of R[] if any */
			while (j < n2)
			{
				arr[k] = R[j];
				j++;
				k++;
			}
		}

		// Main function that sorts arr[l..r] using
		private static void SortMerge(int[] arr, int l, int r)
		{
			if (l < r)
			{
				// Find the middle point
				int m = (l + r) / 2;

				// Sort first and second halves
				SortMerge(arr, l, m);
				SortMerge(arr, m + 1, r);

				// Merge the sorted halves
				ForMerge(arr, l, m, r);
			}
		}
		//10. Сортировка Шелла
		public static void Shell(int[] arr)
		{
			if (arr == null)
				return;
			int size = arr.Length;
			int step = size / 2;
			while (step > 0)//пока шаг не 0
			{
				for (int i = 0; i < (size - step); i++)
				{
					int j = i; //будем идти начиная с i-го элемента пока не пришли к началу массива
							   //и пока рассматриваемый элемент больше чем элемент находящийся на расстоянии шага
					while (j >= 0 && arr[j] > arr[j + step])
					{
						//меняем их местами
						int temp = arr[j];
						arr[j] = arr[j + step];
						arr[j + step] = temp;
						j--;
					}
				}
				step = step / 2;//уменьшаем шаг
			}
		}

		public static void Heap(int[] arr)
		{
			if (arr == null)
				return;
			int len = arr.Length;
			//step 1: building the pyramid
			for (int i = len / 2 - 1; i >= 0; --i)
			{
				int prev_i = i;
				i = Add2heap(arr, i, len);
				if (prev_i != i) ++i;
			}

			//step 2: sorting
			int buf;
			for (int k = len - 1; k > 0; --k)
			{
				buf = arr[0];
				arr[0] = arr[k];
				arr[k] = buf;
				int i = 0;
				int prev_i = -1;
				while (i != prev_i)
				{
					prev_i = i;
					i = Add2heap(arr, i, k);
				}
			}
		}
		public static int Add2heap(int[] arr, int i, int N)
		{
			int imax;
			int buf;
			if ((2 * i + 2) < N)
			{
				if (arr[2 * i + 1] < arr[2 * i + 2])
					imax = 2 * i + 2;
				else
					imax = 2 * i + 1;
			}
			else imax = 2 * i + 1;
			if (imax >= N)
				return i;
			if (arr[i] < arr[imax])
			{
				buf = arr[i];
				arr[i] = arr[imax];
				arr[imax] = buf;
				if (imax < N / 2)
					i = imax;
			}
			return i;
		}
		// быстрая сортировка
		public static void quickSort(int[] array, int startIndex, int endIndex)
		{
			if (array == null)
				return;
			doSort(array, startIndex, endIndex);

		}
		private static void doSort(int[] array, int start, int end)
		{
			if (start >= end)
				return;
			int i = start, j = end;
			int cur = i - (i - j) / 2;
			while (i < j)
			{
				while (i < cur && (array[i] <= array[cur]))
				{
					i++;
				}
				while (j > cur && (array[cur] <= array[j]))
				{
					j--;
				}
				if (i < j)
				{
					int temp = array[i];
					array[i] = array[j];
					array[j] = temp;
					if (i == cur)
						cur = j;
					else if (j == cur)
						cur = i;
				}
			}
			doSort(array, start, cur);
			doSort(array, cur + 1, end);
		}
	}
}
