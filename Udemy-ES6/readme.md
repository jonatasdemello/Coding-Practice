
Source
https://www.udemy.com/javascript-es6-tutorial/

# Array Helper methods

- forEach
- map
- find
- filter
- every
- some 
- reduce

## Description

*every()*

The every() method tests whether all elements in the array pass the test implemented by the provided function.
The every method executes the provided callback function once for each element present in the array until it finds one where callback returns a falsy value. If such an element is found, the every method immediately returns false. Otherwise, if callback returns a truthy value for all elements, every returns true. callback is invoked only for indexes of the array which have assigned values; it is not invoked for indexes which have been deleted or which have never been assigned values.


*some()*

The some() method tests whether at least one element in the array passes the test implemented by the provided function.
some() executes the callback function once for each element present in the array until it finds one where callback returns a truthy value (a value that becomes true when converted to a Boolean). If such an element is found, some() immediately returns true. Otherwise, some() returns false. callback is invoked only for indexes of the array which have assigned values; it is not invoked for indexes which have been deleted or which have never been assigned values.


*find()*

The find() method returns the value of the first element in the array that satisfies the provided testing function. Otherwise undefined is returned.
The find method executes the callback function once for each index of the array until it finds one where callback returns a true value. If such an element is found, find immediately returns the value of that element. Otherwise, find returns undefined. callback is invoked for every index of the array from 0 to length - 1 and is invoked for all indexes, not just those that have been assigned values. This may mean that it's less efficient for sparse arrays than other methods that only visit indexes that have been assigned a value.


*filter()*

The filter() method creates a new array with all elements that pass the test implemented by the provided function.
filter() calls a provided callback function once for each element in an array, and constructs a new array of all the values for which callback returns a value that coerces to true. callback is invoked only for indexes of the array which have assigned values; it is not invoked for indexes which have been deleted or which have never been assigned values. Array elements which do not pass the callback test are simply skipped, and are not included in the new array.


*foreach()*

The forEach() method executes a provided function once for each array element.
forEach() executes the provided callback once for each element present in the array in ascending order. 
It is not invoked for index properties that have been deleted or are uninitialized (i.e. on sparse arrays).


*map()*

The map() method creates a new array with the results of calling a provided function on every element in the calling array.

map calls a provided callback function once for each element in an array, in order, and constructs a new array from the results. callback is invoked only for indexes of the array which have assigned values, including undefined. It is not called for missing elements of the array (that is, indexes that have never been set, which have been deleted or which have never been assigned a value).

Since map builds a new array, using it when you aren't using the returned array is an anti-pattern; use forEach or for-of instead. Signs you shouldn't be using map: A) You're not using the array it returns, and/or B) You're not returning a value from the callback.




# map() vs filter()

map()

The map() method passes each element of the array on which it is invoked to the function you specify, and returns an array containing the values returned by that function.

For example:

a = [1, 2, 3];

b = a.map(function(x) { return x*x; });  // b is [1, 4, 9]
The function you pass to map() is invoked in the same way as a function passed to forEach(). For the map() method, however, the function you pass should return a value.Note that map() returns a new array: it does not modify the array it is invoked on. If that array is sparse, the returned array will be sparse in the same way: it will have the same length and the same missing elements.

filter()

The method returns an array containing a subset of the elements of the array on which it is invoked. The function you pass to it should be predicate: a function that returns true or false. The predicate is invoked just as for forEach() and map(). If the return value is true , or a value that converts to true, then the element passed to the predicate is a member of the subset and is added to the array that will become the return value.

Examples:

a = [5, 4, 3, 2, 1];

smallvalues = a.filter(function(x) { return x < 3 });   // [2, 1]

everyother = a.filter(function(x,i) { return i%2==0 }); // [5, 3, 1]

