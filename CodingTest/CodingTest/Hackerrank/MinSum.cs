/*
Minimum Sum
Arthur and Alena are playing a game with an array containing some integers. 
Arthur can take any integer and remove it from the array and he has to 
add half of that number (rounded up) back to the array.
 
Alena allots Arthur a fixed number of moves and challenges him to minimize the sum of the final array.
 
As an example of how moves work, start with the array nums = [10, 20, 7] 
and perform k = 4 moves. Pick any element to perform a move on, for example the 7. 
Perform the division: 7/2 = 3.5, and round up to 4. 
Replace the 7 with the new value 4. 
At this point, the array is nums = [10, 20, 4].  
All 4 moves are performed as follows:
 
Pick    Pick/2    Rounded        Result
Initial array                    [10, 20, 7]
7         3.5     4              [ 10, 20, 4]
10        5       5              [5, 20, 4]
20        10      10             [5, 10, 4]
10        5       5              [5, 5, 4]
 
The sum of the final array is 5 + 5 + 4 = 14, and that sum is minimal.
 
Function Description
Complete the function minSum in the editor below. 
The function must return an integer denoting the minimum sum of the array after k steps.
 
minSum has the following parameters:
    nums[nums[0],...nums[n-1]]:  an array of integers
    k:  an integer
 
Constraints
1 ≤ n ≤ 105
1 ≤ numi ≤ 104 (where 0 ≤ i < n)
1 ≤ k ≤ 107
 
Input Format For Custom Testing
Sample Case 0
Sample Input For Custom Testing
1
2
1
Sample Output
1
Explanation
The array has only one integer number, which is 2 and the number of steps to take on the array is one. After the first step, the number 2 gets reduced to the number 1 and so, the minimum sum of the array after one step is 1.

*/
