using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest
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

        public static int[] GenerateArray(int minVal, int maxVal, int numItems)
        {
            Random randNum = new Random();
            int[] testArray = Enumerable
                .Repeat(0, numItems)
                .Select(i => randNum.Next(minVal, maxVal))
                .OrderBy(i => i)
                .ToArray();
            return testArray;
        }
        public static int[] GenerateArray1(int minVal, int maxVal, int numItems)
        {
            // create a sequence from 0 to 999 (1000 items),
            // for each int, project to the next random number, then convert to Array
            Random randNum = new Random();
            int[] testArray = Enumerable
                .Range(0, numItems)
                .Select(i => randNum.Next(minVal, maxVal))
                .OrderBy(i => i)
                .ToArray();
            return testArray;
        }

        public static string StringOfLength(int length)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))));
            }
            return sb.ToString();
        }

        public static void DisplayArray<T>(T[] arr1)
        {
            foreach (var item in arr1)
                Console.WriteLine(item);
        }
        public static void DisplayList<T>(List<T> t)
        {
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
        }
        public static void DisplayItems<T>(IList<T> coll)
        {
            Console.Write("[ ");

            foreach (T item in coll)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("]");

        }
    }
}
