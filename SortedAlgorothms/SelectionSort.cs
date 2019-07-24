using System;
using System.Collections.Generic;
using System.Text;

namespace SortedAlgorothms
{
    class SelectionSort : SortedAlg
    {
        public SelectionSort(int[] arr)
        {
            array = arr;
        }

        public override int[] Sort()
        {
            int arrayLenght = array.Length;
            int temp, min;

            for (int i = 0; i < arrayLenght - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < arrayLenght;  j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            return array;
        }
    }
}
