// The entries() method returns a new Array Iterator object that contains the key/value pairs for each index in the array.

// Create an Array Iterator object, and create a loop that iterates each key/value pair:

var fruits = ["Banana", "Orange", "Apple", "Mango"];
var f = fruits.entries();

for (x of f) {
  console.log(x);
}

// The entries() method returns an Array Iterator object with key/value pairs.
// For each item in the original array, the new iteration object will contain an array with the index as the key, and the item value as the value:

// [0, "Banana"]
// [1, "Orange"]
// [2, "Apple"]
// [3, "Mango"]

// Note: this method does not change the original array.



var array1 = ['a', 'b', 'c'];

var iterator1 = array1.entries();

console.log(iterator1.next().value); // expected output: Array [0, "a"]

console.log(iterator1.next().value); // expected output: Array [1, "b"]

var a = ['a', 'b', 'c'];
var iterator = a.entries();

for (let e of iterator) {
  console.log(e);
}
// [0, 'a']
// [1, 'b']
// [2, 'c']

