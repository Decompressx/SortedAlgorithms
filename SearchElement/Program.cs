using System;

namespace SearchElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 543, 234, 21, 52, 754, 21 };

            SearchAlg searchAlg = new BinarySearch(array);
            Console.WriteLine(searchAlg.Search(52));
        }
    }
}
