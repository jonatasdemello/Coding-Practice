// Spread syntax allows an iterable such as an array expression or string to be expanded
//  in places where zero or more arguments (for function calls) or elements (for array literals) 
// are expected, or an object expression to be expanded in places where zero or more key-value pairs (for object literals) are expected.

function sum(x, y, z) {
  return x + y + z;
}
const numbers = [1, 2, 3];
console.log(sum(...numbers)); // expected output: 6
// It is common to use Function.prototype.apply in cases where you want to use the elements of an array as arguments to a function.
console.log(sum.apply(null, numbers)); // expected output: 6


// The rest parameter syntax allows us to represent an indefinite number of arguments as an array.
// The reduce() method executes a reducer function (that you provide) on each member of the array resulting in a single output value.
function sum(...theArgs) {
  return theArgs.reduce((previous, current) => {
    return previous + current;
  });
}
console.log(sum(1, 2, 3)); // expected output: 6
console.log(sum(1, 2, 3, 4)); // expected output: 10



// The reduce() method executes a reducer function (that you provide) on each member of the array resulting in a single output value.
function addNumbers(numbers){
    return numbers.reduce( (sum, n) => {
        return sum + n;
    }, 0)
}
console.log(addNumbers([1,2,3,4,5]));

console.log('using spread');
function addNumbers1(...numbers){ // unknown number of args: (a,b,c,d)
    return numbers.reduce( (sum, n) => {
        return sum + n;
    }, 0)
}
console.log(addNumbers1(1,2,3,4,5));
console.log(addNumbers1(1,2,3,4,5,6,7,8,9));

// Concatenation:
const colors1 = ['red', 'green'];
const colors2 = ['blue', 'yellow'];
let c1 = colors1.concat(colors2);
// or
let c2 = [...colors1, ...colors2];
let c3 = ['other', ...colors1, ...colors2];
console.log('concat: ',c1);
console.log('spread: ',c2);


function validateShoppingList(...items){
    if(items.indexOf('milk') < 0 ){
        return ['milk', ...items];
    }
    return items;
}
console.log(validateShoppingList('bread','eggs'));


function product1(a, b, c, d, e) {
  var numbers = [a,b,c,d,e];
  return numbers.reduce(function(acc, number) {
    return acc * number;
  }, 1) //initialValue
}
//or
function product2(...numbers) {
  return numbers.reduce( (acc, number) => {
    return acc * number;
  }, 1) //initialValue
}

function join(array1, array2) {
  return array1.concat(array2);
}
function join1(array1, array2) {
  return [...array1, ...array2];
}

function unshift(array, a, b, c, d, e) {
  return [a, b, c, d, e].concat(array);
}
function unshift(array, ...items) {
  return [...items, ...array];
}


const MathLib = {
  calcProduct(...rest){
      console.log('use method multiply instead');
      return this.multiply(...rest);
  },
  multiply(a,b){
      return a*b;
  }
};

