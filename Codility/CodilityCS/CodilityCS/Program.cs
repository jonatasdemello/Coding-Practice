using System;

namespace CodilityCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var bin = new BinaryGap();
            bin.Solution(1041); // should return 5

            var missing = new MissingInteger();
            var m = missing.Solution(new int[] { 1, 3, 6, 4, 1, 2 });
            Console.WriteLine("MissingInteger: {0}", m);
        }
    }
}
