using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace CodingTest.Helpers
{
    public class StopWatchHelper
    {
        public StopWatchHelper()
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(2000);
            stopwatch.Stop();
            TimeSpan stopwatchElapsed = stopwatch.Elapsed;
            Console.WriteLine(Convert.ToInt32(stopwatchElapsed.TotalMilliseconds));

        }
    }
}
