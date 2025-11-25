using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodingTest.Codility
{
    /*
    //-----------------------------------------
        BinaryGap
    //-----------------------------------------
    Find longest sequence of zeros in binary representation of an integer.

    A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is 
    surrounded by ones at both ends in the binary representation of N. 

    For example, 
    The number 9 has binary representation 1001 and contains a binary gap of length 2. 
    The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. 
    The number 20 has binary representation 10100 and contains one binary gap of length 1. 
    The number 15 has binary representation 1111 and has no binary gaps. 
    The number 32 has binary representation 100000 and has no binary gaps. 

    Write a function: 
    that, given a positive integer N, returns the length of its longest binary gap. 
    The function should return 0 if N doesn't contain a binary gap. 

    For example, 
    Given N = 1041 the function should return 5, 
        because N has binary representation 10000010001 and so its longest binary gap is of length 5. 
    Given N = 32 the function should return 0, 
        because N has binary representation '100000' and thus no binary gaps. 

    Write an efficient algorithm for the following assumptions: 

    N is an integer within the range [1..2,147,483,647].

    Assume that:
    •	N is an integer within the range [1..2,147,483,647].

    Complexity:
    •	expected worst-case time complexity is O(log(N));
    •	expected worst-case space complexity is O(1).
    */

    public static class BinaryGap
    {
        //public BinaryGap()
        //{
        //    var bin = new BinaryGap();
        //    bin.Solution(1041); // should return 5
        //}
        public static int Solution(int N)
        {
            var result = 0;
            // first conver number to binary
            string binText = Convert.ToString(N, 2);
            
            int binGap = 0;
            int i = 0;
            
            while (i < binText.Length)
            {
                if (binText[i] == '0')
                {
                    binGap++;
                }
                if (binText[i] == '1')
                {
                    if (result < binGap)
                    {
                        result = binGap;
                    }
                    binGap = 0;
                }
                i++;
            }
            Console.WriteLine("Number: {0} \t Binary: {1} \t Gap: {2}", N, binText, result);
            return result;
        }
        public static int Solution2(int value)
        {
            return Convert
                    // convert to binary
                    .ToString(value, 2)
                    // remove leading and trailing 0s, as per requirement
                    .Trim('0')
                    // split the string by 1s
                    .Split(new[] { '1' })
                    // find the length of longest segment
                    .Max(x => x.Length);
        }
        public static int Solution1(int N)
        {
            string binaryRepresentation = Convert.ToString(N, 2);
            int longestBinaryGap = 0;
            int binaryGapLenght = 0;
            for (int i = 1; i < binaryRepresentation.Length; i++)
            {
                if (binaryRepresentation[i - 1] == '1' && binaryRepresentation[i] == '0')
                {
                    binaryGapLenght = 1;
                }
                else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '0')
                {
                    binaryGapLenght++;
                }
                else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '1')
                {
                    longestBinaryGap = Math.Max(longestBinaryGap, binaryGapLenght);
                }
            }
            return longestBinaryGap;
        }

        public static int Solution3(int x)
        {
            BitArray ba = new BitArray(new[] { x });

            int maxCount = 0;
            int startGapIndex = -1;

            for (int i = 0; i < ba.Length; i++)
            {
                if (!ba[i])
                    continue;

                if (startGapIndex != -1)
                {
                    int count = i - startGapIndex - 1;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                startGapIndex = i;
            }
            return maxCount;
        }
        public static int Solution4(int N)
        {
            String str = Convert.ToString(N, 2);
            char[] strArr = Convert.ToString(N, 2).ToCharArray();
            if (strArr.Length > 1)
            {
                for (int count = strArr.Length - 1; count > 1; count--)
                {
                    Console.WriteLine(count);
                    String s1 = "1";
                    s1 += new string('0', count - 1) + "1";
                    MatchCollection matches = Regex.Matches(str, @s1);
                    if (matches.Count > 0)
                        return count - 1;
                }
            }
            return 0;
        }
        public static int Solution5(int N)
        {
            int zeroCount = 0;
            int maxCount = 0;
            string str = Convert.ToString(N, 2).ToString();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i + 1].Equals('0'))
                    zeroCount++;
                else
                {
                    if (str[i].Equals('0'))
                    {
                        if (zeroCount > maxCount)
                        {
                            maxCount = zeroCount;
                        }
                        zeroCount = 0;
                    }
                }
            }
            return maxCount;
        }
        public static int Solution6(int N)
        {
            var maxBinaryGap = 0;
            var zeroCount = 0;
            var foundFirst = false;

            while (N != 0)
            {
                if ((N & 1) == 1)
                {
                    if (foundFirst == false)
                    {
                        foundFirst = true;
                    }
                    else
                    {
                        maxBinaryGap = Math.Max(maxBinaryGap, zeroCount);
                    }
                    zeroCount = 0;
                }
                else
                {
                    zeroCount++;
                }
                N >>= 1;
            }
            return maxBinaryGap;
        }
        public static int Solution7(int N)
        {
            char[] binary = Convert.ToString(N, 2).ToCharArray();
            int firstone = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    firstone = i;
                    break;
                }
            }
            int lastone = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    lastone = i;
                    break;
                }
            }
            int count = 0;
            int max = 0;
            for (int i = firstone; i <= lastone; i++)
            {
                if (binary[i] == '0')
                {
                    count++;
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 0;
                }
            }
            return max;
        }
        public static int Solution8(int N)
        {
            string binary = Convert.ToString(N, 2);
            Regex regex = new Regex("1(.*)1");
            Match chars = regex.Match(binary);
            string binaryAfterRegex = chars.Value;
            string[] gaps = binaryAfterRegex.Split('1');
            int t = 0;
            foreach (string txt in gaps)
            {
                if ((string.IsNullOrEmpty(txt)) == false)
                {
                    while (txt.Length > t)
                    {
                        t = txt.Length;
                    }
                }
            }
            return 0;
        }
    }
}

