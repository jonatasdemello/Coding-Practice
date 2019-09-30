using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class LoveLetter
    {
        public static void entry(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int testCases;
            int.TryParse(Console.ReadLine(), out testCases);

            string[] words = new string[testCases];
            for (int i = 0; i < testCases; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < testCases; i++)
            {
                int count = 0;
                for (int j = 0, k = words[i].Length - 1; j < k; j++, k--)
                {
                    count += Math.Abs(words[i][k] - words[i][j]);
                }
                Console.WriteLine(count);
            }
        }
    }
}
