using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    class ToLookupEx
    {
        public void ToLookupTest()
        {
            // Lookups, unlike dictionaries, are immutable.  
            // That means that once you create a lookup you cannot add or remove elements from it.

            // The usage of ToLookup() is very similar to that of ToDictionary(), both allow you to specify key selectors, value selectors, and comparers.
            // The main difference is that ToLookup() allows(and expects) the duplicate keys whereas ToDictionary() does not.

            var products = new List<Product>
            {
                new Product { Id = 1, Category = "Electronics", Value = 15.0 },
                new Product { Id = 2, Category = "Groceries", Value = 40.0 },
                new Product { Id = 3, Category = "Garden", Value = 210.3 },
                new Product { Id = 4, Category = "Pets", Value = 2.1 },
                new Product { Id = 5, Category = "Electronics", Value = 19.95 },
                new Product { Id = 6, Category = "Pets", Value = 5.50 },
                new Product { Id = 7, Category = "Electronics", Value = 250.0 },
                new Product { Id = 7, Category = "Pets", Value = 5.50 },
                new Product { Id = 8, Category = "Garden", Value = 13.0 },
                new Product { Id = 9, Category = "Automotive", Value = 10.0 },
                new Product { Id = 10, Category = "Electronics", Value = 250.0 }
            };

            var dict = products
                .GroupBy(p => p.Category)
                .ToDictionary(grp => grp.Key, grp => grp.Sum(p => p.Value));

            foreach (var item in dict)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }


            foreach (var group in products.GroupBy(p => p.Category))
            {
                Console.WriteLine(group.Key);

                foreach (var item in group)
                {
                    Console.WriteLine("\t" + item);
                }
            }
            // group the products -- uses deferred execution!
            var groups = products.GroupBy(p => p.Category);

            // at some time before we iterate, all garden items get removed
            products.RemoveAll(p => p.Category == "Garden");

            // now when we iterate all garden items gone even though
            // we created the grouping before they were removed...
            foreach (var product in groups)
            {
                Console.WriteLine(product.Key);

                foreach (var item in product)
                {
                    Console.WriteLine("\t" + item);
                }
            }
            // can group, then use ToDictionary() on each group
            // using key selector and converting group values to list
            var groups1 = products.GroupBy(p => p.Category)
                .ToDictionary(g => g.Key, g => g.ToList());

            // or 
            var groups2 = new Dictionary<string, List<Product>>();
            foreach (var p in products)
            {
                List<Product> productsByGroup;
                if (!groups2.TryGetValue(p.Category, out productsByGroup))
                {
                    productsByGroup = new List<Product>();
                    groups2.Add(p.Category, productsByGroup);
                }
                productsByGroup.Add(p);
            }
            // create the lookup and presumably store it somewhere
            var productsByCategory = products.ToLookup(p => p.Category);
            var productIdsByCategory = products.ToLookup(p => p.Category, p => p.Id);

            // later, if we want to use it
            foreach (var group in productsByCategory)
            {
                // the key of the lookup is in key property
                Console.WriteLine(group.Key);

                // the list of values is the group itself.
                foreach (var item in group)
                {
                    Console.WriteLine("\t" + item);
                }

                // note, if not found this does not throw, but returns empty enumerable
                //foreach (var item in productsByGroup["Garden"])
                // { ... }

            }
        }

        public sealed class Product
        {
            public int Id { get; set; }
            public string Category { get; set; }
            public double Value { get; set; }

            public override string ToString()
            {
                return string.Format("[{0}: {1} - {2}]", Id, Category, Value);
            }
        }

        class Package
        {
            public string Company { get; set; }
            public double Weight { get; set; }
            public long TrackingNumber { get; set; }
        }

        public static void ToLookupEx1()
        {
            // Create a list of Packages.
            List<Package> packages =
                new List<Package>
                    { new Package { Company = "Coho Vineyard",
                  Weight = 25.2, TrackingNumber = 89453312L },
              new Package { Company = "Lucerne Publishing",
                  Weight = 18.7, TrackingNumber = 89112755L },
              new Package { Company = "Wingtip Toys",
                  Weight = 6.0, TrackingNumber = 299456122L },
              new Package { Company = "Contoso Pharmaceuticals",
                  Weight = 9.3, TrackingNumber = 670053128L },
              new Package { Company = "Wide World Importers",
                  Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Lookup to organize the packages. 
            // Use the first character of Company as the key value.
            // Select Company appended to TrackingNumber 
            // as the element values of the Lookup.
            ILookup<char, string> lookup =
                packages
                .ToLookup(p => Convert.ToChar(p.Company.Substring(0, 1)),
                          p => p.Company + " " + p.TrackingNumber);

            // Iterate through each IGrouping in the Lookup.
            foreach (IGrouping<char, string> packageGroup in lookup)
            {
                // Print the key value of the IGrouping.
                Console.WriteLine(packageGroup.Key);
                // Iterate through each value in the 
                // IGrouping and print its value.
                foreach (string str in packageGroup)
                    Console.WriteLine("    {0}", str);
            }
        }

        /*
         This code produces the following output:

         C
             Coho Vineyard 89453312
             Contoso Pharmaceuticals 670053128
         L
             Lucerne Publishing 89112755
         W
             Wingtip Toys 299456122
             Wide World Importers 4665518773
        */
    }
}
