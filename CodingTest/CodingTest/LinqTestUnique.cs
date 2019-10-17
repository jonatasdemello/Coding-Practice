using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTest
{
    public class LinqTest
    {
        public int id { get; set; }
        public string value { get; set; }
    }
    public static class LinqTestUnique
    {
        public static void Solution()
        {
            var input = new List<string>() { "a", "b", "a", "b", "b", "b", "c" };
            List<string> distinct = input.Distinct().ToList();
            Console.WriteLine("Input: " + string.Join(",", input));
            Console.WriteLine("Output: " + string.Join(",", distinct));

            List<LinqTest> myList = new List<LinqTest>();
            myList.Add(new LinqTest() { id = 1, value = "a" });
            myList.Add(new LinqTest() { id = 1, value = "b" });
            myList.Add(new LinqTest() { id = 2, value = "c" });

            var newList = myList.GroupBy(test => test.id).Select(grp => grp.First());
            //Edit: as getting this IEnumerable<> into a List<> seems to be a mystery to many people, 
            // you can simply write:
            var result = myList.GroupBy(test => test.id)
                       .Select(grp => grp.First())
                       .ToList();
            foreach (var item in newList)
            {
                Console.WriteLine("id: {0} value: {1}", item.id, item.value);
            }
        }
    }
}
// But one is often better off working with the IEnumerable rather than 
// IList as the Linq above is lazily evaluated: it doesn't actually do all 
// of the work until the enumerable is iterated. When you call ToList it 
// actually walks the entire enumerable forcing all of the work to be done 
// up front. (And may take a little while if your enumerable is infinitely long.) 

//The flipside to this advice is that each time you enumerate such an 
//IEnumerable the work to evaluate it has to be done afresh. So you need 
//to decide for each case whether it is better to work with the lazily 
//evaluated IEnumerable or to realize it into a List, Set, Dictionary or whatnot. 
