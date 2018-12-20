// The Array.from() method creates a new, shallow-copied Array instance from an array-like or iterable object.

console.log(Array.from('foo')); // expected output: Array ["f", "o", "o"]

console.log(Array.from([1, 2, 3], x => x + x)); // expected output: Array [2, 4, 6]

/*
Array.from() lets you create Arrays from:
  array-like objects (objects with a length property and indexed elements) or
  iterable objects (objects where you can get its elements, such as Map and Set).

Array.from() has an optional parameter mapFn, which allows you to execute a map function on each element of the array (or subclass object) 
that is being created. More clearly, 
Array.from(obj, mapFn, thisArg) has the same result as 
Array.from(obj).map(mapFn, thisArg), except that it does not create an intermediate array. 
This is especially important for certain array subclasses, like typed arrays, 
since the intermediate array would necessarily have values truncated to fit into the appropriate type.
*/