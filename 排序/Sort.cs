using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Sort
    {
        public void selectSort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                return;
            }
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                int minValueIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    minValueIndex = arr[j] < arr[minValueIndex] ? j : minValueIndex;
                }
                swap(arr, i, minValueIndex);
            }
        }

        public void bubbleSort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                return;
            }
            int N = arr.Length;
            for (int end = N - 1; end >= 0; end--)
            {
                for (int second = 1; second <= end; second++)
                {
                    if (arr[second - 1] > arr[second])
                    {
                        swap(arr, second - 1, second);
                    }
                }
            }
        }

        public void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                System.Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
