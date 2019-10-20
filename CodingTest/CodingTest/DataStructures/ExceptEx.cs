using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    class ExceptEx
    {
        public void TestExceptEx()
        {
            // Produces the set difference of two sequences
            // The set difference of two sets is defined as the members of the first set that don't appear in the second set.

            double[] numbers1 = { 2.0, 2.0, 2.1, 2.2, 2.3, 2.3, 2.4, 2.5 };
            double[] numbers2 = { 2.2 };

            IEnumerable<double> onlyInFirstSet = numbers1.Except(numbers2);

            foreach (double number in onlyInFirstSet)
                Console.WriteLine(number);

            /*
             This code produces the following output:
             2
             2.1
             2.3
             2.4
             2.5
            */
        }

    }
}
