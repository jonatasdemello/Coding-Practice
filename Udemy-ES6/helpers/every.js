// The every() method tests whether all elements in the array pass the test implemented by the provided function.

// must use return

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

// or
// computers.every(c => c.ram > 16); // false


// The every() method checks if all elements in an array pass a test (provided as a function).
// The every() method executes the function once for each element present in the array:

// If it finds an array element where the function returns a false value, 
//    every() returns false (and does not check the remaining values)
// If no false occur, every() returns true
// Note: every() does not execute the function for array elements without values.
// Note: every() does not change the original array

// array.every(function(currentValue, index, arr), thisValue)

// Argument	Description
// currentValue	Required. The value of the current element
// index	Optional. The array index of the current element
// arr	Optional. The array object the current element belongs to
// thisValue	Optional. A value to be passed to the function to be used as its "this" value.
// If this parameter is empty, the value "undefined" will be passed as its "this" value

var ages = [32, 33, 16, 40];

function checkAdult(age) {
  return age >= 18;
}
console.log(ages.every(checkAdult));

console.log(ages.every(function check(age) { return age >= 10; }));

console.log(ages.every((age) => age >= 18));
console.log(ages.every(age => age >= 18));

// Check if all the answer values in the array are the same:


var survey = [
  { name: "Steve", answer: "Yes"},
  { name: "Jessica", answer: "Yes"},
  { name: "Peter", answer: "Yes"},
  { name: "Elaine", answer: "No"}
];

function isSameAnswer(el, index, arr) {
  if (index === 0){
    return true;
  } else {
    return (el.answer === arr[index - 1].answer);
  }
}

function myFunction() {
  document.getElementById("demo").innerHTML = survey.every(isSameAnswer);
}
