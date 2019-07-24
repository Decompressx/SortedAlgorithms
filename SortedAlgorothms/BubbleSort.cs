using System;
using System.Collections.Generic;
using System.Text;

namespace SortedAlgorothms
{
    class BubbleSort : SortedAlg
    {
        public BubbleSort(int[] arr)
        {
            array = arr;
        }

        public override int[] Sort()
        {
            int temp;
            int lengthArray = array.Length;

            for (int i = 0; i < lengthArray - 1; i++)
            {
                for (int j = 0; j < lengthArray - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
