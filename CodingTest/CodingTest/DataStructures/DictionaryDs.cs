using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    class DictionaryDs
    {
        public void TestDictionary()
        {
            // Dictionary<TKey, TValue> is a generic data structure that allows to store keys/value pairs.
            // A List<> can only store values

            // Dictionary cannot include duplicate or null keys, where as values can be duplicated or set as null. 
            // Keys must be unique otherwise it will throw a runtime exception.

            // Because elements are NOT automatically sorted, inserting elements is faster.
            // Because elements are not sorted, it makes searching more complicated, meaning searching is slower.

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("one", 1);
            myDictionary.Add("twenty", 20);
            // or
            
            IDictionary<int, string> dict = new Dictionary<int, string>()
                {
                    {1,"One"},
                    {2, "Two"},
                    {3,"Three"}
                };

            // Retrieving a value is pretty straight forward:
            Console.WriteLine(myDictionary["one"]);

            Dictionary<int, Dictionary<string, int>> nestedDictionary = new Dictionary<int, Dictionary<string, int>>();

            // Traversing a dictionary
            List<string> keyList = new List<string>(myDictionary.Keys);
            for (int i = 0; i < keyList.Count; i++)
            {
                Console.WriteLine(myDictionary[keyList[i]]);
            }

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

        }

        public void TestSortedDictionary()
        {
            // A Dictionary keeps elements in the order the were added. 
            // A SortedDictionary keeps elements sorted based on their comparer.

            // In a SortedDictionary elements must be sorted when they are added, making insertion times slower.
            // But since elements are kept stored, searching can be done with binary search, meaning searching is faster.

            // Adding the following key/value pairs: (1, 1), (3, 3), (2, 2), (4, 4) 
            // and then outputting the values in order would yield:
            // to a Dictionary  -> 1, 3, 2, 4
            // to a SortedDictionary -> 1, 2, 3, 4

            SortedDictionary<string, int> sort = new SortedDictionary<string, int>();

            sort.Add("zebra", 5);
            sort.Add("cat", 2);
            sort.Add("dog", 9);
            sort.Add("mouse", 4);
            sort.Add("programmer", 100);

            Console.WriteLine(sort.ContainsKey("dog")); // true
            Console.WriteLine(sort.ContainsKey("ape")); // false

            // Example: see if it contains "programmer",
            // and if so get the value for "programmer"
            int v;
            if (sort.TryGetValue("programmer", out v))
            {
                Console.WriteLine(v);
            }

            // Example: print SortedDictionary in alphabetic order
            foreach (KeyValuePair<string, int> p in sort)
            {
                Console.WriteLine("{0} = {1}", p.Key, p.Value);
            }
        }

        public static void ToDictionaryEx1()
        {
            List<PackageDic> packages = new List<PackageDic> {
                new PackageDic { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
                new PackageDic { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
                new PackageDic { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
                new PackageDic { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Dictionary of Package objects, using TrackingNumber as the key.
            Dictionary<long, PackageDic> dictionary = packages.ToDictionary(p => p.TrackingNumber);

            foreach (KeyValuePair<long, PackageDic> kvp in dictionary)
            {
                Console.WriteLine(
                    "Key {0}: {1}, {2} pounds",
                    kvp.Key,
                    kvp.Value.Company,
                    kvp.Value.Weight);
            }
        }

        /*
         This code produces the following output:

         Key 89453312: Coho Vineyard, 25.2 pounds
         Key 89112755: Lucerne Publishing, 18.7 pounds
         Key 299456122: Wingtip Toys, 6 pounds
         Key 4665518773: Adventure Works, 33.8 pounds
        */

        public void TestSortedDictionaryPerformance()
        {
            var sd = new SortedDictionary<string,string>();
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                sd.Add(Guid.NewGuid().ToString(), DateTime.Now.Ticks.ToString());
            }
            sw.Stop();
            Console.WriteLine("SD={0}", sw.ElapsedMilliseconds.ToString());
        }
        public void TestDictionaryPerformance()
        {
            var list = new Dictionary<string,string>();
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(Guid.NewGuid().ToString(), DateTime.Now.Ticks.ToString());
            }
            var temp = list.OrderBy(p => p.Value);
            sw.Stop();
            Console.WriteLine("D={0}", sw.ElapsedMilliseconds.ToString());
        }
    }
    class PackageDic
    {
        public string Company { get; set; }
        public double Weight { get; set; }
        public long TrackingNumber { get; set; }
    }
}

/*
Add element benchmark: SortedDictionary, Dictionary
5,    0
0,    0
1,    0
22,   2
310,  33
3769, 521

ContainsKey benchmark: SortedDictionary, Dictionary
73,   5
132,  6
188,  8
255,  9
340,  9
419,  10

.NET 3.5:    SortedDictionary = 8,809ms Dictionary = 1,808ms
.NET 4.5.2:  SortedDictionary = 7,002ms Dictionary = 1,836ms
.NET 4.6.1:  SortedDictionary = 6,893ms Dictionary = 1,796ms
.NET 4.7:    SortedDictionary = 6,785ms Dictionary = 1,771ms
.NET Core 2: SortedDictionary = 9,147ms Dictionary = 1,646ms
*/
