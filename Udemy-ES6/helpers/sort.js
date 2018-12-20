// The sort() method sorts the elements of an array in place and returns the array. 
// The default sort order is built upon converting the elements into strings, then comparing their sequences of UTF-16 code units values.

// The time and space complexity of the sort cannot be guaranteed as it is implementation dependent.
// arr.sort([compareFunction])

var months = ['March', 'Jan', 'Feb', 'Dec'];
months.sort();
console.log(months); // expected output: Array ["Dec", "Feb", "Jan", "March"]

var array1 = [1, 30, 4, 21];
array1.sort();
console.log(array1); // expected output: Array [1, 21, 30, 4]

/*
function compare(a, b) {
  if (a is less than b by some ordering criterion) {
    return -1;
  }
  if (a is greater than b by the ordering criterion) {
    return 1;
  }
  // a must be equal to b
  return 0;
}
*/

// To compare numbers instead of strings, the compare function can simply subtract b from a. 
// The following function will sort the array ascending (if it doesn't contain Infinity and NaN):

function compareNumbers(a, b) {
  return a - b;
}

var numbers = [4, 2, 5, 1, 3];
numbers.sort(function(a, b) {
  return a - b;
});
console.log(numbers); // [1, 2, 3, 4, 5]



var items = [
  { name: 'Edward', value: 21 },
  { name: 'Sharpe', value: 37 },
  { name: 'And', value: 45 },
  { name: 'The', value: -12 },
  { name: 'Magnetic', value: 13 },
  { name: 'Zeros', value: 37 }
];

// sort by value
items.sort(function (a, b) {
  return a.value - b.value;
});

// sort by name
items.sort(function(a, b) {
  var nameA = a.name.toUpperCase(); // ignore upper and lowercase
  var nameB = b.name.toUpperCase(); // ignore upper and lowercase
  if (nameA < nameB) {
    return -1;
  }
  if (nameA > nameB) {
    return 1;
  }

  // names must be equal
  return 0;
});


var items = ['réservé', 'premier', 'cliché', 'communiqué', 'café', 'adieu'];
items.sort(function (a, b) {
  return a.localeCompare(b);
});
// items is ['adieu', 'café', 'cliché', 'communiqué', 'premier', 'réservé']
