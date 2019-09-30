using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class CutSticks
    {
        public static void entry(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int testCases;
            int.TryParse(Console.ReadLine(), out testCases);

            int[] cases = Console.ReadLine().Split(' ').Select(x =>
            {
                int value;
                bool success = int.TryParse(x, out value);
                return new { success, value };
            }).Where(pair => pair.success).Select(pair => pair.value).ToArray();

            while (cases.Max() > 0)
            {
                int min = cases.Where(x => x > 0).Min(), count = 0;
                for (int i = 0; i < testCases; i++)
                {
                    if (cases[i] > 0)
                    {
                        count++;
                        cases[i] -= min;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
