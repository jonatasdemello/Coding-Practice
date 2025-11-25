using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Basics
{
    public class DynamicType
    {
        // The dynamic type indicates that use of the variable and references to its members bypass compile-time type checking. Instead, these operations are resolved at run time. 
        // The dynamic type simplifies access to COM APIs such as the Office Automation APIs, to dynamic APIs such as IronPython libraries, and to the HTML Document Object Model (DOM).
        // The dynamic type differs from object in that operations that contain expressions of type dynamic are not resolved or type checked by the compiler. 
        // The compiler packages together information about the operation, and that information is later used to evaluate the operation at run time. 
        // As part of the process, variables of type dynamic are compiled into variables of type object. 
        // Therefore, type dynamic exists only at compile time, not at run time.


        public void DynamicTest1()
        {
            dynamic dyn = 1;
            object obj = 1;

            // Rest the mouse pointer over dyn and obj to see their
            // types at compile time.
            System.Console.WriteLine(dyn.GetType());
            System.Console.WriteLine(obj.GetType());
            // output 
            // System.Int32
            // System.Int32

            // A compiler error is reported for the attempted addition of an integer and an object in expression obj + 3.
            // However, no error is reported for dyn + 3.
            // The expression that contains dyn is not checked at compile time because the type of dyn is dynamic.
            dyn = dyn + 3; 
            // obj = obj + 3; //  Error CS0019  Operator '+' cannot be applied to operands of type 'object' and 'int' 
        }


        public void DynamicTest2()
        {
            ExampleClass ec = new ExampleClass();

            Console.WriteLine(ec.exampleMethod(10));
            Console.WriteLine(ec.exampleMethod("value"));

            // The following line causes a compiler error because exampleMethod takes only one argument.
            //Console.WriteLine(ec.exampleMethod(10, 4));

            dynamic dynamic_ec = new ExampleClass();
            Console.WriteLine(dynamic_ec.exampleMethod(10));

            // Because dynamic_ec is dynamic, the following call to exampleMethod
            // with two arguments does not produce an error at compile time.
            // However, it does cause a run-time error. 

            //Console.WriteLine(dynamic_ec.exampleMethod(10, 4));
        }


    }
    class ExampleClass
    {
        static dynamic field;
        dynamic prop { get; set; }

        public dynamic exampleMethod(dynamic d)
        {
            dynamic local = "Local variable";
            int two = 2;

            if (d is int)
            {
                return local;
            }
            else
            {
                return two;
            }
        }
    }
}
