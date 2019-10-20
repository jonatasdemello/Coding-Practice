using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    class ZipEx
    {
        void TestZipEx()
        {
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            var numbersAndWords = numbers.Zip(words, (first, second) => first + " = " + second);

            foreach (var item in numbersAndWords)
                Console.WriteLine(item);

            // This code produces the following output:
            // 1 one
            // 2 two
            // 3 three


            // Two source arrays.
            var array1 = new int[] { 1, 2, 3, 4, 5 };
            var array2 = new int[] { 6, 7, 8, 9, 10 };

            // Add elements at each position together.
            var zip = array1.Zip(array2, (a, b) => (a + b));

            // Look at results.
            foreach (var value in zip)
            {
                Console.WriteLine(value);
            }

        }
    }
}
