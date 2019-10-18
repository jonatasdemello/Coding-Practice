using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    public class BeautifulSubarrays
    {
    }
}
/*
Beautiful Subarrays
A beautiful subarray is defined as an array of any length having a specific number of odd elements. 
Given an array of integers and a number of odd elements that constitutes beauty, 
create as many distinct beautiful subarrays as possible.  
Distinct means the arrays don't share identical starting and ending indices, 
though they may share one of the two.
 
For example, given the array [1, 2, 3, 4, 5] and a beautiful number of 2, 
the following beautiful subarrays can be formed:
 
[1, 2, 3]
[1, 2, 3, 4]
[2, 3, 4, 5] 
[3, 4, 5]
 
Function Description 
Complete the function beautifulSubarrays in the editor below. 
The function must return the number of beautiful subarrays present in a.
 
beautifulSubarrays has the following parameter(s):
    a[a[0],...a[n-1]]:  an array integers
    m:  the number of odd elements considered beautiful
 
Constraints
1 ≤ n ≤ 2 × 105
1 ≤ a[i] ≤ 109.
The array a consists of distinct positive integers.
0 ≤ m ≤ 2 × 105
 
Input Format for Custom Testing
Sample Case 0
Sample Input 0
4
2
5
4
9
1
Sample Output 0
6
Explanation 0
Array a = [2, 5, 4, 9] has six distinct beautiful subarrays with exactly m = 1 odd elements:
a[1..1] = [5]
a[3..3] = [9]
a[0..1] = [2, 5]
a[1..2] = [5, 4]
a[2..3] = [4, 9]
a[0..2] = [2, 5, 4]
 
*/
