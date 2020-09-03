using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // move elements between 0..i-1 that are greater than key 1 position to the right
                while (j>=0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
