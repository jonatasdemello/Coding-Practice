using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class ChocolateFeast
    {
        public static void entry(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int m;
            m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int N, C, M, chocCount, wrapCount;
                int.TryParse(values[0], out N);
                int.TryParse(values[1], out C);
                int.TryParse(values[2], out M);

                wrapCount = chocCount = N / C;
                while (wrapCount / M > 0)
                {
                    chocCount += wrapCount / M;
                    wrapCount = wrapCount / M + wrapCount % M;
                }
                Console.WriteLine(chocCount);
            }

            
        }
    }
}
