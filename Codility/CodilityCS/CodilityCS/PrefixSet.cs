using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityCS
{
    class PrefixSet
    {
        /*
        //-----------------------------------------
            # PrefixSet - covering prefix
        //-----------------------------------------

        A non-empty array A consisting of N integers is given. 
        The first covering prefix of array A is the smallest integer P such that 0≤P<N and such that 
        every value that occurs in array A also occurs in sequence A[0], A[1], ..., A[P].

        For example, the first covering prefix of the following 5−element array A:
          A[0] = 2
          A[1] = 2
          A[2] = 1
          A[3] = 0
          A[4] = 1
        is 3, because sequence [ A[0], A[1], A[2], A[3] ] equal to [2, 2, 1, 0], contains all values that occur in array A.

        Write a function
        class Solution { public int solution(int[] A); }
        that, given a non-empty array A consisting of N integers, returns the first covering prefix of A.
        For example, given array A such that
          A[0] = 2
          A[1] = 2
          A[2] = 1
          A[3] = 0
          A[4] = 1
        the function should return 3, as explained above.
        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..1,000,000];
        each element of array A is an integer within the range [0..N−1].
        */
        /*
        Golden solution O(n) 
        For every index p we need to know whether the value A[p] has appeared before the index p. 
        Notice that the range of all the numbers is quite small, so we can count the elements. 
        More precisely, we can iterate through all the elements 
        and in the cell of index A[p] we mark that the value A[p] has just appeared. 

        3: Golden solution — O(n). 
	        def prefixSetGolden(A): 
		        n = len(A) 
		        occur = [False] * n 
		        for i in xrange(n): 
			        if (occur[A[i]] == False): 
				        occur[A[i]] = True 
				        result = i 
		        return result
        The time complexity is O(n).
         */
        public int Solution(int[] A)
        {
            var len = A.Length;
            int maxSize = 1000001;
            bool[] B = new bool[maxSize];
            var res = 0;
            for (var i = 0; i < len; i++)
            {
                if (B[A[i]] == false)
                {
                    B[A[i]] = true;
                    res = i;
                }
            }
            return res;
        }
        public int Solution1(int[] A)
        {
            // The first covering prefix of array A is the smallest integer P such that 0<=P<N and such that 
            // every value that occurs in array A also occurs in sequence A[0], A[1], ..., A[P].
            var len = A.Length;

            int maxSize = 1000001;
            int[] B = new int[maxSize];

            int unique = 0;

            //run through the whole array and add all the numbers to the set
            for (var i = 0; i < len; i++)
            {
                if (B[A[i]] == 0)
                {
                    B[A[i]] = 1; // flag as existing!
                    unique++;
                }
            }
            //Then, traverse the array, and remove the number you are currently looking at from the set.
            for (var i = 0; i < len; i++)
            {
                if (B[A[i]] == 1)
                {
                    B[A[i]] = 0; // remove
                    unique--;
                }
                //If the set becomes empty, you’ve found your prefix set.
                if (unique == 0)
                {
                    return i;
                }
            }
            return 0;
        }

        /*
This is not too difficult. I will use a Set data structure to keep track of the numbers that I still haven’t visited. 
At the beginning, run through the whole array and add all the numbers to the set. 
Then, traverse the array, and remove the number you are currently looking at from the set. 
If the set becomes empty, you’ve found your prefix set.

The Java code that scores 100/100 might look like this:
*/
        public static int coveringPrefix(int[] A)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
                s.Add(i);
            for (int i = 0; i < A.Length; i++)
            {
                s.Remove(A[i]);
                if (s.Count == 0)
                    return i;
            }
            return 0;
        }
        /*
        Alternatively, we can do without using any specialized data structures, 
        and just use an array of booleans to keep track of the numbers seen so far. 
        The code is longer, but doesn’t use any special data structures, and still scores 100/100:
        */
        public static int coveringPrefixNoSet(int[] A)
        {
            bool[] bools = new bool[A.Length];
            int unique = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (!bools[A[i]])
                {
                    bools[A[i]] = true;
                    unique++;
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (bools[A[i]])
                {
                    bools[A[i]] = false;
                    unique--;
                    if (unique == 0)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }


    }
}
