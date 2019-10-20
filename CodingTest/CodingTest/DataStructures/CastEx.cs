using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    class CastEx
    {
        public void TestCastEx()
        {
            ArrayList fruits = new ArrayList();
            fruits.Add("mango");
            fruits.Add("apple");
            fruits.Add("lemon");

            IEnumerable<string> query = fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);

            // The following code, without the cast, doesn't compile.
            //IEnumerable<string> query1 = fruits.OrderBy(fruit => fruit).Select(fruit => fruit);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }

            // This code produces the following output: 
            //
            // apple 
            // lemon
            // mango

            System.Collections.ArrayList fruits2 = new System.Collections.ArrayList(4);
            fruits2.Add("Mango");
            fruits2.Add("Orange");
            fruits2.Add("Apple");
            fruits2.Add(3.0);
            fruits2.Add("Banana");

            // Apply OfType() to the ArrayList.
            IEnumerable<string> query1 = fruits2.OfType<string>();

            Console.WriteLine("Elements of type 'string' are:");
            foreach (string fruit in query1)
            {
                Console.WriteLine(fruit);
            }

            // The following query shows that the standard query operators such as 
            // Where() can be applied to the ArrayList type after calling OfType().
            IEnumerable<string> query2 = fruits2.OfType<string>().Where(fruit => fruit.ToLower().Contains("n"));

            Console.WriteLine("\nThe following strings contain 'n':");
            foreach (string fruit in query2)
            {
                Console.WriteLine(fruit);
            }

            // This code produces the following output:
            //
            // Elements of type 'string' are:
            // Mango
            // Orange
            // Apple
            // Banana
            //
            // The following strings contain 'n':
            // Mango
            // Orange
            // Banana

            IEnumerable sequence = Enumerable.Range(0, 10);
            var doubles = from int item in sequence
                          select (double)item;

            var list = "1,2,3,4,5,6,7,8,9,10";
            var listArr = list.Split(',');
            var listInt = listArr.OfType<Int64>().Select(x => x);
            foreach (var item in listInt)
            {
                Console.WriteLine(item);
            }
        }
    }
}
