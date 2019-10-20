using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    public static class AggregateEx
    {

        public static void AggregateSum()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var sum = nums.Aggregate((a, b) => a + b);
            Console.WriteLine(sum); // output: 10 (1+2+3+4)
        }

        public static void AggregateMultiply()
        {
            var multipliers = new[] { 10, 20, 30, 40 };
            var multiplied = multipliers.Aggregate(5, (a, b) => a * b); // 5 = seed value
            Console.WriteLine(multiplied); //Output 1200000 ((((5*10)*20)*30)*40)
        }

        public static void AggregateCsv()
        {
            var chars = new[] { "a", "b", "c", "d" };
            var csv = chars.Aggregate((a, b) => a + ',' + b);
            Console.WriteLine(csv); // Output a,b,c,d
        }
        public static void AggregateCsvSb()
        {
            var chars = new[] { "a", "b", "c", "d" };
            var csv = chars.Aggregate(new StringBuilder(), (a, b) => {
                if (a.Length > 0)
                    a.Append(",");
                a.Append(b);
                return a;
            });
            Console.WriteLine(csv);
        }
        public static void AggregateFruits()
        {
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

            // Determine whether any string in the array is longer than "banana".

            string longestName = fruits.Aggregate("banana",  // seed = The initial accumulator value.
                (longest, next) => next.Length > longest.Length ? next : longest, // func = An accumulator function to be invoked on each element.
                fruit => fruit.ToUpper()); // resultSelector = A function to transform the final accumulator value into the result value.
             
            Console.WriteLine("The fruit with the longest name is {0}.", longestName);

            // This code produces the following output:
            // The fruit with the longest name is PASSIONFRUIT.
        }
        public static void AggregateSeed()
        {
            int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };

            // Count the even numbers in the array, using a seed value of 0.
            int numEven = ints.Aggregate(0, (total, next) => next % 2 == 0 ? total + 1 : total);

            Console.WriteLine("The number of even integers is: {0}", numEven);

            // This code produces the following output:
            // The number of even integers is: 6
        }
        public static void AggregateReverseWords()
        {
            string sentence = "the quick brown fox jumps over the lazy dog";

            // Split the string into individual words.
            string[] words = sentence.Split(' ');

            // Prepend each word to the beginning of the new sentence to reverse the word order.
            string reversed = words.Aggregate((workingSentence, next) => next + " " + workingSentence);

            Console.WriteLine(reversed);

            // This code produces the following output:
            // dog lazy the over jumps fox brown quick the
        }
    }
}
