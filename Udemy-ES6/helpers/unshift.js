// The unshift() method adds one or more elements to the beginning of an array and returns the new length of the array.

var array1 = [1, 2, 3];

console.log(array1.unshift(4, 5)); // expected output: 5
console.log(array1); // expected output: Array [4, 5, 1, 2, 3]


var arr = [1, 2];

arr.unshift(0); // result of call is 3, the new array length
// arr is [0, 1, 2]

arr.unshift(-2, -1); // = 5
// arr is [-2, -1, 0, 1, 2]

arr.unshift([-3]);
// arr is [[-3], -2, -1, 0, 1, 2]
