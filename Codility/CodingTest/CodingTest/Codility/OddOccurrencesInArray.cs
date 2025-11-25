using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.Codility
{
    public static class OddOccurrencesInArray
    {
        public static int Solution(int[] A)
        {
            return A.Aggregate((x, y) => x ^ y); // XOR
        }
        //Console.WriteLine(true ^ true);    // output: False
        //Console.WriteLine(true ^ false);   // output: True
        //Console.WriteLine(false ^ true);   // output: True
        //Console.WriteLine(false ^ false);  // output: False
        public static int Solution1(int[] A)
        {
            Array.Sort(A);
            int i = 0;
            for (i = 0; i < A.Length - 1 && A[i] == A[i + 1]; i += 2) ;
            return A[i];
        }

        public static int Solution2(int[] A)
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (evenNumbers.Contains(A[i]))
                    evenNumbers.Remove(A[i]);
                else
                    evenNumbers.Add(A[i]);
            }
            int N = 0;
            foreach (var n in evenNumbers)
            {
                N = n;
                break;
            }
            return N;
        }

        public static int solution1(int[] A)
        {
            Array.Sort(A);
            int i, j, count = 0;
            for (i = 0; i < A.Length; i++)
            {
                for (j = i + 1; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                        count++;
                    else
                        break;
                }
                if (count % 2 == 0)
                    return A[i];
                else
                {
                    count = 0;
                    i = j - 1;
                }
            }
            return 0;
        }
        public static int solution2(int[] A)
        {
            Array.Sort(A);
            int i;
            for (i = 0; i < A.Length - 1 && A[i] == A[i + 1]; i += 2) ;
            return A[i];
        }
        public static int solution3(int[] A)
        {
            LinkedList<int> ll = new LinkedList<int>();
            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (!ll.Remove(A[i]))
                {
                    ll.AddLast(A[i]);
                }
            }
            return ll.First.Value;
        }

        /*
        function solutionJavaScript(A)
        {
            N = A.length;
            if (N === 1)
            {
                return A[0];
            }
            A.sort(function(a, b){
                return a - b;
            });
            for (i = 0; i < N - 1; i += 2)
            {
                if (A[i] != A[i + 1])
                {
                    return A[i];
                    break;
                }
            }
            return A[N - 1];
        }
        function solutionJavaScript(A)
        {
            var result = 0;
            for (var number in A)
            {
                result ^= number;
            }
            return result
        }
        */
    }
}
/*
OddOccurrencesInArray
Find value that occurs in odd number of elements.

A non-empty array A consisting of N integers is given. 
The array contains an odd number of elements, and each 
element of the array can be paired with another element 
that has the same value, except for one element that is left unpaired.

For example, in array A such that:
  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
the elements at indexes 0 and 2 have value 9,
the elements at indexes 1 and 3 have value 3,
the elements at indexes 4 and 6 have value 9,
the element at index 5 has value 7 and is unpaired.
Write a function:
class Solution { public static int solution(int[] A); }
that, given an array A consisting of N integers fulfilling the above conditions, 
returns the value of the unpaired element.

For example, given array A such that:
  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
the function should return 7, as explained in the example above.

Write an efficient algorithm for the following assumptions:

N is an odd integer within the range [1..1,000,000];
each element of array A is an integer within the range [1..1,000,000,000];
all but one of the values in A occur an even number of times.

def solution(A):
    result = 0
    for number in A:
        result ^= number
    return result

def solution(A):
    # write your code in Python 2.7
    ocurrences = dict()
    for n in A:
        if ocurrences.get(n):
            ocurrences[n] += 1;
        else:
            ocurrences[n] = 1;
    for n in ocurrences:
        if ocurrences[n] % 2 <> 0:
            return n
    pass

def solution(A):
    bag = set()
    for n in A:
        if n in bag:
            bag.remove(n)
        else:
            bag.add(n)
    return bag.pop()
*/
