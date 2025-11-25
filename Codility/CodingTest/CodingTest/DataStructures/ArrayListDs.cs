using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataStructures
{
    class ArrayListDs
    {
        public void TestArray()
        {
            // ArrayList, is a dynamic array. What that means is an ArrayList can have any amount of objects and of any type.
            // This data structure was designed to simplify the processes of adding new elements into an array. 
            // Under the hood, an ArrayList is an array whose size is doubled every time it runs out of space. 
            // Doubling the size of the internal array is a very effective strategy that reduces the amount of element-copying in the long run.

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(56);
            myArrayList.Add("String");
            myArrayList.Add(3.14);

            // The downside to the ArrayList data structure is one must cast the retrived values back into their original type:
            int arrayListValue = (int)myArrayList[0];
            Console.WriteLine("myArrayList[0]: " + arrayListValue);

            Console.WriteLine("Contains(2): " + myArrayList.Contains(2));
        }
    }
}
