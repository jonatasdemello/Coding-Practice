// The reduce() method executes a reducer function (that you provide) on each member of the array resulting in a single output value.

// The reduce() method reduces the array to a single value.
// The reduce() method executes a provided function for each value of the array (from left-to-right).
// The return value of the function is stored in an accumulator (result/total).
// Note: reduce() does not execute the function for array elements without values.
// reduce() Use it when: You want a total based on values in an array.

const array1 = [1, 2, 3, 4];
const reducer = (accumulator, curentValue) => accumulator + curentValue;
// 1 + 2 + 3 + 4
console.log(array1.reduce(reducer)); // expected output: 10

// 5 + 1 + 2 + 3 + 4
console.log(array1.reduce(reducer, 5)); // expected output: 15
//arr.reduce(callback[, initialValue])

/*
reduce() executes the callback function once for each element present in the array, 
excluding holes in the array, receiving four arguments: 
  accumulator (acc)
  curentValue (cur)
  curentIndex (idx)
  source array (src)

[0, 1, 2, 3, 4].reduce(function(accumulator, curentValue, curentIndex, array) {
  return accumulator + curentValue;
}[, initialValue]);

The first time the callback is called, accumulator and curentValue can be one of two values. 
If initialValue is provided in the call to reduce(), then accumulator will be equal to initialValue, 
and curentValue will be equal to the first value in the array. 
If no initialValue is provided, then accumulator will be equal to the first value in the array, 
and curentValue will be equal to the second.

Note: If initialValue isn't provided, reduce() will execute the callback function starting at index 1, 
skipping the first index. If initialValue is provided, it will start at index 0.

If the array is empty and no initialValue is provided, TypeError will be thrown. 
If the array has only one element (regardless of position) and no initialValue is provided, 
or if initialValue is provided but the array is empty, the solo value will be returned without calling callback.

It is usually safer to provide an initial value because there are three possible outputs without initialValue, 
as shown in the following example.
*/

const euros = [29.76, 41.85, 46.5]; 
let sum0 = 0;

console.log('------------- for');
for (let i = 0; i < euros.length; i++) {
  sum0 += euros[i];
}
console.log(sum0); // 118.11

console.log('------------- reduce');
let sum1 = euros.reduce( function(total, amount){
  return total + amount;
});
console.log(sum1); // 118.11

//or using fat arrow function
console.log('------------- arrow');
let sum2 = euros.reduce( (total, amount) => total + amount); 
console.log(sum2); // 118.11

console.log('------------- average');
const average = euros.reduce( (total, amount, index, array) => {
  total += amount;
  if( index === array.length-1 ) { 
    return total/array.length;
  } else { 
    return total;
  }
});
console.log(average); // 39.37

// not right...
/*
  console.log('------------- average1');
  const average1 = euros.reduce( (total, amount, index, array) => {
    console.log(total, amount, index, array);
    total += amount;
    return total/array.length;
  }, 0);
  console.log(average1); // 39.37
  // By omitting the initial value, the total will default to the first amount in the array.
*/

console.log('------------- double');
// By setting the initial value to an empty array we can then push each amount into the total.
const doubled = euros.reduce((total, amount) => {
  total.push(amount * 2);
  return total;
}, []);
console.log(doubled); // [59.52, 83.7, 93]


console.log('------------- above-30');
const above30 = euros.reduce((total, amount) => {
  if (amount > 30) {
    total.push(amount);
  }
  return total;
}, []);
console.log(above30); // [ 41.85, 46.5 ]


console.log('------------- round-sum');
var numbers = [15.5, 2.3, 1.1, 4.7];
var res = numbers.reduce(function getSum(total, num) {
    return total + Math.round(num);
}, 0);
console.log(res); //24


console.log('------------- colors');
var pColors = [
  {color: 'red'},
  {color: 'green'},
  {color: 'blue'},
];
var c = pColors.reduce(function(prev, item){
  prev.push(item.color);
  return prev;
}, []);
console.log(c); // ["red", "green", "blue"]


console.log('------------- unique');
// using reduce to get a list of unique numbers:
var numbersDuplicate = [1,1,2,3,4,4]; // expected return [1,2,3,4]
function unique(array) {
    return array.reduce(function(acc, cur) {
        if (acc.indexOf(cur) === -1) {
            acc.push(cur);
        }
        return acc;
    }, []);
}
console.log(unique(numbersDuplicate)); // return [1,2,3,4]


console.log('------------- distance');
// Using Reduce with Objects:
var trips = [
  { distance: 34 },
  { distance: 12 },
  { distance: 1 }
];
var totalDistance = trips.reduce(function(acc, cur) {
    return acc + cur.distance;
}, 0);
console.log(totalDistance);


console.log('------------- count-type');
var desks = [
    { type: 'sitting' },
    { type: 'standing' },
    { type: 'sitting' },
    { type: 'sitting' },
    { type: 'standing' }
];
var deskTypes = desks.reduce(function(acc, cur) {
    ++acc[cur.type];
    return acc;
}, { sitting: 0, standing: 0 });
console.log(deskTypes); //{sitting: 3, standing: 2}


console.log('------------- count-items');
const fruitBasket = ['banana', 'cherry', 'orange', 'apple', 'cherry', 'orange', 'apple', 'banana', 'cherry', 'orange', 'fig' ];
const count = fruitBasket.reduce( (acc, fruit) => {
  acc[fruit] = (acc[fruit] || 0) + 1 ;
  return acc;
} , {})
console.log(count); // { banana: 2, cherry: 3, orange: 3, apple: 2, fig: 1 }
//or
let fb1 = fruitBasket.reduce( (acc, fruit) => {
    acc[fruit] = 1;
    return acc;
  }, {})
//or
let fb2 = fruitBasket.reduce( (acc, fruit) => {
  if (!acc[fruit]) {
    acc[fruit] = 1;
  } else {
    acc[fruit] = acc[fruit] + 1;
  }
  return acc;
}, {});
console.log(fb1);
console.log(fb2);


console.log('------------- flat-array');
// Flattening an array of arrays
const data0 = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
const flat = data0.reduce((total, cur) => {
  return total.concat(cur);
}, []);
console.log(data0);
console.log(flat); // [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ]


console.log('------------- flat-array-obj');
// Flattening arrays
const data1 = [
    {a: 'happy', b: 'robin',    c: ['blue','green']}, 
    {a: 'tired', b: 'panther',  c: ['green','black','orange','blue']}, 
    {a: 'sad',   b: 'goldfish', c: ['green','red']}
];
const colors = data1.reduce((total, cur) => {
  cur.c.forEach( color => {
      total.push(color);
  })
  return total;
}, [])
console.log(colors); //['blue','green','green','black','orange','blue','green','red']


console.log('------------- flat-unique');
// Flattening unique
const uniqueColors = data1.reduce((total, cur) => {
  cur.c.forEach( color => {
    if (total.indexOf(color) === -1){
     total.push(color);
    }
  });
  return total;
}, []);
console.log(uniqueColors); // [ 'blue', 'red', 'green', 'black', 'orange']


console.log('------------- function-array');
// Array of functions
function increment(input) { return input + 1;}
function decrement(input) { return input - 1; }
function double(input) { return input * 2; }
function halve(input) { return input / 2; }

let pipeline = [increment, double, decrement];

const result = pipeline.reduce(function(total, func) {
    return func(total);
  }, 1);
console.log(result); // 3



console.log('------------- balance-Parentesis');
function balanceParentesis(string){
  return !string
      .split("")
      .reduce(function(prev, char){
          if(prev < 0) {return prev; }
          if(char ==="(") {return ++prev; }
          if(char ===")") {return --prev; }
          return prev;
      }, 0);
}
console.log("(())", balanceParentesis("(())")); //t
console.log("((()", balanceParentesis("((()")); //f
console.log(")(", balanceParentesis(")(")); //f
console.log("()()",balanceParentesis("()()")); //t
console.log(")(()())(",balanceParentesis(")(()())("));//f
