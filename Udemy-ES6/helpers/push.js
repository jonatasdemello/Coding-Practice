// The push() method adds one or more elements to the end of an array and returns the new length of the array.

var animals = ['pigs', 'goats', 'sheep'];

console.log(animals.push('cows')); // expected output: 4

console.log(animals); // expected output: Array ["pigs", "goats", "sheep", "cows"]

animals.push('chickens');

console.log(animals); // expected output: Array ["pigs", "goats", "sheep", "cows", "chickens"]

