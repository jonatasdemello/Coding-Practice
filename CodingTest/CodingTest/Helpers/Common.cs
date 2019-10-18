using System;
using System.Collections.Generic;

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
    }
}
