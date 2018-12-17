// The some() method tests whether at least one element in the array passes the test implemented by the provided function.

var array = [1, 2, 3, 4, 5];
var even = function(element) {
  // checks whether an element is even
  return element % 2 === 0;
};
console.log(array.some(even));// expected output: true


/*
The some() method checks if any of the elements in an array pass a test (provided as a function).
The some() method executes the function once for each element present in the array:
    If it finds an array element where the function returns a true value, some() returns true (and does not check the remaining values)
    Otherwise it returns false
array.some(function(currentValue, index, arr), thisValue)
*/

console.log('------------- some');
var computers = [
  {name: 'Apple', ram: 24},
  {name: 'Compaq', ram: 16},
  {name: 'Acer', ram: 32},
];

var onlySomeCan = computers.some(function (c) {
  return c.ram > 16;
});
console.log('ony-some:', onlySomeCan); // expected true
