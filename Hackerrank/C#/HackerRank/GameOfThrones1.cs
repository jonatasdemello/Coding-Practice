using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class GameOfThrones1
    {
        public static void entry(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string testCase = Console.ReadLine();
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in testCase)
            {
                if (letterCount.Keys.Contains(c))
                    letterCount[c]++;
                else
                    letterCount[c] = 1;
            }

            if (letterCount.Values.Where(x => x % 2 != 0).Count() <= 1)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
