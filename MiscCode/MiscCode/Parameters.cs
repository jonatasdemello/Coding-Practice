using System;
using System.Collections.Generic;
using System.Text;

namespace MiscCode
{
    public static class Parameters
    {
        // Normally, all the objects are passed by reference as parameter to the method.
        // On the other hand most of the primitive data types such as integer, double, Boolean etc. are passed by value.
        public static void ParametersTest()
        {
            Console.WriteLine("Hello World!");
            int y = 5; // initialize y to 5
            int z; // declares z, but does not initialize it

            // display original values of y and z
            Console.WriteLine($"Original value of y: {y}");
            Console.WriteLine("Original value of z: uninitialized\n");

            // pass y and z by reference
            SquareRef(ref y); // must use keyword ref
            SquareOut(out z); // must use keyword out

            // display values of y and z after they're modified by
            // methods SquareRef and SquareOut, respectively
            Console.WriteLine($"Value of y after SquareRef: {y}");
            Console.WriteLine($"Value of z after SquareOut: {z}\n");

            // pass y and z by value
            Square(y);
            // display values of y and z after they're passed to method Square
            // to demonstrate that arguments passed by value are not modified
            Console.WriteLine($"Value of y after Square: {y}\n");

            // pass y and z by value
            Square(z);
            Console.WriteLine($"Value of z after Square: {z}\n");


            Person p1 = new Person { name = "John", age = 20 };
            Console.WriteLine($"before Person: name: {p1.name} age: {p1.age}\n");

            ChangeAge(p1);
            Console.WriteLine($"after ChangeAge: name: {p1.name} age: {p1.age}\n");

            ChangeAgeRef(ref p1);
            Console.WriteLine($"after ChangeAgeRef: name: {p1.name} age: {p1.age}\n");


            // using Class vs Struct
            Console.WriteLine("using Class vs Struct:");

            TheClass testClass = new TheClass();
            TheStruct testStruct = new TheStruct();

            testClass.willIChange = "Not Changed";
            testStruct.willIChange = "Not Changed";

            ClassTaker(testClass);
            StructTaker(testStruct);

            Console.WriteLine("Class field = {0}", testClass.willIChange);
            Console.WriteLine("Struct field = {0}", testStruct.willIChange);


            // using out to return multiple values
            int argNumber;
            string argMessage, argDefault;
            Method(out argNumber, out argMessage, out argDefault);
            Console.WriteLine($"argNumber = {argNumber}, argMessage = {argMessage}, argDefault = {argDefault == null}");

            Console.ReadLine();
        }

        // uses reference parameter x to modify caller's variable
        static void SquareRef(ref int x)
        {
            x = x * x; // squares value of caller's variable
            Console.WriteLine($"Value of x inside SquareRef: {x}");
        }

        // uses output parameter x to assign a value
        // to an uninitialized variable
        static void SquareOut(out int x)
        {
            x = 6; // assigns a value to caller's variable
            x = x * x; // squares value of caller's variable
        }

        // parameter x receives a copy of the value passed as an argument,
        // so this method cannot modify the caller's variable
        static void Square(int x)
        {
            x = x * x;
            Console.WriteLine($"Value of x inside Square: {x}");
        }

        static void ChangeAge(Person p)
        {
            p.age = p.age + 10;
            Console.WriteLine($"Inside ChangeAge: name: {p.name} age: {p.age}\n");
        }

        static void ChangeAgeRef(ref Person p)
        {
            p.age = p.age + 10;
            Console.WriteLine($"Inside ChangeAgeRef: name: {p.name} age: {p.age}\n");
        }

        // using Class vs Struct
        static void ClassTaker(TheClass c)
        {
            c.willIChange = "Changed";
        }

        static void StructTaker(TheStruct s)
        {
            s.willIChange = "Changed";
        }

        // using out to return multiple values
        static void Method(out int answer, out string message, out string stillNull)
        {
            answer = 44;
            message = "I've been returned";
            stillNull = null;
        }
    }
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }

    class TheClass
    {
        public string willIChange;
    }

    struct TheStruct
    {
        public string willIChange;
    }
}