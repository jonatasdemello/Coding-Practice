using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    class HashSetDs
    {
        public void TestHashSet()
        {
            // A Set data structure is a list with no duplicate values.

            // Although a HashSet is a list of elements, it does not inherit the IList interface. 
            // Instead it just inherits the ICollection interface. 
            // What this means is elements inside a HashSet cannot be accessed through indices, 
            // only through an enumerator (which is an iterator).

            // HashSet's Add method is a boolean function, 
            // which returns true of an element was added and false if it wasn't (because it was not unique).

            // A HashSet has the very important characteristic that it does not allow duplicate values.
            // A HashSet is not a simple array, it is specifically designed to allow fast search times 
            // which dramatically improves the performace of checking whether a new element is a duplicate or not.

            // Hashtable stores key - value pairs of any datatype where the Key must be unique.
            // The Hashtable key cannot be null whereas the value can be null.
            // Hashtable retrieves an item by comparing the hashcode of keys. 
            // So it is slower in performance than Dictionary collection.
            // Hashtable uses the default hashcode provider which is object.GetHashCode().
            // You can also use a custom hashcode provider.
            // Use DictionaryEntry with foreach statement to iterate Hashtable.

            HashSet<int> mySet = new HashSet<int>();
            mySet.Add(3);
            mySet.Add(5);
            mySet.Add(3); // duplicate
            mySet.Add(10);

            List<int> myListFromSet = mySet.ToList<int>();
            int myInt = myListFromSet[2];
            Console.WriteLine(myListFromSet[2]); // 10
            // his is because the HashSet ignored the duplicate addition of the value 3.
        }
    }
}
/*
Benchmarks
Let's compare the performance speed of a C# HashSet vs a C# List.

Each trial consisted of adding integers from 0 to 9,999 to each collection. 
However, mod 25 was applied to each integer.
Mod 25 makes the maximum types of items 25. 
Since 10,000 elements were added, this forced 400 collisions to occur,
giving the data structures a chance to use their searching algorithms. 
Times were measured 3 times after 10,000 trials and averaged out.

Don't pay too much attention to the specific running times of the tests since they are dependent on my hardware, 
but look at how they compare to each other.

HashSet - average time: 2290 milliseconds
List - average time: 5505 milliseconds

Now let's make elements objects instead of primitive types. 
I wrote a quick Person class with three fields: Name, LastName, and ID. 
Since I did not include any specific way to compare objects, all the elements will be added without collisions. 
This time 1,000 Person objects were added to each collection for a single trial. 
The total times of 3 sets of 1,000 trials were averaged out.

HashSet - average time: 201 ms
List - average time: 3000 ms

As you can see, the difference in running times becomes astronomical when using objects, making C# HashSet advantageous.

Conclusion
The C# HashSet class is a powerful data structure. Not only is it very fast and efficient, 
but it comes with a bunch of built-in set functions. It is a welcomed addition to C#.NET.
*/
