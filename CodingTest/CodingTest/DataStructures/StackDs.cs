using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataStructures
{
    class StackDs
    {
        public void TestStack()
        {
            // Stack stack = new Stack(); // work with Object
            Stack<string> stack = new Stack<string>();

            stack.Push("1");
            stack.Push("2");
            stack.Push("3");

            Console.WriteLine("Contains(2): " + stack.Contains("2"));

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
