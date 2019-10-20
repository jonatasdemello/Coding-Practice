using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class Fibonacci
    {
        // Iterative
        public static ulong Fib(uint x)
        {
            if (x == 0) return 0;

            ulong prev = 0;
            ulong next = 1;
            for (int i = 1; i < x; i++)
            {
                ulong sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }

        public static int Fibonacci1(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }
        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }

        public static int GetNthFibonacci_Ite(int n)
        {
            int number = n - 1; //Need to decrement by 1 since we are starting from 0
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }

        public static int GetNthFibonacci_Rec(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
        }

        // Recursive
        public static ulong Fib0(uint n)
        {
            return (n < 2) ? n : Fib0(n - 1) + Fib0(n - 2);
        }

        // Tail-Recursive
        public static ulong Fib1(uint n)
        {
            return Fib1a(0, 1, n);
        }

        private static ulong Fib1a(ulong a, ulong b, uint n)
        {
            return (n < 1) ? a : (n == 1) ? b : Fib1a(b, a + b, n - 1);
        }

        // Iterative
        public static ulong Fib2(uint x)
        {
            if (x == 0) return 0;

            ulong prev = 0;
            ulong next = 1;
            for (int i = 1; i < x; i++)
            {
                ulong sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }

        // Eager-Generative
        public static IEnumerable<long> Fibs(uint x)
        {
            IList<long> fibs = new List<long>();

            long prev = -1;
            long next = 1;
            for (int i = 0; i < x; i++)
            {
                long sum = prev + next;
                prev = next;
                next = sum;
                fibs.Add(sum);
            }
            return fibs;
        }

        // Lazy-Generative
        public static IEnumerable<long> Fibs1(uint x)
        {
            long prev = -1;
            long next = 1;
            for (uint i = 0; i < x; i++)
            {
                long sum = prev + next;
                prev = next;
                next = sum;
                yield return sum;
            }
        }
    }
}
/*
// O(2^n)
function fibonacci(position){
  if (position < 3) return 1;
  else return (fibonacci(position-1) + fibonacci(position-2));
}
console.log(fibonacci(1));
console.log(fibonacci(2));
console.log(fibonacci(4));
console.log(fibonacci(20));
//console.log(fibonacci(40));

// O(n)
function fibMemo(index, cache) {
  cache = cache || [];
  if (cache[index]) return cache[index];
  else {
    if (index < 3) return 1;
    else {
      cache[index] = fibMemo(index - 1, cache) + fibMemo(index - 2, cache);
    }
  }
  return cache[index];
}
console.log(fibMemo(4));
console.log(fibMemo(20));


// Recursive
function fib(n) {
  return n<2?n:fib(n-1)+fib(n-2);
}
// Can be rewritten as:
function fib(n) {
 if (n<2) { return n; } else { return fib(n-1)+fib(n-2); }
}

// Iterative
function fib(n) {
  var a = 0, b = 1, t;
  while (n-- > 0) {
    t = a;
    a = b;
    b += t;
    console.log(a);
  }
  return a;
}

// Memoization
// With the keys of a dictionary,
var fib = (function(cache){
    return cache = cache || {}, function(n){
        if (cache[n]) return cache[n];
        else return cache[n] = n == 0 ? 0 : n < 0 ? -fib(-n)
            : n <= 2 ? 1 : fib(n-2) + fib(n-1);
    };
})();

// with the indices of an array
(function () {
    'use strict';
    function fib(n) {
        return Array.apply(null, Array(n + 1))
            .map(function (_, i, lst) {
                return lst[i] = (
                    i ? i < 2 ? 1 :
                    lst[i - 2] + lst[i - 1] :
                    0
                );
            })[n];
    }
    return fib(32);
})();
*/
