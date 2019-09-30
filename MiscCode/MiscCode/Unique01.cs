using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MiscCode
{
    public static class Unique01
    {
        // C# program that benchmarks duplicate removal methods
        public static void Solution()
        {
            for (int test = 0; test < 3; test++)
            {
                // gettestdata.
                var testData = GetTestData(test);
                var max = testData.Item4;

                var s1 = Stopwatch.StartNew();
                for (int i = 0; i < max; i++)
                {
                    // Version 1: use Distinct.
                    var unique = testData.Item2.Distinct().ToList();
                    if (unique.Count != testData.Item3)
                    {
                        return;
                    }
                }
                s1.Stop();
                var s2 = Stopwatch.StartNew();
                for (int i = 0; i < max; i++)
                {
                    // Version 2: use HashSet.
                    var unique = RemoveDuplicatesSet(testData.Item2);
                    if (unique.Count != testData.Item3)
                    {
                        return;
                    }
                }
                s2.Stop();
                var s3 = Stopwatch.StartNew();
                for (int i = 0; i < max; i++)
                {
                    // Version 3: use nested for-loop.
                    var unique = RemoveDuplicatesIterative(testData.Item2);
                    if (unique.Count != testData.Item3)
                    {
                        return;
                    }
                }
                s3.Stop();
                // Write description.
                Console.WriteLine(testData.Item1);
                // Write timings.
                Console.WriteLine(s1.Elapsed.TotalMilliseconds + " ms");
                Console.WriteLine(s2.Elapsed.TotalMilliseconds + " ms");
                Console.WriteLine(s3.Elapsed.TotalMilliseconds + " ms");
            }
        }

        static Tuple<string, List<string>, int, int> GetTestData(int test)
        {
            // Tuple contains description string, list, the unique element count, and iterations for test.
            switch (test)
            {
                default:
                case 0:
                    return new Tuple<string, List<string>, int, int>("3 ELEMENT LIST, 0 DUPLICATES",
                        GetListWithDuplicates(3, 0),
                        3,
                        100000);
                case 1:
                    return new Tuple<string, List<string>, int, int>("300 ELEMENT LIST, 100 DUPLICATES",
                        GetListWithDuplicates(200, 100),
                        201,
                        1000);
                case 2:
                    return new Tuple<string, List<string>, int, int>("3000 ELEMENT LIST, 1000 DUPLICATES",
                        GetListWithDuplicates(2000, 1000),
                        2001,
                        100);
            }
        }

        public static List<string> GetListWithDuplicates(int length, int duplicatesLength)
        {
            const string duplicateString = "bird";
            List<string> result = new List<string>();
            for (int i = 0; i < length; i++)
            {
                result.Add("cat" + i);

                if (duplicatesLength > 0)
                {
                    result.Add(duplicateString);
                    duplicatesLength--;
                }
            }

            for (int i = 0; i < duplicatesLength; i++)
            {
                result.Add(duplicateString);
            }
            return result;
        }

        public static List<string> RemoveDuplicatesSet(List<string> items)
        {
            var result = new List<string>();
            var set = new HashSet<string>();
            for (int i = 0; i < items.Count; i++)
            {
                if (!set.Contains(items[i]))
                {
                    result.Add(items[i]);
                    set.Add(items[i]);
                }
            }
            return result;
        }

        public static List<string> RemoveDuplicatesIterative(List<string> items)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < items.Count; i++)
            {
                bool duplicate = false;
                for (int z = 0; z < i; z++)
                {
                    if (items[z] == items[i])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }
    }
}
//Results
//3 ELEMENT LIST, 0 DUPLICATES
//37.9524 ms
//19.9176 ms
//8.0359 ms
//300 ELEMENT LIST, 100 DUPLICATES
//23.1117 ms
//20.499 ms
//188.2431 ms
//3000 ELEMENT LIST, 1000 DUPLICATES
//22.7601 ms
//21.4638 ms
//1765.6447 ms
