using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point
                int m = (l + r) / 2;

                // Sort first and second halves
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }

        private static void merge(int[] arr, int l, int m, int r)
        {
            // l = left index, r = right index, 
            // Find sizes of 2 sub-arrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n1];

            // copy data to temp arrays
            for (int i1 = 0; i1 < n1; i1++)
            {
                L[i1] = arr[l + i1];
            }
            for (int j1 = 0; j1 < n2; j1++)
            {
                R[j1] = arr[m + 1 + j1];
            }

            // merge temp arrays
            // Initial indexes of first and second sub-arrays
            int i = 0;
            int j = 0;

            // Initial index of merged sub-array
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

            // Copy remaining elements of L[] if any
            while (i<n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
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
