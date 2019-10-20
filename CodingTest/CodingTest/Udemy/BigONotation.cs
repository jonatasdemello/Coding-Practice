using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class BigONotation
    {
        // O(1)
        // describes an algorithm that will always execute in the same time(or space) regardless of the size of the input data set.
        bool IsFirstElementNull(IList<string> elements)
        {
            return elements[0] == null;
        }

        // O(N) 
        // describes an algorithm whose performance will grow linearly and in direct proportion to the size of the input data set.
        // The example below also demonstrates how Big O favours the worst-case performance scenario; 
        // a matching string could be found during any iteration of the for loop and the function would return early, 
        // but Big O notation will always assume the upper limit where the algorithm will perform the maximum number of iterations.
        bool ContainsValue(IList<string> elements, string value)
        {
            foreach (var element in elements)
            {
                if (element == value)
                    return true;
            }
            return false;
        }

        // O(N^2) 
        // represents an algorithm whose performance is directly proportional to the square of the size of the input data set.
        // This is common with algorithms that involve nested iterations over the data set. 
        // Deeper nested iterations will result in O(N^3), O(N^4) etc.
        bool ContainsDuplicates(IList<string> elements)
        {
            for (var outer = 0; outer < elements.Count; outer++)
            {
                for (var inner = 0; inner < elements.Count; inner++)
                {
                    // Don't compare with self
                    if (outer == inner) continue;
                    if (elements[outer] == elements[inner]) return true;
                }
            }
            return false;
        }

        // O(2^N) 
        // denotes an algorithm whose growth doubles with each additon to the input data set.
        // The growth curve of an O(2^N) function is exponential - starting off very shallow, then rising meteorically. 
        // An example of an O(2^N) function is the recursive calculation of Fibonacci numbers:
        int Fibonacci(int number)
        {
            if (number <= 1) return number;
            return Fibonacci(number - 2) + Fibonacci(number - 1); // every iteration, recalculates again
        }

    }
}
/*
Logarithms
Logarithms are slightly trickier to explain so I'll use a common example:

Binary search is a technique used to search sorted data sets. 
It works by selecting the middle element of the data set, essentially the median, 
and compares it against a target value. If the values match it will return success. 
If the target value is higher than the value of the probe element it will take 
the upper half of the data set and perform the same operation against it. 
Likewise, if the target value is lower than the value of the probe element it will perform 
the operation against the lower half. It will continue to halve the data set with each 
iteration until the value has been found or until it can no longer split the data set. 

This type of algorithm is described as O(log N). 
The iterative halving of data sets described in the binary search example produces a growth 
curve that peaks at the beginning and slowly flattens out as the size of the data sets increase e.g. 
an input data set containing 10 items takes 
one second to complete, a data set containing 100 items takes two seconds, 
and a data set containing 1000 items will take three seconds. 
Doubling the size of the input data set has little effect on its growth as after 
a single iteration of the algorithm the data set will be halved 
and therefore on a par with an input data set half the size. 
This makes algorithms like binary search extremely efficient when dealing with large data sets. 


O(log N) is log base 2 as well. This is an important distinction.

Regarding O notation there is no distinction between O(log N), O(ln N) or logarithms of any base. 

This is because O notation is saying, asymptotically, that the algorithm has a time complexity limited by the log function. 
A logarithm of any base b is a real multiple of any generic logarithm: 
log_b N = log N / log b. 
These are equivalent in O notation because of its definition: 
“if g(x) is O(f(x)) there exists some real constant M such that g(x) <= M f(x)” 
obviously if we multiply by 1/log b, there is another real constant N = M / log b that satisfies this definition. 


X        | constant| logarithmic| linear      |             | quadratic   | cubic
n        | O(1)    | O(log N)   | O(N)        | O(N log N)  | O(N^2)      | O(N^3)
---------|---------|------------|-------------|-------------|-------------|---------------
1        | 1       | 1          | 1           | 1           | 1           | 1
2        | 1       | 1          | 2           | 2           | 4           | 8
4        | 1       | 2          | 4           | 8           | 16          | 64
8        | 1       | 3          | 8           | 24          | 64          | 512
16       | 1       | 4          | 16          | 64          | 256         | 4,096
1,024    | 1       | 10         | 1,024       | 10,240      | 1,048,576   | 1,073,741,824
1,048,576| 1       | 20         | 1,048,576   | 20,971,520  | 10^12       | 10^16


// Big O Notation

log([1,2,3,4]);

// O(1) => constant
function log(array, pos){
	console.log(array[pos]);
}

// O(n) => linear
function logAll(array){
	for(var i=0; i<array.length; i++){
		console.log(array[i]);
	}
}

// O(n^2) => exponential
function addAndLog(array){
	for(var i=0; i<array.length; i++){
		for(var j=0; j<array.length; j++){
			console.log(array[i] + array[j]);
		}
	}
}
addAndLog(['a','b']); // 4
addAndLog(['a','b','c']); // 9
addAndLog(['a','b','c','d']); // 16
addAndLog(['a','b','c','d','e']); // 25

// O(log n) => logarithmic
function binarySarch(array, key){ // array must be sorted 
	var low = 0;
	var high = array.length - 1;
	var mid;
	var elem;
	
	while(low <= high){
		mid = Math.floor((low + high)/2, 10);
		elem = array[mid];
		if(elem < key){
			low = mid + 1;
		} else if (elem > key){
			high = mid - 1;
		} else {
			return mid;
		}
	}
	return -1; // not found
}

// O(2^n)
function fibonacci(position){
  if (position < 3)
    return 1;
  else 
    return (fibonacci(position-1) + fibonacci(position-2));
}

*/
