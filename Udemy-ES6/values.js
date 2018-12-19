// The values() method returns a new Array Iterator object that contains the values for each index in the array.

const array1 = ['a', 'b', 'c'];
const iterator = array1.values();

for (const value of iterator) {
  console.log(value); // expected output: "a" "b" "c"
}


var a = ['a', 'b', 'c', 'd', 'e']; 
var iterator = a.values();

console.log(iterator.next().value); // a
console.log(iterator.next().value); // b
console.log(iterator.next().value); // c
console.log(iterator.next().value); // d
console.log(iterator.next().value); // e
