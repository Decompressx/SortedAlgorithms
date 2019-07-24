using System;
using System.Collections.Generic;
using System.Text;

namespace SearchElement
{
    class BinarySearch : SearchAlg
    {
        public BinarySearch(int[] arr)
        {
            array = arr;
        }
        public override int Search(int element)
        {
            return binarySearch(array, 0, array.Length - 1, element);
        }

        int binarySearch(int[] arr, int l,int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                return binarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }

    }
}
