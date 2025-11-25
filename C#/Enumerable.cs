// # Append
// Creating a list of numbers
List<int> numbers = new List<int> { 1, 2, 3, 4 };

// Trying to append any value of the same type
numbers.Append(5);

// It doesn't work because the original list has not been changed
Console.WriteLine(string.Join(", ", numbers));

// It works now because we are using a changed copy of the original list
Console.WriteLine(string.Join(", ", numbers.Append(5)));

// If you prefer, you can create a new list explicitly
List<int> newNumbers = numbers.Append(5).ToList();

// And then write to the console output
Console.WriteLine(string.Join(", ", newNumbers));

// This code produces the following output:
//
// 1, 2, 3, 4
// 1, 2, 3, 4, 5
// 1, 2, 3, 4, 5

// # Average
List<int> grades = new List<int> { 78, 92, 100, 37, 81 };

double average = grades.Average();

Console.WriteLine("The average grade is {0}.", average);

// This code produces the following output:
//
// The average grade is 77.6.

string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

double average = fruits.Average(s => s.Length);

Console.WriteLine("The average string length is {0}.", average);

// This code produces the following output:
//
// The average string length is 6.5.


string[] numbers = { "10007", "37", "299846234235" };

double average = numbers.Average(num => Convert.ToInt64(num));

Console.WriteLine("The average is {0}.", average);

// This code produces the following output:
//
// The average is 99948748093.


// # Cast 
System.Collections.ArrayList fruits = new System.Collections.ArrayList();
fruits.Add("mango");
fruits.Add("apple");
fruits.Add("lemon");

IEnumerable<string> query = fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);

// The following code, without the cast, doesn't compile.
//IEnumerable<string> query1 = fruits.OrderBy(fruit => fruit).Select(fruit => fruit);

foreach (string fruit in query)
{
    Console.WriteLine(fruit);
}

// This code produces the following output: 
// apple 
// lemon
// mango
