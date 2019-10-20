using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataStructures
{
    class ListDs
    {
        public void TestArray()
        {

            List<int> intList = new List<int>();
            intList.Add(45);
            intList.Add(34);
            intList.Add(1);
            intList.Add(0);
            intList.Add(100);
            intList.Add(22);
            intList.Add(2);

            int listValue = intList[0];

            Console.WriteLine("Contains(2): " + intList.Contains(2));

            while (intList.Count > 0)
            {
                Console.WriteLine(intList[0]);
            }
            // or
            intList.ForEach(el => Console.WriteLine(el));

            IList<int> intList1 = new List<int>() { 10, 20, 30, 40 };

            IList<Student> studentList = new List<Student>() {
                new Student(){ StudentID=1, StudentName="Bill"},
                new Student(){ StudentID=2, StudentName="Steve"},
                new Student(){ StudentID=3, StudentName="Ram"},
                new Student(){ StudentID=1, StudentName="Moin"}
            };
        }

    }
}
/*
Property Usage
Items           Gets or sets the element at the specified index
Count           Returns the total number of elements exists in the List<T>

Method Usage
Add             Adds an element at the end of a List<T>.
AddRange        Adds elements of the specified collection at the end of a List<T>.
BinarySearch    Search the element and returns an index of the element.
Clear           Removes all the elements from a List<T>.
Contains        Checks whether the speciied element exists or not in a List<T>.
Find            Finds the first element based on the specified predicate function.
Foreach         Iterates through a List<T>.
Insert          Inserts an element at the specified index in a List<T>.
InsertRange     Inserts elements of another collection at the specified index.
Remove          Removes the first occurence of the specified element.
RemoveAt        Removes the element at the specified index.
RemoveRange     Removes all the elements that match with the supplied predicate function.
Sort            Sorts all the elements.
TrimExcess      Sets the capacity to the actual number of elements.
TrueForAll      Determines whether every element in theÂ List<T> matches the conditions defined by the specified predicate.
*/
