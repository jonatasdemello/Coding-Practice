using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest01
{
    public static class LargestNumber
    {
        /*
        Question 1 
        Write a function that takes a list of numbers, numbers; and returns the largest number in the list. If there are no numbers in the list, return o. 
        Example 1: 
        Input numbers: [7, 2, 6, 3] Output: 7 
        Explanation: 
        Given the list [7, 2, 6, 3], we want to find the largest number, which happens to be 7 at index 0. 
        Example 2: Input: numbers: [] Output: 0
        Explanation: 
        Even though the list [] is empty and contains no numbers, we return 0 since the problem statement specifies to do that. 
        */
        public static long Solution(long[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            long max = numbers[0];

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
