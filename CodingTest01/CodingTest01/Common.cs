using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodingTest01
{
    public static class Common
    {
        //Function to get random number
        private static readonly Random getrandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
        public static int[] GetArray()
        {
            List<int> termsList = new List<int>();
            for (int runs = 0; runs < 100000; runs++)
            {
                termsList.Add(GetRandomNumber(0, 1000000));
            }

            // You can convert it back to an array if you would like to
            int[] terms = termsList.ToArray();
            return terms;
        }

        public static int ConvertToNumber(string num)
        {
            int i = 0;
            if (!Int32.TryParse(num, out i))
            {
                i = -1;
            }
            return i;
        }

        public static int solution0(int[] A)
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
        public static int solution1(int[] A)
        {
            // using Linq
            var listA = new List<int>(A);
            var listB = listA.Distinct();

            return listA.IndexOf(listB.Last());
        }
        public static int solution(int[] A)
        {
            // The first covering prefix of array A is the smallest integer P such that 0<=P<N and such that 
            // every value that occurs in array A also occurs in sequence A[0], A[1], ..., A[P].
            var length = A.Length;
            List<int> unique = new List<int>();

            if (length == 0) return 0;
            if (length == 1) return 0;

            // first add unique elements
            for (var i = 0; i < length; i++)
            {
                if (unique.IndexOf(A[i]) == -1)
                {
                    unique.Add(A[i]); // add to list
                }
            }
            //again, remove until the list is empty
            for (var i = 0; i < length; i++)
            {
                if (unique.IndexOf(A[i]) > -1)
                {
                    unique.Remove(A[i]); // remove from list
                }
                if (unique.Count == 0)
                {
                    return i;
                }
            }
            return 0;
        }
        public static int solution2(int[] A)
        {
            // The first covering prefix of array A is the smallest integer P such that 0<=P<N and such that 
            // every value that occurs in array A also occurs in sequence A[0], A[1], ..., A[P].
            // N is an integer within the range [1..1,000,000];
            // each element of array A is an integer within the range [0..N−1].
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
        public static void RunTest1()
        {
            int[] test0 = new int[] { 5 };
            int[] test1 = new int[] { 2, 2, 1, 0, 1 };

            int[] test2 = GetArray();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Solution: {0}", solution0(test1));
            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);

            sw.Reset();
            sw.Start();
            Console.WriteLine("Linq: {0}", solution1(test2));
            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
        }

    }
}
