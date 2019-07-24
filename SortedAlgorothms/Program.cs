using System;

namespace SortedAlgorothms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 3, 6, 2, 4, 1 };

            SortedAlg sortedAlg = new MergeSort(arr);
            arr = sortedAlg.Sort();
            Console.WriteLine(arr);
        }
    }
}
