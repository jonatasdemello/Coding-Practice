// The map() method create a new array with the results of calling a provided function on every element in the calling array.

// map() Use it when: You want to translate values in an array into another set of values.
// Note: map() does not execute the function for array elements without values.
// Note: map() does not change the original array.

// if you use an anonymous function, you must use return


var array1 = [1, 4, 9, 16];
const map1 = array1.map(x => x * 2);
console.log('m1:', map1); // expected output: Array [2, 8, 18, 32]

// What it does: Map traverses the array from left to right. 
// It invokes a function (in this case, eachAmount * .93) on eachAmount 
// When the method is finished mapping all the elements it returns a new array with all the translated elements.

console.log('------------- map');
const dollars = [32, 45, 50];
const euros = dollars.map(eachAmount => eachAmount * .93);
console.log('euros:', euros); //  [29.76, 41.85, 46.5]


console.log('------------- cars');
var cars = [
  {    model: 'Buick',  price: 'cheap'  },
  {    model: 'Audi',   price: 'expensive'  },
  {    model: 'Ford',   price: 'average'  },
  {    model: 'GM',     price: 'cheap'  }
];

// return a new array with prices => called Plucking
var prices = cars.map(function (c) {
  return c.price;
});
console.log('prices:', prices);


console.log('------------- numbers');
var numbers = [1, 2, 3];
var double = [];
// using for
for (var i = 0; i < numbers.length; i++) {
  double.push(numbers[i] * 2);
}
// using map
var d = double.map(function (n) {
  return n * 2;
});
console.log('numbers:', numbers);
console.log('d-for:', double);
console.log('d-map:', d);


function mapForEach(arr, fn) {
  const newArr = [];
  for (let i = 0; i < arr.length; i++) {
    newArr.push(
      fn(arr[i])
    );
  };
  return newArr;
}

const arr1 = [1, 2, 3]
console.log(arr1);

const arr2 = mapForEach(arr1, (item) => {
  return item * 2
});
console.log(arr2);

