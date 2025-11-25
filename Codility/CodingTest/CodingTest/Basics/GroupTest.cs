using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.Basics
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public void Write()
        {
            Console.WriteLine("{0}\t\t{1}\t\t{2}", ProductID, Make, Model);
        }
    }
    public static class Extensions
    {
        public static void WriteLine(this IEnumerable<Product> theList)
        {
            foreach (var item in theList)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", item.ProductID, item.Make, item.Model);
            }
        }
        public static void WriteLine<T>(this IEnumerable<T> theList)
        {
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }
        }

        public static void WriteToConsole<T>(this IList<T> collection)
        {
            WriteToConsole<T>(collection, "\t");
        }
        public static void WriteToConsole<T>(this IList<T> collection, string delimiter)
        {
            int count = collection.Count;
            for (int i = 0; i < count; ++i)
            {
                Console.Write("{0}{1}", collection[i].ToString(), delimiter);
            }
            Console.WriteLine();
        }
    }

    public class GroupTest
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductID = 1, Make = "Samsung", Model = "Galaxy S3" });
            products.Add(new Product { ProductID = 2, Make = "Samsung", Model = "Galaxy S4" });
            products.Add(new Product { ProductID = 3, Make = "Samsung", Model = "Galaxy S5" });
            products.Add(new Product { ProductID = 4, Make = "Apple", Model = "iPhone 5" });
            products.Add(new Product { ProductID = 5, Make = "Apple", Model = "iPhone 6" });
            products.Add(new Product { ProductID = 6, Make = "Apple", Model = "iPhone 6" });
            products.Add(new Product { ProductID = 7, Make = "HTC", Model = "Sensation" });
            products.Add(new Product { ProductID = 8, Make = "HTC", Model = "Desire" });
            products.Add(new Product { ProductID = 9, Make = "HTC", Model = "Desire" });
            products.Add(new Product { ProductID = 10, Make = "Nokia", Model = "Lumia 735" });
            products.Add(new Product { ProductID = 11, Make = "Nokia", Model = "Lumia 930" });
            products.Add(new Product { ProductID = 12, Make = "Nokia", Model = "Lumia 930" });
            products.Add(new Product { ProductID = 13, Make = "Sony", Model = "Xperia Z3" });

            return products;
        }
        public void ShowProducts()
        {
            var res1 = GetProducts();
            res1.WriteLine();

            Console.WriteLine(new String('-', 50));

            var res2 = GetProducts().GroupBy(o => new { o.Make, o.Model }).Select(o => o.FirstOrDefault());
            res2.WriteLine();

            Console.WriteLine(new String('-', 50));

            var res3 = GetProducts().Select(o => new { o.Make, o.Model }).Distinct();
            res3.WriteLine();

            Console.WriteLine(new String('-', 50));

            var res4 = GetProducts().Distinct(new ProductComparer());
            res4.WriteLine();

            Console.WriteLine(new String('-', 50));
            
            var res5 = GetProducts().GroupBy(o => o.Make).Select(o => o.FirstOrDefault());
            res5.WriteLine();

            Console.WriteLine(new String('-', 50));
            var res6 = GetProducts().Select(o => new { Make = o.Make }).Distinct();
            res6.WriteLine();
        }
    }
    class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            if (Object.ReferenceEquals(x, y)) 
                return true;

            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.Make == y.Make && x.Model == y.Model;
        }
        public int GetHashCode(Product product)
        {
            if (Object.ReferenceEquals(product, null)) return 0;
            int hashProductName = product.Make == null ? 0 : product.Make.GetHashCode();
            int hashProductCode = product.Model.GetHashCode();
            return hashProductName ^ hashProductCode;
        }
    }

}
