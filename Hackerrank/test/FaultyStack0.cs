// C# code​​​​​​‌​​​‌​​‌​‌​‌‌​‌​‌​​‌​‌‌​‌ below
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

class FaultyStack 
{
    private Object[] _elements;
    //private List<Object> _elements;
    
    private int _initialCapacity;
    public int Size { get; private set;} 
	
	internal int ElementArrayLength { get { return _elements.Length; } } // for testing
	//internal int ElementArrayLength { get { return _elements.Count; } } // for testing
	
	public FaultyStack(int initialCapacity) 
    {
		_initialCapacity = initialCapacity;
		_elements = new Object[initialCapacity];
	}

	public void Push(object o) 
    {
		EnsureCapacity();
		_elements[Size++] = o;
	}

	public object Pop() 
    {
		if (Size == 0) 
        {
			throw new InvalidOperationException();
		}
		
		return _elements[--Size];
	}

	private void EnsureCapacity() 
    {
        // every time it needs to grow over the length, a new block of memory had to be obtained
        // I would use a List<T> in order to use .Dispose() to fee memory
		if (_elements.Length == Size) 
        {
			Object[] old = _elements;
			_elements = new Object[2 * Size + 1];
			old.CopyTo(_elements, 0);
	    }
	}
	
}


	int initialSize = 30000;
	int itemsToAdd = 100000;

	FaultyStack stack = new FaultyStack(initialSize);

	Console.WriteLine("Initial Memory Use (approx.): " + (GC.GetTotalMemory(true) / 1024) + " KBytes");
	decimal gcInitialTotalMemory = (GC.GetTotalMemory(true) / 1024);
	Console.WriteLine("Initial Length of internal _elements array: " + stack.ElementArrayLength);
	Console.WriteLine("# of elements in the stack initially: " + stack.Size);
	for (int i = 0; i < itemsToAdd; i++) // fill the stack
		stack.Push("a large, large, large, large, string " + i);
	Console.WriteLine("# of elements in the stack after all the Push() calls: " + stack.Size);
	for (int i = 0; i < itemsToAdd; i++) // empty the stack
		stack.Pop();
	Console.WriteLine("# of elements in the stack after every element was removed: " + stack.Size);
	Console.WriteLine("Final Memory Use (approx.): " + (GC.GetTotalMemory(true) / 1024) + " KBytes");
	decimal gcFinalTotalMemory = (GC.GetTotalMemory(true) / 1024);
	decimal difference = gcFinalTotalMemory - gcInitialTotalMemory;
	Console.WriteLine("Difference (approx.): " + difference + " KBytes");
	decimal newSizeRatio = (gcFinalTotalMemory / gcInitialTotalMemory);
	Console.WriteLine("New Size Ratio: " + Math.Round((newSizeRatio * 100.0M), 2) + "%");
	Console.WriteLine("New Length of internal _elements array: " + stack.ElementArrayLength);

	
	
Initial Memory Use (approx.): 4335 KBytes
Initial Length of internal _elements array: 30000
# of elements in the stack initially: 0
# of elements in the stack after all the Push() calls: 100000
# of elements in the stack after every element was removed: 0
Final Memory Use (approx.): 17572 KBytes
Difference (approx.): 13205 KBytes
New Size Ratio: 402.04%
New Length of internal _elements array: 120003

// GC.GetTotalMemory(true)
