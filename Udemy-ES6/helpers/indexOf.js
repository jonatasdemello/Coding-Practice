// The indexOf() method returns the first index at which a given element can be found in the array, or -1 if it is not present.

// indexOf() compares searchElement to elements of the Array using strict equality (the same method used by the === or triple-equals operator).


var beasts = ['ant', 'bison', 'camel', 'duck', 'bison'];

console.log(beasts.indexOf('bison')); // expected output: 1

// start from index 2
console.log(beasts.indexOf('bison', 2)); // expected output: 4

console.log(beasts.indexOf('giraffe')); // expected output: -1

