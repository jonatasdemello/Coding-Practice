using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest01
{
    public static class BranchSize
    {
        /*
        Suppose you're given a binary tree represented as an array.
        For example, [3, 6, 2, 9, -1, 10] represents the following binary tree (where -1 is a non-existent node): 
             3
          6    2
        9    10
        Write a function that determines whether the left or right branch of the tree is larger. 
        The size of each branch is the sum of the node values.
        
        The function should return the string "Right" if the right side is larger and "Left" if the left side is larger.
        If the tree has a nodes or if the size of the branches are equal, return the empty string. 
        Example Input: [3,6,2,9,-1,10] Example Output: Left 

        Input: arr: [3,6,2,9,-1,10] 
        Expected Output: "Left"

        Input:arr: [1,4,100,5]
        Expected Output:"Right"

        Input:arr: [1,10,5,1,0,6]
        Expected Output:""

        Input:arr: []
        Expected Output:""

        Input:arr: [1]
        Expected Output:""
        */
        public static string Solution(long[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
                return "";

            var left = Sum(arr, 2);
            var right = Sum(arr, 3);

            return (left == right) ? "" : (left > right ? "Left" : "Right");
        }
        public static long Sum(long[] arr, int idx)
        {
            if (idx - 1 < arr.Length)
            {
                if (arr[idx - 1] == -1) return 0;
                return arr[idx - 1] + Sum(arr, idx * 2) + Sum(arr, idx * 2 + 1);
            }
            return 0;
        }
    }
}
