﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class AdvancedBubbleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            bool swapped = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (swapped == false)
                {
                    break;
                }
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
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
