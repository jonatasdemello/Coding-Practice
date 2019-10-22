using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using CodingTest.Udemy;

namespace CodingTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 25));

            //var N = BinaryGap.Solution(9);
            //Console.WriteLine("result: {0}", N);

            //var res = CyclicRotation.Solution(new int[] { 1, 2, 3, 4, 5 }, 2);
            //Console.WriteLine("result: {0}", string.Join(",", res));

            //CompareSearch.CompareSearches();

            //var b = new BinarySearch();
            //b.TestBinarySearch();

            var s = new TwoSum();
            var res = s.TestTwoSum(new int[] { 1, 6, 4, 5, 3, 3 }, 7);
            Common.DisplayList(res);

            var res1 = s.TestTwoSum1(new int[] { 1, 6, 4, 5, 3, 3 }, 7);
            foreach (var item in res1)
                Common.DisplayItems(item);

            var r = Common.GenerateArray(1, 100, 5);
            Common.DisplayItems(r);

            var r1 = Common.GenerateArray1(1, 100, 5);
            Common.DisplayItems(r1);
            
            //Console.ReadLine();
        }
    }
}
