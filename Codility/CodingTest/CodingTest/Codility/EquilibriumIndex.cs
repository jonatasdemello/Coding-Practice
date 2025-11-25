using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.Codility
{
    public class EquilibriumIndex
    {
        int Solution(int[] A, int N)
        {
            int left_sum = 0;
            int right_sum = 0;
            for (var i = 0; i < N; i++)
            {
                // Calculate sum of the left part
                left_sum = 0;
                for (var j = 0; j < i; j++)
                {
                    left_sum += A[j];
                }
                // Calculate sum of the right part
                right_sum = 0;
                for (var j = i + 1; j < N; j++)
                {
                    right_sum += A[j];
                }
                // Check if is is the equilibrium point
                if (left_sum == right_sum)
                {
                    return i;
                }
            }
            return -1;
        }

        // The problem can be solved by using various approaches, the most common being simply to follow the equilibrium definition:
        int equi0(int[] A, int n)
        {
            int lsum, rsum;
            for (var k = 0; k < n; ++k)
            {
                lsum = 0; rsum = 0;
                for (var m = 0; m < k; ++m)
                    lsum += A[m]; //sum left
                for (var m = k + 1; m < n; ++m)
                    rsum += A[m]; //sum rigth
                if (lsum == rsum) return k;
            }
            return -1;
        }
        /*
        Unfortunately, this approach has two disadvantages:

        it fails on large input data sets, since the time complexity is O(n^2)
        it fails on large input values (for example if the input array contains values like MIN/MAX_INT) due to the arithmetic overflows

        We can fix the first problem with a better algorithm, 
        and the second problem with a better data-type (for example, using long type instead of int for sum computations). 

        The key observation for better running time is to update the left/right sums 
        in constant time instead of recomputing them from the scratch.
        */
        int equi1(int[] arr, int n)
        {
            if (n == 0) return -1;
            long sum = 0;
            //sum all first
            for (var i = 0; i < n; i++)
                sum += (long) arr[i];
            // one more pass, update the left/right sums
            long sum_left = 0;
            for (var i = 0; i < n; i++)
            {
                long sum_right = sum - sum_left - (long)arr[i];
                if (sum_left == sum_right)
                    return i;
                sum_left += (long)arr[i];
            }
            return -1; 
        }
        int equi2(int[] A)
        {
            int equi = -1;
            long lower = 0;
            long upper = 0;
            foreach (int i in A)
                upper += i;
            
            for (int i = 0; i < A.Length; i++)
            {
                upper -= A[i];
                if (upper == lower)
                {
                    equi = i;
                    break;
                }
                else
                    lower += A[i];
            }
            return equi;
        }

        public int TapeEquilibrium(int[] arr)
        {
            long left = arr[0];
            long right = arr.Skip(1).Sum();
            var min = (int)Math.Abs(left - right);
            for (var i = 1; i < arr.Length - 1; i++)
            {
                left += arr[i];
                right -= arr[i];
                var diff = (int)Math.Abs(left - right);
                if (diff < min) min = diff;
            }
            return min;
        }
        public int solution1(int[] A)
        {
            double sum = A.Sum(d => (double)d);
            double leftSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (leftSum == (sum - leftSum - A[i]))
                {
                    return i;
                }
                else
                {
                    leftSum = leftSum + A[i];
                }
            }
            return -1;
        }
        public int solution2(int[] A)
        {
            int left = 0, right = 0, index = 0;
            bool flag = false;
            for (int i = 0; i < A.Length; i++)
            {
                left = 0; right = 0;
                for (int i1 = 0; i1 <= i; i1++)
                {
                    left += A[i1];
                }
                for (int j1 = i + 2; j1 <= A.Length; j1++)
                {
                    if (j1 < A.Length)
                    {
                        right += A[j1];
                    }
                }
                if (left == right)
                {
                    index = i + 1;
                    flag = true;
                }
            }
            if (flag == false)
            {
                return -1;
            }
            else
            {
                return index;
            }
        }
        public int solution3(int[] A)
        {
            var length = A.Length;

            if (length == 1) return A[0];
            if (length == 2) return Math.Abs(A[0] - A[1]);

            var leftSum = 0;
            var rightSum = 0;

            for (var i = 0; i < length; i++)
            {
                rightSum += A[i];
            }

            var difference = int.MaxValue;

            for (var i = 0; i < length - 1; i++)
            {
                var value = A[i];

                leftSum += value;
                rightSum -= value;

                difference = Math.Min(difference, Math.Abs(rightSum - leftSum));

                if (difference == 0) return 0;
            }
            return difference;
        }
        public int solution4(int[] A)
        {
            int total = A.Length - 1;
            int left = A[0];
            int right = 0;
            for (int i = 1; i < A.Length; i++)
            {
                right += A[i];
            }
            int minDiff = Math.Abs(left - right);

            for (int i = 1; i < total; i++)
            {
                left += A[i];
                right -= A[i];
                if (Math.Abs(left - right) < minDiff) minDiff = Math.Abs(left - right);
            }
            return minDiff;
        }
    }
}
/*
//-----------------------------------------
	3. Equi - equilibrium index 
//-----------------------------------------

Find an index in an array such that its prefix sum equals its suffix sum.

An array A consisting of N integers is given. 
An equilibrium index of this array is any integer P such that 0 ≤ P < N and 
the sum of elements of lower indices is equal to the sum of elements of higher indices, i.e. 
A[0] + A[1] + ... + A[P−1] = A[P+1] + ... + A[N−2] + A[N−1].
Sum of zero elements is assumed to be equal to 0. This can happen if P = 0 or if P = N−1.

For example, consider the following array A consisting of N = 8 elements:
  A[0] = -1
  A[1] =  3
  A[2] = -4
  A[3] =  5
  A[4] =  1
  A[5] = -6
  A[6] =  2
  A[7] =  1
P = 1 is an equilibrium index of this array, because:
A[0] = −1 = A[2] + A[3] + A[4] + A[5] + A[6] + A[7]

P = 3 is an equilibrium index of this array, because:
A[0] + A[1] + A[2] = −2 = A[4] + A[5] + A[6] + A[7]

P = 7 is also an equilibrium index, because:
A[0] + A[1] + A[2] + A[3] + A[4] + A[5] + A[6] = 0
and there are no elements with indices greater than 7.

P = 8 is not an equilibrium index, because it does not fulfill the condition 0 ≤ P < N.

Write a function:

int solution(int A[], int N);

that, given an array A consisting of N integers, returns any of its equilibrium indices. 
The function should return −1 if no equilibrium index exists.

For example, given array A shown above, the function may return 1, 3 or 7, as explained above.
Write an efficient algorithm for the following assumptions:

	N is an integer within the range [0..100,000];
	each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].

 
The equilibrium index of a sequence is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes. 
For example, in a sequence A:

A[0]=-7 A[1]=1 A[2]=5 A[3]=2 A[4]=-4 A[5]=3 A[6]=0

A = [-7, 1, 5, 2, -4, 3, 0]

3 is an equilibrium index, because:

A[0]+A[1]+A[2] = A[4]+A[5]+A[6]

6 is also an equilibrium index, because:

A[0]+A[1]+A[2]+A[3]+A[4]+A[5]=0

(The sum of zero elements is zero) 
7 is not an equilibrium index - because it is not a valid index of sequence A. 

If you still have doubts, here is a precise definition: 
The integer k is an equilibrium index of a sequence A[0],A[1]..,A[n-1] 
if and only if 0<= kand sum(A[0..(k-1)])=sum(A[(k+1)..(n-1)]). 
Assume the sum of zero elements is equal to zero.

Write a function

int equi(int A[], int n)

that, given a sequence, returns its equilibrium index (any) or -1 if no equilibrium index exists. 

Assume that the sequence may be very long.
*/
