using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Codility
{
    public struct MinMaxType
    {
        public int Min;
        public int Max;
    }

    public class MinMax
    {
        public MinMaxType FindMinMax(int[] array, int start, int end)
        {
            MinMaxType min_max;
            int index;
            int n = end - start + 1;//n: the number of elements to be sorted, assuming n>0
            if (n % 2 != 0)
            {// if n is odd

                min_max.Min = array[start];
                min_max.Max = array[start];

                index = start + 1;
            }
            else
            {// n is even
                if (array[start] < array[start + 1])
                {
                    min_max.Min = array[start];
                    min_max.Max = array[start + 1];
                }
                else
                {
                    min_max.Min = array[start + 1];
                    min_max.Max = array[start];
                }
                index = start + 2;
            }

            int big, small;
            for (int i = index; i < n - 1; i = i + 2)
            {
                if (array[i] < array[i + 1])
                { //one comparison
                    small = array[i];
                    big = array[i + 1];
                }
                else
                {
                    small = array[i + 1];
                    big = array[i];
                }
                if (min_max.Min > small)
                { //one comparison
                    min_max.Min = small;
                }
                if (min_max.Max < big)
                { //one comparison
                    min_max.Max = big;
                }
            }

            return min_max;
        }
    }
    /*
    If The array is not sorted
    Finding the min and max is done simultaneously
    Then there is an algorithm that finds the min and max in 3n/2 number of comparisons. 
    What one needs to do is process the elements of the array in pairs. 
    The larger of the pair should be compared with the current max and 
    the smaller of the pair should be compared with the current min.
    Also, one needs take special care if the array contains odd number of elements.

    It's very easy to see that the number of comparisons it takes is 3n/2. 
    The loop runs n/2 times and in each iteration 3 comparisons are performed.
    This is probably the optimum one can achieve. 
    At this moment, I cannot point to a definite source of that. 
    (But, I think I have seen a proof of that somewhere.)

    The recursive solution given by Mehrdad above, 
    probably also achieves this minimal number of comparisons (the last line needs to be changed).
    But with the same number of comparisons an iterative solution will always beat a
    recursive solution due to overhead in the function call as he mentioned. 
    However, if one only cares about finding min and max of a few numbers (as Eric Belair does), 
    no one will notice any difference in todays computer with any of the approaches above. 
    For a large array, the difference could be significant.

    Though this solution and the solution given by Matthew Brubaker has O(n) complexity, 
    in practice one should carefully asses the hidden constants involved. 
    The number of comparisons in his solution is 2n. 
    The speedup gained with the solution with 3n/2 comparisons as opposed to 2n comparisons would be noticeable.
    */
}

