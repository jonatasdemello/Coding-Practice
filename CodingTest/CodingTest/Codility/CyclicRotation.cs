using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Codility
{
    /*
    CyclicRotation
    
    Rotate an array to the right by a given number of steps.

    An array A consisting of N integers is given. 
    Rotation of the array means that each element is shifted right by one index, 
    and the last element of the array is moved to the first place. 
    For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] 
    (elements are shifted right by one index and 6 is moved to the first place).

    The goal is to rotate array A K times; that is, 
    each element of A will be shifted to the right K times.

    Write a function:
    that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.

    For example, given
        A = [3, 8, 9, 7, 6]
        K = 3
    the function should return [9, 7, 6, 3, 8]. 
    Three rotations were made:
        [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
        [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
        [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
    
    For another example, given
        A = [0, 0, 0]
        K = 1
    the function should return [0, 0, 0]

    Given
        A = [1, 2, 3, 4]
        K = 4
    the function should return [1, 2, 3, 4]

    Assume that:

    N and K are integers within the range [0..100];
    each element of array A is an integer within the range [−1,000..1,000].
    In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.
    */
    public static class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            var len = A.Length;
            int[] B = new int[len];

            if (K > 100 || K < 0 || len == 0)
                return A;
            if (K > len)
                K = K % len; // we can use Mod
            if (K == len) 
                return A;

            for (int i = 0, j = len - K; i < len; i++, j++)
            {
                if (j >= len)
                    j = 0;
                B[i] = A[j];
            }
            return B;
        }
        public static int[] Solution1(int[] A, int K)
        {
            //check condition
            int N = A.Length;
            if (N < 0 || N > 100) return A;
            if (K < 0 || K > 100) return A;
            if (K == 0) return A;
            //new array
            var B = new int[N];
            for (int i = 0; i < N; i++)
            {
                // check item
                var item = A[i];
                if (item < -1000 || item > 1000) return A;
                int newIndex = i + K;
                int left = K % N;
                while (newIndex > N - 1)
                {
                    newIndex -= N;
                }
                // simple swap index not value
                B[newIndex] = item;
            }
            return B;
        }
        public static int[] Solution2(int[] A, int K)
        {
            if (K == 0 || A.Length == 0)
                return A;
            int[] res = new int[A.Length];
            int len = A.Length;
            for (int i = 0; i < len; i++)
            {
                if (i < (K % len))
                    res[i] = A[(len - (K % len)) + i];
                else
                    res[i] = A[System.Math.Abs((K % len) - i)];
            }
            return res;
        }

        public static int[] Solution3(int[] A, int K)
        {
            var len = A.Length;
            int[] B = new int[len];

            if (K > 100 || K < 0 || len == 0) return A;
            if (K > len) K = K % len; // we can use Mod
            if (K == len) return A;

            for (int i = 0, j = len - K; i < len; i++, j++)
            {
                if (j >= len)
                    j = 0;
                B[i] = A[j];
            }

            //Debug.WriteLine("A: " + string.Join(",", A) + " k: " + K);
            //Debug.WriteLine("B: " + string.Join(",", B));

            return B;
        }

        public static int[] Solution4(int[] A, int K)
        {
            var len = A.Length;
            int[] B = new int[len];
            int[] T = new int[K];

            if (K >= len)
                return A;

            //copy first K to temp array
            for (var i = 0; i < K; i++)
            {
                T[i] = A[i];
            }
            int k = K;
            // copy from K to end
            for (int i = 0; k < len; i++, k++)
            {
                B[i] = A[k];
            }
            // copy T to end of B
            int b = K + 1;
            for (int t = 0; t < T.Length; t++, b++)
            {
                B[b] = T[t];
            }

            //Debug.WriteLine("A: " + string.Join(",", A) + " k: " + K);
            //Debug.WriteLine("B: " + string.Join(",", B));

            return B;
        }

        public static int[] Solution_ShiftLeft(int[] A, int K)
        {
            var len = A.Length;
            int[] B = new int[len];

            if (K >= len || K <= 0)
                return A;

            for (int i = 0, j = K; i < len; i++, j++)
            {
                if (j >= len)
                    j = 0;
                B[i] = A[j];
            }

            //Debug.WriteLine("A: " + string.Join(",", A) + " k: " + K);
            //Debug.WriteLine("B: " + string.Join(",", B));

            return B;
        }
    }
}
