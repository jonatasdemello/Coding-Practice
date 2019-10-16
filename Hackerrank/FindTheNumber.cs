/*
1. Find the number!
Given an unsorted array of n elements, find if the element k is present in the array or not.
Complete the findNumber function in the editor below. It has 2 parameters:
An array of integers, arr, denoting the elements in the array.
An integer, k, denoting the element to be searched in the array.
The function must return a string "YES" or "NO" denoting if the element is present in the array or not.
 
Input Format
 
The first line contains an integer n, denoting the number of elements in the array arr.
Each line i of the n subsequent lines (where 0 ≤ i < n) contains an integer describing arri.
The next line contains an integer, k, the element that needs to be searched. 
 
Constraints
1 ≤ n ≤ 105
1 ≤ arr[i] ≤ 109
 
Output Format
The function must return a string "YES" or "NO" denoting if the element is present in the array or not. This is printed to stdout by locked stub code in the editor.
 
Sample Input 0
5
1
2
3
4
5
1
 
Sample Output 0
YES
 
Explanation 0
Given the array = [1, 2, 3, 4, 5], we want to find the element 1 if it is present or not. We can find the element 1 at index = 0. Therefore we print "YES".
 
Sample Input 1
3
2
3
1
5
 
Sample Output 1
NO
 
Explanation 1
Given the array [2, 3, 1] and k = 5. There is no element 5 in the array and therefore we print "NO".
*/
 	
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

	static string findNumber(List<int> arr, int k)
	{
		foreach (var item in arr)
		{
			if (item == k)
			{
				return "YES";
			}
		}
		return "NO";
	}
	static string findNumber1(List<int> arr, int k)
	{
		var res = arr.Contains(k);
		return res == true ? "YES" : "NO";
	}

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < arrCount; i++) {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string res = findNumber(arr, k);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
