using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class HalloweenParty
    {
        public static void entry(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int testCases;
            int.TryParse(Console.ReadLine(), out testCases);

            int[] cases = new int[testCases];
            for (int i = 0; i < testCases; i++)
            {
                int.TryParse(Console.ReadLine(), out cases[i]);
            }

            foreach (double test in cases)
                if (test % 2 == 0)
                    Console.WriteLine((test / 2) * (test / 2));
                else
                    Console.WriteLine((Math.Truncate(test / 2) + 1) * (Math.Truncate(test / 2)));
        }
    }
}
