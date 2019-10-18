using System;
using System.Linq;

namespace CodingTest
{
    public class CommonChars
    {
        /*
        3. Question #3
        Write a function which takes two string arguments and returns a 
        string containing only the common characters found between the two strings.
        */
        public string Solution(string str1, string str2)
        {
            var s1 = str1.ToCharArray().ToList();
            var s2 = str2.ToCharArray().ToList();

            var res = s1.Intersect(s2).ToList();
            var s = String.Concat(res);

            return s;
        }
        // Console.WriteLine(common("abcd", "cdefg"));
        // Console.WriteLine(common("abcde", "edcfvf"));
    }
}
