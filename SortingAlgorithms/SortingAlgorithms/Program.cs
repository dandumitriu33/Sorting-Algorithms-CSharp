using System;

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

            var watch2 = System.Diagnostics.Stopwatch.StartNew();

            int[] arr2 = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            InsertionSort.Sort(arr2);
            Console.WriteLine("Sorted array");
            InsertionSort.PrintArray(arr2);

            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedMilliseconds;
            Console.WriteLine($"InsertionSort: {elapsedMs2}");

            #endregion
        }
    }
}
