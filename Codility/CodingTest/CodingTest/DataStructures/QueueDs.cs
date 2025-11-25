using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataStructures
{
    class QueueDs
    {
        public void TestQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");

            Console.WriteLine("Contains(2): "+ queue.Contains("2"));

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
