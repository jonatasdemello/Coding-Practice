using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataStructures
{
    class ArrayDs
    {
        public void TestArray()
        {
            //[object type][] myArray = new [object type][number of elements]

            // Declare a single-dimensional array. 
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };


            int[] myIntArray1 = new int[5];
            int[] myIntArray2 = { 0, 1, 2, 3, 4 };

            for (int i = 0; i < myIntArray1.Length; i++)
            {
                Console.WriteLine(myIntArray2[i]);
            }

            Console.WriteLine("\n Reverse:");
            myIntArray2.Reverse();
            for (int i = 0; i < myIntArray2.Length; i++)
            {
                Console.WriteLine(myIntArray2[i]);
            }

            Console.WriteLine("\n Sort:");
            for (int i = 0; i < myIntArray2.Length; i++)
            {
                Console.WriteLine(myIntArray2[i]);
            }

            int res = Array.BinarySearch(myIntArray2, 2);
            if (res < 0)
            {
                Console.WriteLine("\nThe element to search for ({0}) is not found.", 2);
            }
            else
            {
                Console.WriteLine("The element to search for ({0}) is at index {1}.", 2, res);
            }
        }

        static void Display(int[] arr1)
        {
            foreach (int i in arr1)
                Console.Write(i + " ");
        }

        public void TestToArrayEx()
        {
            List<Package> packages = new List<Package> {
                new Package { Company = "Coho Vineyard", Weight = 25.2 },
                new Package { Company = "Lucerne Publishing", Weight = 18.7 },
                new Package { Company = "Wingtip Toys", Weight = 6.0 },
                new Package { Company = "Adventure Works", Weight = 33.8 } };

            string[] companies = packages.Select(pkg => pkg.Company).ToArray();

            foreach (string company in companies)
            {
                Console.WriteLine(company);
            }
        }

        /*
         This code produces the following output:
         Coho Vineyard
         Lucerne Publishing
         Wingtip Toys
         Adventure Works
        */
    }
    class Package
    {
        public string Company { get; set; }
        public double Weight { get; set; }
    }
}
