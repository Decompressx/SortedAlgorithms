using System;
using System.Collections.Generic;
using System.Text;

namespace SortedAlgorothms
{
    class InsertionSort : SortedAlg
    {
        public InsertionSort(int[] arr)
        {
            array = arr;
        }

        public override int[] Sort()
        {
            int arrayLength = array.Length;

            for (int i = 1; i < arrayLength; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j-=1;
                }
                array[j + 1] = key;
            }
            return array;
        }
    }
}
