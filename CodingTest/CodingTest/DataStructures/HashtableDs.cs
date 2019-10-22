using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataStructures
{
    class HashtableDs
    {
        public void TestHashtable()
        {
            // A Hashtable is similar to generic Dictionary collection
            // ot also takes in a key/value pair, but it does so as generic objects as opposed to typed data.
            // Values are then stored in order according to their key's HashCode. 
            // Meaning that the order in which items are added to a C# Hashtable is not preserved. 
            // On the other hand, the Dictionary data structure does keep items in the same order.
            // The reason is speed. 
            // A C# Hashtable stores items faster than a C# Dictionary, which sacrifices speed for the sake of order.

            Hashtable ht1 = new Hashtable() {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" },
                { 5, null },
                { "Fv", "Five" },
                { 8.5F, 8.5 } };

            // Hashtable can include all the elements of Dictionary as shown below.
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            Hashtable htDict = new Hashtable(dict);

            // Add() will throw an exception if you try to add a key that already exists in the Hashtable.
            // So always check the key using the Contains() or ContainsKey() 
            // method before adding a key-value pair into the Hashtable

            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);

            // Hashtable is a non - generic collection so it can contains a key and a value of any data type. 
            // So values must be cast to an appropriate data type otherwise it will give compile - time error.
            string strValue1 = (string)ht[2];
            string strValue2 = (string)ht["Fv"];
            float fValue = (float)ht[8.5F];

            Console.WriteLine(strValue1); // Two
            Console.WriteLine(strValue2); // Five
            Console.WriteLine(fValue); // 8.5

            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);

            foreach (var key in ht.Keys)
                Console.WriteLine("Key:{0}, Value:{1}", key, ht[key]);
            foreach (var value in ht.Values)
                Console.WriteLine("Value:{0}", value);

        }
    }
}
