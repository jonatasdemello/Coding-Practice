using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    public class ExistsInArray
    {
        public static bool ExistsSequential(int[] ints, int k)
        {
            // sequential search
            for (int i=0; i<ints.Length; i++)
            {
                if(ints[i] == k){
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
    }
}
