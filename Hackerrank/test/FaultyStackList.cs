using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FaultyStackList
    {
        //private Object[] _elements;
        private List<Object> _elements;

        private int _initialCapacity;
        public int Size { get; private set; }
        internal int ElementArrayLength { get { return _elements.Count; } }  // for testing

        public FaultyStackList(int initialCapacity)
        {
            _initialCapacity = initialCapacity;
            _elements = new List<Object>(initialCapacity);
            Size = 0;
        }

        public void Push(object o)
        {
            EnsureCapacity();
            //_elements[Size++] = o;
            Size++;
            _elements.Add(o);
        }

        public object Pop()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException();
            }
            //return _elements[--Size];
            var elem = _elements[_elements.Count-1];
            _elements.RemoveAt(_elements.Count - 1);
            Size--;

            return elem;
        }

        private void EnsureCapacity()
        {
            // every time it needs to grow over the length, a new block of memory had to be obtained
            // I would use a List<T> in order to use .Dispose() to fee memory
            if (_elements.Count == _elements.Capacity)
            {
                Console.WriteLine("\t Capacity reached... count: "+ _elements.Count + " capacity: " + _elements.Capacity);
                //Object[] old = _elements;
                //_elements = new Object[2 * Size + 1];
                //old.CopyTo(_elements, 0);
            }
        }


    }
    public static class TestFaultyStackList
    {
        public static void TestStack(int itemsToAdd, FaultyStackList stack)
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine((GC.GetTotalMemory(true) / 1024) + " KBytes\t" + "Initial Memory Use (approx.):");
            decimal gcInitialTotalMemory = (GC.GetTotalMemory(true) / 1024);
            Console.WriteLine(stack.ElementArrayLength + "\t\t" + "Initial Length of internal _elements array: ");
            Console.WriteLine(stack.Size + "\t\t" + "# of elements in the stack initially:");

            for (int i = 0; i < itemsToAdd; i++) // fill the stack
                stack.Push("a large, large, large, large, string " + i);

            Console.WriteLine(stack.Size + "\t\t" + "# of elements in the stack after all the Push() calls:");

            for (int i = 0; i < itemsToAdd; i++) // empty the stack
                stack.Pop();

            Console.WriteLine(stack.Size + "\t\t" + "# of elements in the stack after every element was removed:");
            Console.WriteLine((GC.GetTotalMemory(true) / 1024) + " KBytes \t" + "Final Memory Use (approx.):");
            decimal gcFinalTotalMemory = (GC.GetTotalMemory(true) / 1024);
            decimal difference = gcFinalTotalMemory - gcInitialTotalMemory;
            Console.WriteLine(difference + " KBytes \t" + "Difference (approx.):");
            decimal newSizeRatio = (gcFinalTotalMemory / gcInitialTotalMemory);
            Console.WriteLine(Math.Round((newSizeRatio * 100.0M), 2) + "% \t" + "New Size Ratio:");
            Console.WriteLine(stack.ElementArrayLength + "\t\t" + "New Length of internal _elements array:");
        }
    }
}
