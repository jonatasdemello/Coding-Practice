using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodingTest
{
    public class ReverseArrayBenchmark
    {
        static void Solution()
        {
            // https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string

            Console.WriteLine("Reverse String Benchmark \n");

            int[] lengths = new int[] { 1, 10, 15, 25, 50, 75, 100, 1000, 100000 };

            var totalSB = new List<double>();
            var totalAr = new List<double>();
            var totalXr = new List<double>();

            foreach (int l in lengths)
            {
                int iterations = 10000;
                string text = StringOfLength(l);

                Console.WriteLine();

                totalSB.Add(Benchmark(String.Format("String Builder (Length: {0})", l), ReverseSB, iterations, text));
                totalAr.Add(Benchmark(String.Format("Array.Reverse  (Length: {0})", l), ReverseArray, iterations, text));
                totalXr.Add(Benchmark(String.Format("Array Xor      (Length: {0})", l), ReverseXor, iterations, text));

                Console.WriteLine();
            }
            Console.WriteLine(String.Format("Average String Builder (Length: {0,12:0.00})", totalSB.Average()));
            Console.WriteLine(String.Format("Average Array.Reverse  (Length: {0,12:0.00})", totalAr.Average()));
            Console.WriteLine(String.Format("Average Array Xor      (Length: {0,12:0.00})", totalXr.Average()));
        }

        // <access modifier> delegate <return type> <delegate_name>(<parameters>)
        delegate string StringDelegate(string s);

        static long Benchmark(string description, StringDelegate d, int times, string text)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int j = 0; j < times; j++)
            {
                d(text);
            }
            sw.Stop();
            Console.WriteLine("{0,12} \t Ticks {1} : called {2} times.", sw.ElapsedTicks, description, times);

            return sw.ElapsedTicks;
        }

        public static string ReverseArray(string text)
        {
            if (text == null) return null;
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
        }

        public static string ReverseSB(string text)
        {
            StringBuilder builder = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                builder.Append(text[i]);
            }
            return builder.ToString();
        }

        public static string ReverseStringDirect(string s)
        {
            char[] array = new char[s.Length];
            int forward = 0; ;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                array[forward++] = s[i];
            }
            return new string(array);
        }

        public static string ReverseXor(string s)
        {
            if (s == null) return null;
            char[] charArray = s.ToCharArray();
            int len = s.Length - 1;

            for (int i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }
            return new string(charArray);
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
    }
}
