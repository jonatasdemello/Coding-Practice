using System;
using System.Collections.Generic;
using System.Text;

namespace MiscCode
{
    public class MyClass
    {
        private string myField = string.Empty; // Field is a class level variable (generally private) that can holds a value

        public MyClass() { } // constructor

        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("First Parameter {0}, second parameter {1}", parameter1, parameter2);
        }

        // Properties expose fields. 
        // Fields should (almost always) be kept private to a class and accessed via get and set properties.
        // Properties provide a level of abstraction allowing you to change the fields while not affecting 
        // the external way they are accessed by the things that use your class

        public int MyAutoImplementedProperty { get; set; } // auto-implemented property

        private int _myPropertyVar; // property

        public int MyProperty // property - encapsulates a private field using get & set
        {
            get { return _myPropertyVar; }
            set { _myPropertyVar = value; }
        }
    }
}
