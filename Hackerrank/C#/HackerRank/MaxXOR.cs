using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class MaxXOR
    {
        static int maxXor(int l, int r)
        {
            int max = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = i; j <= r; j++)
                    max = Math.Max(max, i ^ j);
            }
            return max;
        }
        public static void entry(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }
    }
}
