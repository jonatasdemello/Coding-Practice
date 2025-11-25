using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Basics
{
    public class NullableTypes
    {
        public void nullable1()
        {
            double? pi = 3.14;
            char? letter = 'a';

            int m2 = 10;
            int? m = m2;

            bool? flag = null;

            // An array of a nullable type:
            int?[] arr = new int?[10];


            int? a = 42;
            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}");
                Console.WriteLine($"a is {a}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }
            // Output:
            // a is 42

            int? b = 10;
            if (b.HasValue)
            {
                Console.WriteLine($"b is {b.Value}");
            }
            else
            {
                Console.WriteLine("b does not have a value");
            }
            // Output:
            // b is 10

            int? c = 7;
            if (c != null)
            {
                Console.WriteLine($"c is {c.Value}");
            }
            else
            {
                Console.WriteLine("c does not have a value");
            }
            // Output:
            // c is 7

            int? a1 = 28;
            int b1 = a1 ?? -1;
            Console.WriteLine($"b1 is {b1}");  // output: b is 28

            int? c1 = null;
            int d1 = c1 ?? -1;
            Console.WriteLine($"d is {d1}");  // output: d is -1

            // cast
            int? n = null;

            //int m1 = n;    // Doesn't compile
            int n2 = (int)n; // Compiles, but throws an exception if n is null

            // Lifted operators
            int? a2 = 10;
            int? b2 = null;
            int? c2 = 10;

            a2++;        // a is 11
            a2 = a2 * c2;  // a is 110
            a2 = a2 + b2;  // a is null
        }

        public void nullCompare()
        {
            // For the comparison operators <, >, <=, and >=, if one or both operands are null, the result is false;

            int? a = 10;
            Console.WriteLine($"{a} >= null is {a >= null}");
            Console.WriteLine($"{a} < null is {a < null}");
            Console.WriteLine($"{a} == null is {a == null}");
            // Output:
            // 10 >= null is False
            // 10 < null is False
            // 10 == null is False

            int? b = null;
            int? c = null;
            Console.WriteLine($"null >= null is {b >= c}");
            Console.WriteLine($"null == null is {b == c}");
            // Output:
            // null >= null is False
            // null == null is True
        }


        public void nullBoxing()
        {
            // Boxing and unboxing
            // An instance of a nullable value type T? is boxed as follows:
            // If HasValue returns false, the null reference is produced.
            // If HasValue returns true, the corresponding value of the underlying value type T is boxed, not the instance of Nullable<T>.

            int a = 41;
            object aBoxed = a;
            int? aNullable = (int?)aBoxed;
            Console.WriteLine($"Value of aNullable: {aNullable}");

            object aNullableBoxed = aNullable;
            if (aNullableBoxed is int valueOfA)
            {
                Console.WriteLine($"aNullableBoxed is boxed int: {valueOfA}");
            }
            // Output:
            // Value of aNullable: 41
            // aNullableBoxed is boxed int: 41

            Console.WriteLine($"int? is {(IsNullable(typeof(int?)) ? "nullable" : "non nullable")} type");
            Console.WriteLine($"int is {(IsNullable(typeof(int)) ? "nullable" : "non-nullable")} type");

            bool IsNullable(Type type) => Nullable.GetUnderlyingType(type) != null;

       }

        public void nullableIdentify()
        {
            // Output:
            // int? is nullable type
            // int is non-nullable type

            int? a1 = 17;
            Type typeOfA = a1.GetType();
            Console.WriteLine(typeOfA.FullName);
            // Output:
            // System.Int32

            int? a = 14;
            Console.WriteLine(IsOfNullableType(a));  // output: True
            if (a is int)
            {
                Console.WriteLine("int? instance is compatible with int");
            }

            int b = 17;
            Console.WriteLine(IsOfNullableType(b));  // output: False
            if (b is int?)
            {
                Console.WriteLine("int instance is compatible with int?");
            }
            // Output:
            // int? instance is compatible with int
            // int instance is compatible with int?

            bool IsOfNullableType<T>(T o)
            {
                var type = typeof(T);
                return Nullable.GetUnderlyingType(type) != null;
            }
        }

    }
}
