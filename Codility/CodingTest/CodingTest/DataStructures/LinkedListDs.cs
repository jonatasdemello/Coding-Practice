using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataStructures
{
    class LinkedListDs
    {
        public void TestArray()
        {
            // A LinkedList is a series of objects which instead of having their references indexed (like an Array), 
            // stay together by linking to each other, in Nodes.
            // A LinkedList Node has basically three values: 
            // the Object's Value, a reference to the Next node, and a reference to the Previous Node.

            // What is the point of such C# data structure? 
            // Well, adding values to the middle of the list is much faster compared to any other Array type of data structure. 
            // It also keeps memory costs down to a minimum. 
            // Lists on the other hand use extra space to make future insertions as fast as possible.

            // Since inserting and removing elements is done by updating a couple references, they can be done in constant time. 
            // The tradeoff is that accessing elements is no longer a constant time operation. 
            // In an array, with a given index an element can be instantly accessed. 
            // With a linked list, the references between nodes need to be followed until the desired element is found.

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(6);
            
            //Retrieving a value is not as straight forward:
            Console.WriteLine(list.First.Value);
            Console.WriteLine(list.Last.Value);

            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Bozo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //insert new element before "Peter"  
            LinkedListNode<String> node = names.Find("Peter");
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
