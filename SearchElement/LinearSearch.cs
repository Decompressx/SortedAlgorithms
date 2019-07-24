using System;
using System.Collections.Generic;
using System.Text;

namespace SearchElement
{
    class LinearSearch : SearchAlg
    {
        public LinearSearch(int[] arr)
        {
            array = arr;
        }
        public override int Search(int element)
        {
            int arrayLength = array.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] == element)
                    return i+1;
            }
            return -1;
        }
    }
}
