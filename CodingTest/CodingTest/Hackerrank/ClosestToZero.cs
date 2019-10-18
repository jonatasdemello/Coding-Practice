/*
// ClosestToZero
Write a program that prints the temperature closest to 0 among input data.
 
INPUT:
Line 1: N, the number of temperatures to analyse
Line 2: The N temperatures expressed as integers ranging from -273 to 5526
 
OUTPUT:
Display 0 (zero) if no temperature is provided
Otherwise, display the temperature closest to 0, knowing that if two numbers are equally close to zero, positive integer has to be considered closest to zero (for instance, if the temperatures are -5 to 5, then display 5)
 
CONSTRAINTS:
0 ≤ N < 10000
 
EXAMPLE:
Input
5
1 -2 -8 4 5
Output: 1

10
-5 -4 -2 12 -40 4 2 18 11 5
Output: 2
*/
using System;
using System.Linq;

namespace CodingTest
{
    public class ClosestToZero
    {
        public void Solution1()
        {
            var min = 0;

            string line = Console.ReadLine();
            int n = Convert.ToInt32(line);
            if (n > 0)
            {
                var values = Console.ReadLine();
                var arr = values.Split(' ');

                min = Int32.Parse(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    int val = Int32.Parse(arr[i]);

                    if (val > 0 && val < Math.Abs(min))
                        min = val;
                    else if (val < 0 && Math.Abs(val) < Math.Abs(min))
                        min = val;

                    if (min < 0 && val > 0 && Math.Abs(val) == Math.Abs(min))
                        min = val;
                }
            }
            Console.WriteLine(min);
        }
        public void Solution2()
        {
            var min = 0;

            string line = Console.ReadLine();
            int n = Convert.ToInt32(line);
            if (n > 0)
            {
                var value = Console.ReadLine();
                var arr = value.Split(' ');

                var minPos = Int32.Parse(arr[0]);
                var minNeg = Int32.Parse(arr[0]);

                for (int i = 0; i < arr.Length; i++)
                {
                    int val = Int32.Parse(arr[i]);

                    if (val > 0 && val <= minPos)
                        minPos = val;

                    if (val < 0 && Math.Abs(val) <= Math.Abs(minNeg))
                        minNeg = val;
                }
                if (Math.Abs(minNeg) < Math.Abs(minPos))
                    min = minNeg;

                if (Math.Abs(minPos) <= Math.Abs(minNeg))
                    min = minPos;
            }
            Console.WriteLine(min);
        }
        public void Solution3()
        {
            // using Linq
            string line = Console.ReadLine();
            int n = Convert.ToInt32(line);
            if (n > 0)
            {
                string valuesLine = Console.ReadLine();
                if (!string.IsNullOrEmpty(valuesLine))
                {
                    var numbers = valuesLine.Split(' ').Select(Int32.Parse).ToList();
                    var posNum = numbers.Where(x => x > 0).OrderBy(x => x).ToList();
                    var negNum = numbers.Where(x => x < 0).OrderByDescending(x => x).ToList();

                    var res = 0;
                    if (Math.Abs(posNum[0]) <= Math.Abs(negNum[0]))
                    {
                        res = posNum[0];
                    }
                    else
                        res = negNum[0];

                    Console.WriteLine(res);
                }
            }
            else
                Console.WriteLine("0");
        }
        /// This method finds the number closest to​​​​​​‌​​​‌​​‌​‌​‌‌​‌​‌​​‌​‌‌​‌ zero.
        public int Solution4(int[] ints)
        {
            var min = 0;

            if (ints.Length > 0)
            {
                min = Convert.ToInt32(ints[0]);
                for (int i = 1; i < ints.Length; i++)
                {
                    int val = Convert.ToInt32(ints[i]);

                    if (val > 0 && val < Math.Abs(min))
                        min = val;
                    else if (val < 0 && Math.Abs(val) < Math.Abs(min))
                        min = val;

                    if (min < 0 && val > 0 && Math.Abs(val) == Math.Abs(min))
                        min = val;
                }
            }
            return min;
        }
    }
}

/*
// O(n)
int[] arr = {1,4,5,6,7,-1};

int closestIndex = 0;
int diff = Integer.MAX_VALUE;
for (int i = 0; i < arr.length; ++i) {
    int abs = Math.abs(arr[i]);
    if (abs < diff) {
        closestIndex = i;
        diff = abs;
    } else if (abs == diff && arr[i] > 0 && arr[closestIndex] < 0) {
        //same distance to zero but positive 
        closestIndex =i;
    }
}   
System.out.println(arr[closestIndex ]);
*/