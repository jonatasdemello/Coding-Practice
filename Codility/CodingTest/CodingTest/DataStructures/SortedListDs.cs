using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataStructures
{
    class SortedListDs
    {
        public void TestSortedList()
        {
            // SortedList SortedList<TKey, TValue> represents a collection of key-value pairs 
            // that are sorted by key based on associated IComparer<T>. 
            // A SortedList collection stores key and value pairs in ascending order of key by default.

            // Internally, SortedList maintains two object[] array, one for keys and another for values. 
            // So when you add key-value pair, it runs a binary search using the key to find an 
            // appropriate index to store a key and value in respective arrays. 
            // It re-arranges the elements when you remove the elements from it.

            // SortedList collection sorts the elements everytime you add the elements. 

            // Generic SortedList
            SortedList<int, string> mySortedList = new SortedList<int, string>();

            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            SortedList<string, int> sortedList2 = new SortedList<string, int>();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);
            // Compile time error: cannot convert from <null> to <int>
            // sortedList2.Add("Five", null);

            Console.WriteLine(sortedList2["one"]);
            Console.WriteLine(sortedList2["two"]);
            Console.WriteLine(sortedList2["three"]);

            //Following will throw runtime exception: KeyNotFoundException
            Console.WriteLine(sortedList2["ten"]);

            for (int i = 0; i < sortedList2.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", sortedList2.Keys[i], sortedList2.Values[i]);
            }
            // or
            foreach (KeyValuePair<string, int> kvp in sortedList2)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }

            // Accessing key
            int val;

            if (sortedList2.TryGetValue("ten", out val))
                Console.WriteLine("value: {0}", val);
            else
                Console.WriteLine("Key is not valid.");

            if (sortedList2.TryGetValue("one", out val))
                Console.WriteLine("value: {0}", val);


            SortedList<double, int?> sortedList3 = new SortedList<double, int?>();
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, null);
            sortedList3.Add(1.1, null);

            SortedList<int, string> sortedList4 = new SortedList<int, string>()
                {
                    {3, "Three"},
                    {4, "Four"},
                    {1, "One"},
                    {5, "Five"},
                    {2, "Two"}
                };
}
        
    }
}
