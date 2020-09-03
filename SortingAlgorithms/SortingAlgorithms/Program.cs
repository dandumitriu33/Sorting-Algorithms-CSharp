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

            int[] arr = { 64, 25, 12, 22, 11 };
            BubbleSort.Sort(arr);
            Console.WriteLine("Sorted array");
            BubbleSort.PrintArray(arr);

            #endregion
        }
    }
}
