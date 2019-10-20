using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodingTest
{
    public static class CompareSearch
    {
        public static void CompareSearches()
        {
            Random randNum = new Random();
            int[] test2 = Enumerable
                .Repeat(0, 1000000)
                .Select(i => randNum.Next(-10000, 10000))
                .OrderBy(i => i)
                .ToArray();

            var time0 = StopwatchHelper.MeasureRunTime(() =>
            {
                ExistsInArray.ExistsSequential(test2, test2[333]);
            });
            Console.WriteLine("Sequential Time elapsed: " + time0);

            var time1 = StopwatchHelper.MeasureRunTime((Action)(() =>
            {
                ExistsInArray.ExistsBinarySearch((int[])test2, (int)test2[(int)333]);
            }));
            Console.WriteLine("Binary 1   Time elapsed: " + time1);

            var time2 = StopwatchHelper.MeasureRunTime((Action)(() =>
            {
                ExistsInArray.ExistsBinarySearch((int[])test2, (int)test2[(int)333]);
            }));
            Console.WriteLine("Binary 2   Time elapsed: " + time2);
        }
        static class StopwatchHelper
        {
            public static TimeSpan MeasureRunTime(Action codeToRun)
            {
                var watch = Stopwatch.StartNew();
                codeToRun();
                watch.Stop();
                return watch.Elapsed;
            }
        }
    }
}
