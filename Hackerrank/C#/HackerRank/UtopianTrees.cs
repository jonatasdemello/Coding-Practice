using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class UtopianTrees
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

            for (int i = 0; i < testCases; i++)
            {
                int height = 1;
                for (int j = 1; j <= cases[i]; j++)
                {
                    if (j % 2 == 1)
                        height *= 2;
                    else
                        height++;
                }
                Console.WriteLine(height);
            }
        }
    }
}
