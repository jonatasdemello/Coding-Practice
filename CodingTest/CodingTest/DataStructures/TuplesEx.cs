using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataStructures
{
    class TuplesEx
    {
        public void TestTuples()
        {
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");

            var alphabetStart = (Alpha: "a", Beta: "b");
            Console.WriteLine($"{alphabetStart.Alpha}, {alphabetStart.Beta}");

            (int max, int min) = Range(numbers);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
