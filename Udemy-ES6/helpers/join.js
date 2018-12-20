// The join() method creates and returns a new string by concatenating all of the elements in an array (or an array-like object), separated by commas or a specified separator string.

// The string conversions of all array elements are joined into one string.
// If an element is undefined or null, it is converted to the empty string.

var elements = ['Fire', 'Wind', 'Rain'];

console.log(elements.join()); // expected output: Fire,Wind,Rain
console.log(elements.join('')); // expected output: FireWindRain
console.log(elements.join('-')); // expected output: Fire-Wind-Rain


var a = ['Wind', 'Rain', 'Fire'];
a.join();      // 'Wind,Rain,Fire'
a.join(', ');  // 'Wind, Rain, Fire'
a.join(' + '); // 'Wind + Rain + Fire'
a.join('');    // 'WindRainFire'

function f(a, b, c) {
  var s = Array.prototype.join.call(arguments);
  console.log(s); // '1,a,true'
}
f(1, 'a', true); //expected output: "1,a,true"
