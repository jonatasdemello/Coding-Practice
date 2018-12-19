// The includes() method determines whether an array includes a certain element, returning true or false as appropriate.

var array1 = [1, 2, 3];

console.log(array1.includes(2)); // expected output: true

var pets = ['cat', 'dog', 'bat'];

console.log(pets.includes('cat')); // expected output: true
console.log(pets.includes('at')); // expected output: false



[1, 2, 3].includes(2);     // true
[1, 2, 3].includes(4);     // false
[1, 2, 3].includes(3, 3);  // false
[1, 2, 3].includes(3, -1); // true
[1, 2, NaN].includes(NaN); // true