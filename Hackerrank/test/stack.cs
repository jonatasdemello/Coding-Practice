/*
2. Question #2
Create your own implementation (class or set of functions) of a stack. Include the following four methods:

Push: Adds a data element to the top of the stack
Pop: Removes a data element from the top of the stack
Size: Returns the total number of elements in the stack
isEmpty: Returns true if the stack is empty.
 
Please write production-ready code (including comments).
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        /* Use your class here */
		Stack myStack = new Stack();

        Console.WriteLine(myStack.isEmpty());
        Console.WriteLine(myStack.Size());

        myStack.Push(10);
        Console.WriteLine(myStack.Size());
        Console.WriteLine(myStack.isEmpty());
        
        var res = myStack.Pop();
        Console.WriteLine(Convert.ToInt32(res));
        Console.WriteLine(myStack.Size());
        
        myStack.Push(10);
        myStack.Push(20);
        Console.WriteLine(myStack.Size());
           
        var res1 = myStack.Pop();
        Console.WriteLine(myStack.Size());
        Console.WriteLine(Convert.ToInt32(res1));
    }
}
}

/* Define your class here */


    public interface IStack
    {
        void Push(object element);
        object Pop();
        int Size();
        bool isEmpty();
    }

    public class Stack : IStack
    {
        protected List<object> _stack {get; set;}

        public void Push(object element)
        {
            _stack.Add(element);
        }
        public object Pop()
        {
            var result = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return result;
        }
        public int Size()
        {
            return _stack.Count;
        }
        public bool isEmpty()
        {
            return _stack.Count > 0;
        }
    }