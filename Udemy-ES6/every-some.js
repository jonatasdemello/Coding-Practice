
var computers = [
    {name: 'Apple', ram: 24},
    {name: 'Compaq', ram: 16},
    {name: 'Acer', ram: 32},
];

var allCanRun = true;
var onlySomeCan = false;

/*
The every() method checks if all elements in an array pass a test (provided as a function).
The every() method executes the function once for each element present in the array:
    If it finds an array element where the function returns a false value, every() returns false (and does not check the remaining values)
    If no false occur, every() returns true
Note: every() does not execute the function for array elements without values.
Note: every() does not change the original aray

array.every(function(currentValue, index, arr), thisValue)
*/
var res = computers.every(function(c){
    return c.ram > 16;
});

console.log(res);

/*
The some() method checks if any of the elements in an array pass a test (provided as a function).
The some() method executes the function once for each element present in the array:
    If it finds an array element where the function returns a true value, some() returns true (and does not check the remaining values)
    Otherwise it returns false
Note: some() does not execute the function for array elements without values.
Note: some() does not change the original array.

array.some(function(currentValue, index, arr), thisValue)
*/

res = computers.some(function (c) {
    return c.ram > 16;
});

console.log(res);
