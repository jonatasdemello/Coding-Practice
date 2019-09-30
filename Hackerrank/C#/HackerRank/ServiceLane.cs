using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class ServiceLane
    {
        public static void entry(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int highwayLength, casesLength;
            string[] lengths = Console.ReadLine().Split(' ');
            int.TryParse(lengths[0], out highwayLength);
            int.TryParse(lengths[1], out casesLength);

            int[] width = Console.ReadLine().Split(' ').Select(x =>
                {
                    int value;
                    bool success = int.TryParse(x, out value);
                    return new { value, success };
                }).Where(pair => pair.success).Select(pair => pair.value).ToArray();

            string[] testCases = new string[casesLength];
            for (int i = 0; i < casesLength; i++)
            {
                testCases[i] = Console.ReadLine();
            }

            for (int a = 0; a < casesLength; a++)
            {
                int i, j;
                string[] len = testCases[a].Split(' ');
                int.TryParse(len[0], out i);
                int.TryParse(len[1], out j);

                Console.WriteLine(width.ToList().GetRange(i, j - i + 1).Min());
            }
        }
    }
}
