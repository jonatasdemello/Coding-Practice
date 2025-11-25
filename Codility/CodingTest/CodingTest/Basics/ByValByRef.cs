using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    public static class ByValByRef
    {
        // Reference types: String, Class, Delegates, All arrays, even if their elements are value types
        // Value types: bool, byte, char, decimal, double,enum, float, int, long, sbyte, short, struct, uint, ulong, ushort

        // struct is a value type!
        // Reference types have null value by default, when they are not initialized.
        // Static members are allocated in high frequency heap area of the memory.
        public static void DoStuff()
        {
            int NotInit;
            // Console.WriteLine(notInit); // Error   CS0165 Use of unassigned local variable 'notInit'

            Console.WriteLine("// test with int //");
            int i = 100;
            Console.WriteLine($"i before ChangeValue: {1}");
            ChangeValue(i);
            Console.WriteLine($"i after ChangeValue: {1}");

            Console.WriteLine();

            Console.WriteLine("// test with object //");
            Student std1 = new Student();
            std1.StudentName = "Bill";
            Console.WriteLine($"std1 before: {std1.StudentName}");
            ChangeReferenceType(std1);
            Console.WriteLine($"std1 before: {std1.StudentName}");

            Console.WriteLine();

            Console.WriteLine("// test with string //");
            string s = "Hello";
            Console.WriteLine($"s before: {s}");
            staticChange(s);
            Console.WriteLine($"s after: {s}");

            Console.WriteLine();

            Console.WriteLine("// test with object & method //");
            var m2 = new ObjString() { message = "hello stranger" };
            Console.WriteLine($"m2 before: {m2.message}");
            m2.changeObjString(m2.message);
            Console.WriteLine($"m2 after: {m2.message}");

            Console.WriteLine();

            Console.WriteLine("// test with object & staticChange //");
            var m3 = new ObjString() { message = "hello missing" };
            Console.WriteLine($"m3 before: {m3.message}");
            Console.WriteLine($"m3.GetHashCode before: {m3.GetHashCode()}");
            staticChange(m3.message);  // at this point static is creating a copy of the object
            Console.WriteLine($"m3 after: {m3.message}");
            Console.WriteLine($"m3.GetHashCode after: {m3.GetHashCode()}");

            Console.WriteLine();

            Console.WriteLine("// test with object & ChangeReferenceType //");
            var m4 = new ObjString() { message = "hello missing" };
            Console.WriteLine($"m4 before: {m4.message}");
            var res = m4.message.StrChange();
            Console.WriteLine($"m4 after: {m4.message}");
            Console.WriteLine($"res: {res}");

            Console.WriteLine();
        }
        static void ChangeValue(int i)
        {
            i = 200;
            Console.WriteLine($"x inside ChangeValue: {i}");
        }
        public static void staticChange(string s)
        {
            Console.WriteLine($"s.GetHashCode inside staticChange: {s.GetHashCode()}");
            s += " World!!";
            Console.WriteLine($"s inside staticChange: {s}");
        }
        static void ChangeReferenceType(Student std1)
        {
            std1.StudentName = "Steve";
        }

    }
    public class ObjString
    {
        public string message;
        public void changeObjString(string s)
        {
            s += " World!!";
            Console.WriteLine($"s inside changeObjString: {s}");
        }
    }
    public class Student
    {
        public int StudentID;
        public string StudentName;
    }
    public static class StrExtensions // Extension Method
    {
        public static string StrChange(this string s)
        {
            return s + " world!";
        }
    }
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
