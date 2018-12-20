// The forEach() method executes a provided function once for each array element.

// the forEach() method doesn’t actually return anything (undefined). 
// It simply calls a provided function on each element in your array. 
// This callback is allowed to mutate the calling array.

console.log('------------- simple forEach');
var array1 = ['a', 'b', 'c'];
array1.forEach(function(element) {
  console.log(element);
});
// expected output: "a"
// expected output: "b"
// expected output: "c"

console.log('------------- for');
var colors = ['red', 'green', 'blue'];
// using for
for (var i = 0; i < colors.length; i++) {
  console.log(colors[i]);
}
console.log('------------- forEach');
// using forEach
colors.forEach(function (c) {
  console.log(c);
});
console.log('------------- forEach does not change original');
// using forEach
colors.forEach(function (c) {
  c = c + '!!!';
});
console.log('colors:', colors);

console.log('------------- for');
// using for
var numbers = [1,2,3];
var doubledNumbers = [];
for (let i = 0; i < numbers.length; i++) {
  doubledNumbers.push(numbers[i] * 2); // use push to add to another array
}
console.log(doubledNumbers);

console.log('------------- forEach');
// using foreach
var dNumbers = [];
numbers.forEach( function(n){ 
  dNumbers.push(n * 2);
});
console.log('x', numbers);
console.log('d', dNumbers);



console.log('------------- forEach index');
let arr = [1, 2, 3, 4, 5];
console.log('src:',arr);

arr.forEach((num, index) => {
  arr[index] = num * 2;
});
console.log('idx:', arr);

console.log('------------- map');
// using map
let doubled = arr.map(num => {
  return num * 2; // map must use return!
});
console.log('map:',doubled);


// using a function parameter:
var images = [
  { height: 10, width: 30 },
  { height: 20, width: 90 },
  { height: 54, width: 32 }
];
var areas = [];

function areaCalc(image){
 var area = image.height * image.width;
 
 areas.push(area);
}

images.forEach(areaCalc);

