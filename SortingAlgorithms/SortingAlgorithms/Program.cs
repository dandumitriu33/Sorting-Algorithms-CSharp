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

            var watch1 = System.Diagnostics.Stopwatch.StartNew();

            int[] arr = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            BubbleSort.Sort(arr);
            Console.WriteLine("Sorted array");
            BubbleSort.PrintArray(arr);

            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedMilliseconds;

            #endregion

            #region Advanced Bubble Sort
            // The same as Bubble Sort but when a pass goes through without swapping any elements, it stops as they are all sorted.
            //Time Complexity: O(N^2)
            //Auxiliary Space: O(1)

            var watch2 = System.Diagnostics.Stopwatch.StartNew();

            int[] arr2 = { 64, 25, 12, 22, 11, 50, 101, 34, 73, 44, 0, 12, 2222 };
            AdvancedBubbleSort.Sort(arr2);
            Console.WriteLine("Sorted array");
            AdvancedBubbleSort.PrintArray(arr2);

            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedMilliseconds;
            Console.WriteLine($"BubbleSort 1: {elapsedMs1}");
            Console.WriteLine($"BubbleSort 2: {elapsedMs2}");
            #endregion
        }
    }
}
