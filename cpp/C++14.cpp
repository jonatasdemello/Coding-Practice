int myInt = 50;
int myAlt (50); // constructor initialization

std::cout << x << y; // "12"

using namespace std;
cout << x;

// As of C++14 there is a binary notation, which uses “0b” as its prefix. This version
// of the standard also added a digit separator (') which can make it easier to read long
// numbers. The binary number below represents 50 in decimal notation.

int myBin = 0b0011'0010; // binary notation (0b)


// Pointer

int* p; // pointer to an integer
int *q; // alternative syntax

int i = 10;
p = &i; // address of i assigned to p

std::cout << "Address of i: " << p; // ex. 0017FF1C
std::cout << "Value of i: " << *p; // 10

p = &i; // address of i assigned to p
*p = 20; // value of i changed through p

// If a second pointer is created and assigned the value of the first pointer it will then
// get a copy of the first pointer’s memory address.

int* p2 = p; // copy of p (copies address stored in p)

int** r = &p; // pointer to p (assigns address of p)

std::cout << "Address of p: " << r; // ex. 0017FF28 
std::cout << "Address of i: " << *r; // ex. 0017FF1C 
std::cout << "Value of i: " << **r; // 20

int* d = new int; // dynamic allocation
delete d; // release allocated memory

// C++11 introduced the keyword nullptr to distinguish between 0 and a null pointer.
// The advantage of using nullptr is that unlike NULL, it will not implicitly convert to an
// integer type. The literal has its own type, nullptr_t, which can only be implicitly converted to pointer and bool types.

int* p = nullptr; // ok
int i = nullptr; // error
bool b = nullptr; // ok (false)
nullptr_t mynull = nullptr; // ok


// References

int x = 5;
int& r = x; // r is an alias to x
int &s = x; // alternative syntax
r = 10; // assigns value to r/x

int* ptr = &x; // ptr assigned address to x

// With C++11 came a new kind of reference called an rvalue reference. This reference can
// bind and modify temporary objects (rvalues), such as literal values and function return
// values. An rvalue reference is formed by placing two ampersands after the type.

int&& ref = 1 + 2; // rvalue reference

// The rvalue reference extends the lifetime of the temporary object and allows it to be
// used like an ordinary variable.
ref += 3;
cout << ref; // "6"


// Arrays

int myArray[3]; // integer array with 3 elements
int myArray[3] = { 1, 2, 3 };
int myArray[] = { 1, 2, 3 };

std::cout << myArray[0]; // 1

int myArray[2][2] = { { 0, 1 }, { 2, 3 } };
myArray[0][0] = 0;
myArray[0][1] = 1;

int* p = new int[3]; // dynamically allocated array
*(p+1) = 10; // p[1] = 10;

int myArray[2] = { 1, 2 };
myArray[2] = 3; // out of bounds error
int length = sizeof(myArray) / sizeof(int); // 2

int size = 3;
int* p = new int[size]; // dynamically allocated array
delete[] p; // release allocated array


// String

#include <string>
using namespace std;

string h = "Hello";
string w (" World");

string a = h + w; // Hello World
h += w; // Hello World

string b = "Hello" + w; // ok

char *c = "World"; // C-style string
b = (string)c + c; // ok
b = "Hello" + (string)" World"; // ok

// String literals will also be implicitly combined if the plus sign is left out.
b = "Hel" "lo"; // ok


// As of C++11, escape characters can be ignored by adding a “R” before the string
// along with a set of parentheses within the double quotes. 
// This is called a raw string and can be used, for instance, to make file paths more readable.

string escaped = "c:\\Windows\\System32\\cmd.exe";
string raw = R"(c:\Windows\System32\cmd.exe)";

string s = "Hello";
bool b = (s == "Hello"); // true

// Their return type is size_t, which is an unsigned data type used to hold the size of an object
size_t i = s.length(); // 5, length of string
i = s.size(); // 5, same as length()

s.substr(0,2); // "He"

char c = s[0]; // 'H'

wstring s1 = L"Hello";
wchar_t *s2 = L"Hello";

string s3 = u8"UTF-8 string";
u16string s4 = u"UTF-16 string";
u32string s5 = U"UTF-32 string";
string s6 = u8"An asterisk: \u002A";

// Loops

// C++11 introduced a range-based for loop syntax for iterating through arrays and
// other container types. At each iteration the next element in the array is bound to the
// reference variable, and the loop continues until it has gone through the entire array.

int a[3] = {1, 2, 3};
for (int &i : a) {
 cout <<i; // "123"

}

// Functions 

void myFunction(int a); // prototype
int main()
{
 myFunction(0);
}
void myFunction(int a) {}

// The parameter names in the prototype do not need to be included. 
// Only the data types must be specified.
void myFunction(int);


// Pass by Value

// In C++, variables of both primitive and object data types are by default passed by value. 
// This means that only a copy of the value or object is passed to the function. Therefore,
// changing the parameter in any way will not affect the original, and passing a large object
// will be very slow.

#include <iostream>
#include <string>
using namespace std;
void change(int i) { i = 10; }
void change(string s) { s = "Hello World"; }
int main()
{
 int x = 0; // value type change(x); // value is passed
 cout << x; // 0
 string y = ""; // reference type
 change(y); // object copy is passed
 cout << y; // ""
}

// Pass by Reference

// Alternatively, to instead pass a variable by reference you just need to add an ampersand
// before the parameter’s name in the function’s definition. When arguments are passed
// by reference, both primitive and object data types can be changed or replaced and the
// changes will affect the original.

void change(int& i) { i = 10; }
int main()
{
 int x = 0; // value type
 change(x); // reference is passed
 cout << x; // 10
}


// Pass by Address

// As an alternative to passing by reference, arguments may also be passed by address using
// pointers. This passing technique serves the same purpose as passing by reference, but
// uses pointer syntax instead.

void change(int* i) { *i = 10; }
int main()
{
 int x = 0; // value type
 change(&x); // address is passed
 cout << x; // 10
}

// Return by Value, Reference or Address

In addition to passing variables by value, reference or address, a variable may also be
returned in one of these ways. Most commonly, a function returns by value, in which case
a copy of the value is returned to the caller.
int byVal(int i) { return i + 1; }
int main()
{
 int a = 10;
 cout << byVal(a); // 11
}
To return by reference instead, an ampersand is placed after the function’s return
type. The function must then return a variable and may not return an expression or literal,
as can be done when using return by value. The variable returned should never be a local
variable, since the memory to these variables is released when the function ends. Instead,
return by reference is commonly used to return an argument that has also been passed to
the function by reference.
int& byRef(int& i) { return i; }
int main()
{
 int a = 10;
 cout << byRef(a); // 10
}

To return by address the dereference operator is appended to the function’s return
type. This return technique has the same two restrictions as when returning by
reference – the address of a variable must be returned and that returned variable must
not be local to the function.
int* byAdr(int* i) { return i; }
int main()
{
 int a = 10;
 cout << *byAdr(&a); // 10
}

// Auto and Decltype
Two new keywords were introduced in C++11: auto and decltype. Both of these
keywords are used for type deduction during compilation. The auto keyword works as a
placeholder for a type and instructs the compiler to automatically deduce the type of the
variable based on its initializer.

auto i = 5; // int
auto d = 3.14; // double
auto b = false; // bool

Auto translates to the core type of the initializer, which means that any reference and
constant specifiers are dropped.

int& iRef = i;
auto myAuto = iRef; // int

Dropped specifiers can be manually reapplied as needed. The ampersand here
creates a regular (lvalue) reference.
auto& myRef = iRef; // int&
Alternatively, two ampersands can be used. This normally designates an rvalue
reference, but in the case of auto it makes the compiler automatically deduce either an
rvalue or an lvalue reference, based on the given initializer.
int i = 1;
auto&& a = i; // int& (lvalue reference)
auto&& b = 2; // int&& (rvalue reference)

The auto specifier may be used anywhere a variable is declared and initialized. For
instance, the type of the for loop iterator below is set to auto, since the compiler can easily
deduce the type.
#include <vector>
using namespace std;
// ...
vector<int> myVector { 1, 2, 3 };
for (auto& x : myVector) { cout << x; } // "123"
Prior to C++11 there was no range-based for loop or auto specifier. Iterating over a
vector then required a more verbose syntax.
for(vector<int>::size_type i = 0; i != myVector.size(); i++) {
 cout << myVector[i]; // "123"
}

The decltype specifier works similar to auto, except it deduces the exact declared
type of a given expression, including references. This expression is specified in
parentheses.
decltype(3) b = 3; // int&&
In C++14, auto may be used as the expression for decltype. The keyword auto is then
replaced with the initializing expression, allowing the exact type of the initializer to be
deduced.
decltype(auto) = 3; // int&&
Using auto is often the simpler choice when an initializer is available. Decltype is
mainly used to forward function return types, without having to consider whether it is a
reference or value type.
decltype(5) getFive() { return 5; } // int

C++11 added a trailing return type syntax, which allows a function’s return value to
be specified after the parameter list, following the arrow operator (->). This enables the
parameter to be used when deducing the return type with decltype. The use of auto in
this context in C++11 just means that trailing return type syntax is being used.
auto getValue(int x) -> decltype(x) { return x; } // int
The ability to use auto for return type deduction was added in C++14. This enabled
the core return type to be deduced directly from the return statement,
auto getValue(int x) { return x; } // int
Moreover, auto can be used together with decltype to deduce the exact type
following the rules of decltype.
decltype(auto) getRef(int& x) { return x; } // int&
The main use for type deduction is to reduce the verbosity of the code and improve
readability, particularly when declaring complicated types where the type is either
difficult to know or difficult to write. Keep in mind that in modern IDEs you can hover
over a variable to check its type, even if the type has been automatically deduced.


// Lambda Functions
C++11 adds the ability to create lambda functions, which are unnamed function objects.
This provides a compact way to define functions at their point of use, without having to
create a named function somewhere else. The following example creates a lambda that
accepts two int arguments and returns their sum.
auto sum = [](int x, int y) -> int
{
 return x + y;
};
cout << sum(2, 3); // "5"
Including the return type is optional if the compiler can deduce the return value
from the lambda. In C++11 this required the lambda to contain just a single return
statement, whereas C++14 extended return type deduction to any lambda function. Note
that the arrow operator (->) is also omitted when leaving out the return type.
auto sum = [](int x, int y) { return x + y; };
C++11 requires lambda parameters to be declared with concrete types. This
requirement was relaxed in C++14, allowing lambdas to use auto type deduction.
auto sum = [](auto x, auto y) { return x + y; };

pg 40
