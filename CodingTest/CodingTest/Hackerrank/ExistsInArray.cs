using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    public class ExistsInArray
    {
        /*
        The aim of this exercise is to check the presence of a number in an array.

        Specifications:
        The items are integers arranged in ascending order.
        The array can contain up to 1 million items
        The array is never null

        Implement the method boolean Answer.Exists(int[] ints, int k) so that it 
        returns true if k belongs to ints, otherwise the method should return false.

        Important note: Try to save CPU cycles if possible.

        Example:
        int[] ints = {-9, 14, 37, 102};
        Answer.Exists(ints, 102) returns true
        Answer.Exists(ints, 36) returns false
        */
        public static bool ExistsSequential(int[] ints, int k)
        {
            // sequential search
            for (int i=0; i<ints.Length; i++)
            {
                if(ints[i] == k)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ExistsBinarySearch(int[] ints, int k)
        {
            // binary search
            var min = 0;
            var max = ints.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (k > ints[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (ints[mid] == k)
                    return true;
            }
            return false;
        }
        public static bool BinarySearchDisplay(int[] arr, int key)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                    return true;
                else if (key < arr[mid])
                    maxNum = mid - 1;
                else
                    minNum = mid + 1;
            }
            return false;
        }

        public static bool ExistsLinq(int[] ints, int k)
        {
            List<int> list = new List<int>(ints);

            return list.Contains(k);
        }

        public static bool Exists(int[] ints, int k)
        {
            // O(log n) => logarithmic

            // binary search
            var low = 0;
            var high = ints.Length - 1;
            var mid = 0;
            var elem = 0;

            while (low <= high)
            {
                mid = (low + high) / 2;
                elem = ints[mid];
                if (elem < k)
                {
                    low = mid + 1;
                }
                else if (elem > k)
                {
                    high = mid - 1;
                }
                else // elem == key
                {
                    return true;
                }
            }
            return false; // not found
        }

        public static int IntArrayBinarySearch(int[] data, int item)
        {
            int min = 0;
            int N = data.Length;
            int max = N - 1;
            do
            {
                int mid = (min + max) / 2;
                if (item > data[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (data[mid] == item)
                    return mid;
                //if (min > max)
                //   break;
            } while (min <= max);
            return -1;
        }
        /*
        // using recursion
        // O(lon n)
        function binarySearch(numArray, key)
        {
            var size = numArray.length;
            var middleIndex = Math.floor(size / 2);
            var middleElem = numArray[middleIndex];

            if (middleElem === key)
            {
                return true;
            }
            else if (middleElem < key && size > 1)
            {
                return binarySearch(numArray.splice(middleIndex, size), key);
            }
            else if (middleElem > key && size > 1)
            {
                return binarySearch(numArray.splice(0, middleIndex), key);
            }
            else
                return false;
        }
        */
    }
}
