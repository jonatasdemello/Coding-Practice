/// C# program that computes Fibonacci iteratively

using System;
// Iterative
public static ulong Fib(uint x) {
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

public static int Fibonacci(int n)
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

public static voidFibonacci_Iterative(int len)
{
    int a = 0, b = 1, c = 0;
    Console.Write("{0} {1}", a,b);
    for (int i = 2; i < len; i++)
    {
        c = a + b;
        Console.Write(" {0}", c);
        a = b;
        b = c;
    }
}

public static voidFibonacci_Recursive(int len)
{
   Fibonacci_Rec_Temp(0, 1, 1, len);
}
private static voidFibonacci_Rec_Temp(int a, int b, int counter, int len)
{
    if (counter <= len)
    {
        Console.Write("{0} ", a);
        Fibonacci_Rec_Temp(b, a + b, counter+1, len);
    }
}

public static int GetNthFibonacci_Ite(int n)
{
    int number = n - 1; //Need to decrement by 1 since we are starting from 0
    int[] Fib = new int[number + 1];
    Fib[0]= 0;
    Fib[1]= 1;
    for (int i = 2; i <= number;i++)
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
        returnGetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
}

// Recursive
public static ulong Fib(uint n) {
    return (n < 2)? n : Fib(n - 1) + Fib(n - 2);
}

// Tail-Recursive
public static ulong Fib(uint n) {
    return Fib(0, 1, n);
}

private static ulong Fib(ulong a, ulong b, uint n) {
    return (n < 1)? a :(n == 1)?  b : Fib(b, a + b, n - 1);
}

// Iterative
public static ulong Fib(uint x) {
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
public static IEnumerable<long> Fibs(uint x) {
    IList<ulong> fibs = new List<ulong>();

    ulong prev = -1;
    ulong next = 1;
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
public static IEnumerable<ulong> Fibs(uint x) {
    ulong prev = -1;
    ulong next = 1;
    for (uint i = 0; i < x; i++) {
        ulong sum = prev + next;
        prev = next;
        next = sum;
        yield return sum;
    }
}

