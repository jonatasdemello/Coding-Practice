using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.Udemy
{
    class BinarySearch
    {
        public void TestBinarySearch()
        {
            var arr1 = new int[] { 4, 5, 7, 12, 16, 36, 39, 50, 71, 84, 90 };
            Console.WriteLine(BinarySearchRecursive(arr1, 84));
            Console.WriteLine(BinarySearchRecursive(arr1, 11));

            Console.WriteLine(new string('-', 25));
            Console.WriteLine(BinarySearchInteractive(arr1, 84));
            Console.WriteLine(BinarySearchInteractive(arr1, 13));
        }

        // O(lon n)
        public bool BinarySearchRecursive(int[] numArray, int key)
        {
            var size = numArray.Length;
            var middleIndex = (size / 2);
            var middleElem = numArray[middleIndex];

            if (middleElem == key)
            {
                return true;
            }
            else if (middleElem < key && size > 1)
            {
                // take second part
                return BinarySearchRecursive(numArray.Skip(middleIndex).ToArray(), key);
            }
            else if (middleElem > key && size > 1)
            {
                // take first part
                return BinarySearchRecursive(numArray.Take(middleIndex).ToArray(), key);
            }
            else
                return false;
        }

        public bool BinarySearchInteractive(int[] arr, int k)
        {
            var min = 0;
            var max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (k > arr[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (arr[mid] == k)
                    return true;
            }
            return false;
        }
    }
}
/*
function binary_search(A, n, T):
    L := 0
    R := n − 1
    while L <= R:
        m := floor((L + R) / 2)
        if A[m] < T:
            L := m + 1
        else if A[m] > T:
            R := m - 1
        else:
            return m
    return unsuccessful

function binary_search_alternative(A, n, T):
    L := 0
    R := n − 1
    while L != R:
        m := ceil((L + R) / 2)
        if A[m] > T:
            R := m - 1
        else:
            L := m
    if A[L] == T:
        return L
    return unsuccessful

function binary_search_leftmost(A, n, T):
    L := 0
    R := n
    while L < R:
        m := floor((L + R) / 2)
        if A[m] < T:
            L := m + 1
        else:
            R := m
    return L

function binary_search_rightmost(A, n, T):
    L := 0
    R := n
    while L < R:
        m := floor((L + R) / 2)
        if A[m] > T:
            R := m
        else:
            L := m + 1
    return L - 1
*/
