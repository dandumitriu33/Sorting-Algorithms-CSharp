﻿using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Selection Sort

            //The selection sort algorithm sorts an array by repeatedly finding the minimum element(considering ascending order) 
            //from unsorted part and putting it at the beginning.The algorithm maintains two subarrays in a given array.

            //1) The subarray which is already sorted.
            //2) Remaining subarray which is unsorted.

            //In every iteration of selection sort, the minimum element(considering ascending order) from the unsorted 
            //subarray is picked and moved to the sorted subarray.

            //Time Complexity: O(N^2) as there are two nested loops.
            //Auxiliary Space: O(1)
            //The good thing about selection sort is it never makes more than O(N) swaps and can be useful when memory write is a costly operation.


            //int[] arr = { 64, 25, 12, 22, 11 };
            //SelectionSort.Sort(arr);
            //Console.WriteLine("Sorted array");
            //SelectionSort.PrintArray(arr);
            #endregion

            #region Bubble Sort
            //Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
            //Time Complexity: O(N^2)
            //Auxiliary Space: O(1)

            //var watch1 = System.Diagnostics.Stopwatch.StartNew();

            //int[] arr = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            //BubbleSort.Sort(arr);
            //Console.WriteLine("Sorted array");
            //BubbleSort.PrintArray(arr);

            //watch1.Stop();
            //var elapsedMs1 = watch1.ElapsedMilliseconds;

            #endregion

            #region Advanced Bubble Sort
            // The same as Bubble Sort but when a pass goes through without swapping any elements, it stops as they are all sorted.
            //Time Complexity: O(N^2)
            //Auxiliary Space: O(1)

            //var watch2 = System.Diagnostics.Stopwatch.StartNew();

            //int[] arr2 = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            //AdvancedBubbleSort.Sort(arr2);
            //Console.WriteLine("Sorted array");
            //AdvancedBubbleSort.PrintArray(arr2);

            //watch2.Stop();
            //var elapsedMs2 = watch2.ElapsedMilliseconds;
            //Console.WriteLine($"BubbleSort 1: {elapsedMs1}"); // needs Bubble Sort uncommented
            //Console.WriteLine($"BubbleSort 2: {elapsedMs2}");
            #endregion

            #region Insertion Sort

            //Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. 
            //The array is virtually split into a sorted and an unsorted part.Values from the unsorted part are picked and placed 
            //at the correct position in the sorted part.
            //Algorithm
            //To sort an array of size n in ascending order:
            //1: Iterate from arr[1] to arr[n] over the array.
            //2: Compare the current element(key) to its predecessor.
            //3: If the key element is smaller than its predecessor, compare it to the elements before.Move the greater elements 
            //one position up to make space for the swapped element.

            //Time Complexity: O(2N)
            //Auxiliary Space: O(1)

            //var watch2 = System.Diagnostics.Stopwatch.StartNew();

            //int[] arr2 = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            //InsertionSort.Sort(arr2);
            //Console.WriteLine("Sorted array");
            //InsertionSort.PrintArray(arr2);

            //watch2.Stop();
            //var elapsedMs2 = watch2.ElapsedMilliseconds;
            //Console.WriteLine($"InsertionSort: {elapsedMs2}");

            #endregion

            #region Quick Sort
            //Like Merge Sort, QuickSort is a Divide and Conquer algorithm. It picks an element as pivot and partitions the 
            //given array around the picked pivot.There are many different versions of quickSort that pick pivot in different ways.

            //Always pick first element as pivot.
            //Always pick last element as pivot (implemented below)
            //Pick a random element as pivot.
            //Pick median as pivot.
            //The key process in quickSort is partition(). Target of partitions is, given an array and an element x of array as pivot, 
            //put x at its correct position in sorted array and put all smaller elements(smaller than x) before x, and put all greater 
            //elements(greater than x) after x. All this should be done in linear time.

            //Time Complexity O(N^2)
            //Space Complexity O(1)


            //var watch2 = System.Diagnostics.Stopwatch.StartNew();

            //int[] arr2 = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            //QuickSort.Sort(arr2, 0, arr2.Length-1);
            //Console.WriteLine("Sorted array");
            //QuickSort.PrintArray(arr2);

            //watch2.Stop();
            //var elapsedMs2 = watch2.ElapsedMilliseconds;
            //Console.WriteLine($"QuickSort: {elapsedMs2}");

            #endregion

            #region Merge Sort
            //Like QuickSort, Merge Sort is a Divide and Conquer algorithm. It divides input array in two halves, calls itself for 
            //the two halves and then merges the two sorted halves.The merge() function is used for merging two halves.The 
            //merge(arr, l, m, r) is key process that assumes that arr[l..m] and arr[m + 1..r] are sorted and merges the two sorted 
            //sub - arrays into one.

            //The following diagram from wikipedia shows the complete merge sort process for an example array { 38, 27, 43, 3, 9, 82, 10}. 
            //If we take a closer look at the diagram, we can see that the array is recursively divided in two halves till the size becomes 1.
            //Once the size becomes 1, the merge processes comes into action and starts merging arrays back till the complete array is merged.

            //Time Complexity O(N * Log N)
            //Space Complexity O(N)


            //var watch2 = System.Diagnostics.Stopwatch.StartNew();

            //int[] arr2 = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            //MergeSort.Sort(arr2, 0, arr2.Length - 1);
            //Console.WriteLine("Sorted array");
            //MergeSort.PrintArray(arr2);

            //watch2.Stop();
            //var elapsedMs2 = watch2.ElapsedMilliseconds;
            //Console.WriteLine($"MergeSort: {elapsedMs2}");
            #endregion

            #region Tim Sort
            //TimSort is a sorting algorithm based on Insertion Sort and Merge Sort.

            //A stable sorting algorithm works in O(n Log n) time
            //Used in Java’s Arrays.sort() as well as Python’s sorted() and sort().
            //First sort small pieces using Insertion Sort, then merges the pieces using merge of merge sort.
            //We divide the Array into blocks known as Run.We sort those runs using insertion sort one by one and then merge those runs using 
            //combine function used in merge sort. If the size of Array is less than run, then Array get sorted just by using Insertion Sort. 
            //The size of run may vary from 32 to 64 depending upon the size of the array.Note that merge function performs well when sizes 
            //subarrays are powers of 2.The idea is based on the fact that insertion sort performs well for small arrays.

            var watch2 = System.Diagnostics.Stopwatch.StartNew();

            int[] arr2 = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            TimSort.Sort(arr2, arr2.Length);
            Console.WriteLine("Sorted array");
            MergeSort.PrintArray(arr2);

            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedMilliseconds;
            Console.WriteLine($"TimSort: {elapsedMs2}");

            #endregion

        }
    }
}
