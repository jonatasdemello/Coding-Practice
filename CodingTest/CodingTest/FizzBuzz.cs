using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    class FizzBuzz
    {
        public void FizzBuz()
        {
            List<int> collection = new List<int>() { 2, 3, 5, 7 };

            foreach (int x in collection)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }


            collection = new List<int>() { 2, 3, 5, 7 };

            foreach (int x in collection)
            {
                if (x % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (x % 5 == 0)
                {
                    Console.Write("Buzz");
                }
            }

            collection = new List<int>() { 2, 3, 5, 7 };

            foreach (int x in collection)
            {
                bool insertNewline = false;
                if (x % 3 == 0)
                {
                    Console.Write("Fizz");
                    insertNewline = true;
                }
                if (x % 5 == 0)
                {
                    Console.Write("Buzz");
                    insertNewline = true;
                }

                if (insertNewline)
                {
                    Console.Write(Environment.NewLine);
                }
            }


        }
    }
}
