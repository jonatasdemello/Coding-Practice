// The fill() method fills all the elements of an array from a start index to an end index with a static value. The end index is not included.

// Fill all the array elements with a static value:

var fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.fill("Kiwi");

// The fill() method fills the specified elements in an array with a static value.
// You can specify the position of where to start and end the filling. If not specified, all elements will be filled.
// Note: this method overwrites the original array.

// array.fill(value, start, end)

// Parameter	Description
// value	Required. The value to fill the array with
// start	Optional. The index to start filling the array (default is 0)
// end	Optional. The index to stop filling the array (default is array.length)


var array1 = [1, 2, 3, 4];

// fill with 0 from position 2 until position 4
console.log(array1.fill(0, 2, 4)); // expected output: [1, 2, 0, 0]

// fill with 5 from position 1
console.log(array1.fill(5, 1)); // expected output: [1, 5, 5, 5]

console.log(array1.fill(6)); // expected output: [6, 6, 6, 6]

/*
The fill method takes up to three arguments value, start and end. The start and end arguments are optional with default values of 0 and the length of the this object.

If start is negative, it is treated as length+start where length is the length of the array. If end is negative, it is treated as length+end.

fill is intentionally generic, it does not require that its this value be an Array object.

fill is a mutable method, it will change this object itself, and return it, not just return a copy of it.

When fill gets passed an object, it will copy the reference and fill the array with references to that object.
*/

[1, 2, 3].fill(4);               // [4, 4, 4]
[1, 2, 3].fill(4, 1);            // [1, 4, 4]
[1, 2, 3].fill(4, 1, 2);         // [1, 4, 3]
[1, 2, 3].fill(4, 1, 1);         // [1, 2, 3]
[1, 2, 3].fill(4, 3, 3);         // [1, 2, 3]
[1, 2, 3].fill(4, -3, -2);       // [4, 2, 3]
[1, 2, 3].fill(4, NaN, NaN);     // [1, 2, 3]
[1, 2, 3].fill(4, 3, 5);         // [1, 2, 3]
Array(3).fill(4);                // [4, 4, 4]
[].fill.call({ length: 3 }, 4);  // {0: 4, 1: 4, 2: 4, length: 3}

// Objects by reference.
var arr = Array(3).fill({}) // [{}, {}, {}];
arr[0].hi = "hi"; // [{ hi: "hi" }, { hi: "hi" }, { hi: "hi" }]
