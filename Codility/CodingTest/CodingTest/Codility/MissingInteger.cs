using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.Codility
{
    /*
    //-----------------------------------------
	    # MissingInteger
    //-----------------------------------------

    Write a function:
    that, given an array A of N integers, 
    returns the smallest positive integer (greater than 0) 
    that does not occur in A.

    For example, 
    Given A = [1, 3, 6, 4, 1, 2], the function should return 5.
    Given A = [1, 2, 3], the function should return 4.
    Given A = [−1, −3], the function should return 1.

    Write an efficient algorithm for the following assumptions:
    N is an integer within the range [1..100,000];
    each element of array A is an integer within the range [−1,000,000..1,000,000].
    
    Example test:    [1, 3, 6, 4, 1, 2] Output: 5
    Example test:    [1, 2, 3] Output: 4
    Example test:    [-1, -3] Output: 1
    Your test case:  [1, 2, 1000000] Output: 3
    Your test case:  [-1000000, 1000000] Output: 1
    */
    public class MissingInteger
    {
        public MissingInteger()
        {
            var missing = new MissingInteger();
            var m = missing.Solution(new int[] { 1, 3, 6, 4, 1, 2 });
            Console.WriteLine("MissingInteger: {0}", m);
        }
        public int Solution(int[] A)
        {
            // given an array A of N integers, returns the smallest positive integer 
            // (greater than 0) that does not occur in A.

            int max = 1000001;
            // use a bitmap structure, needs to be the same size as the max number stored in A
            int[] B = new int[max];

            //for (var i = 0; i < 100000; i++) {B[i] = 0;} // initialize with 0
            
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] > 0) // only positive integers
                    B[A[i]] = 1; // flag as existing in the second array
            }
            for (var i = 1; i < B.Length; i++)
            {
                if (B[i] == 0) // first small integer that is not there
                    return i;
            }
            return max + 1;
        }

        public static int Solution1(int[] A)
        {
            // return the smallest positive integer that does not occur in A
            int maxSize = 1000001;
            int[] B = new int[maxSize];

            //for (var i = 0; i < 100000; i++) {B[i] = 0; //initialize with 0;}

            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                    B[A[i]] = 1; // flag as existing!
            }
            for (var i = 1; i < B.Length; i++)
            {
                if (B[i] == 0)
                    return i;
            }
            return maxSize + 1;
        }
        public static int Solution2(int[] A)
        {
            // using Linq
            var listA = new List<int>(A);
            var listB = listA.Distinct();

            return listA.IndexOf(listB.Last());
        }
    }
}
