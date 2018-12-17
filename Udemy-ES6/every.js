// The every() method tests whether all elements in the array pass the test implemented by the provided function.

function isBelowThreshold(currentValue) {
  return currentValue < 40;
}
var array1 = [1, 30, 39, 29, 10, 13];
console.log(array1.every(isBelowThreshold)); // expected output: true

/*
The every() method checks if all elements in an array pass a test (provided as a function).
The every() method executes the function once for each element present in the array:
    If it finds an array element where the function returns a false value, every() returns false (and does not check the remaining values)
    If no false occur, every() returns true
Note: every() does not execute the function for array elements without values.
Note: every() does not change the original aray

array.every(function(currentValue, index, arr), thisValue)
*/

console.log('------------- every');

var computers = [
  {name: 'Apple', ram: 24},
  {name: 'Compaq', ram: 16},
  {name: 'Acer', ram: 32},
];
var allCanRun = computers.every(function(c){
    return c.ram > 16;
});
console.log('all-can-run:', allCanRun); // expected false


