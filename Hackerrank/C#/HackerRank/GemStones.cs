using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class GemStones
    {
        public static void entry(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int iter, count = 0;
            Int32.TryParse(Console.ReadLine(), out iter);

            string[] rocks = new string[iter];
            for (int i = 0; i < iter; i++)
            {
                rocks[i] = Console.ReadLine();
            }

            for (int i = 97; i <= 122; i++)
            {
                if (rocks.Where(x => x.Contains((char)i)).Count() == iter)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
