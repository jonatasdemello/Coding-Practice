// The keys() method returns a new Array Iterator object that contains the keys for each index in the array.

var array1 = ['a', 'b', 'c'];
var iterator = array1.keys();

for (let key of iterator) {
  console.log(key); // expected output: 0 1 2
}

// The Object.keys() method returns an array of a given object's own property names, in the same order as we get with a normal loop.
const object1 = {
  a: 'somestring',
  b: 42,
  c: false
};
console.log(Object.keys(object1)); // expected output: Array ["a", "b", "c"]

var foo = {
  'alpha': 'puffin',
  'beta': 'beagle'
};
var keys = Object.keys(foo); // ['alpha', 'beta'] 
// (or maybe some other order, keys are unordered).


// simple array
var arr = ['a', 'b', 'c'];
console.log(Object.keys(arr)); // console: ['0', '1', '2']

// array like object
var obj = {
  0: 'a',
  1: 'b',
  2: 'c'
};
console.log(Object.keys(obj)); // console: ['0', '1', '2']

// array like object with random key ordering
var anObj = {
  100: 'a',
  2: 'b',
  7: 'c'
};
console.log(Object.keys(anObj)); // console: ['2', '7', '100']

// getFoo is a property which isn't enumerable
var myObj = Object.create({}, {
  getFoo: {
    value: function () {
      return this.foo;
    }
  }
});
myObj.foo = 1;
console.log(Object.keys(myObj)); // console: ['foo']

//If you want all properties, even non-enumerables, see Object.getOwnPropertyNames().


var arr = ['a', , 'c'];
var sparseKeys = Object.keys(arr);
var denseKeys = [...arr.keys()];
console.log(sparseKeys); // ['0', '2']
console.log(denseKeys); // [0, 1, 2]



const object1 = {
  a: 'somestring',
  b: 42,
  c: false
};
console.log(Object.keys(object1)); // expected output: Array ["a", "b", "c"]

// simple array
var arr = ['a', 'b', 'c'];
console.log(Object.keys(arr)); // console: ['0', '1', '2']

const object2 = {
  a: 1,
  b: 2,
  c: 3
};

console.log(Object.getOwnPropertyNames(object2));
// expected output: Array ["a", "b", "c"]

var arr = ['a', 'b', 'c'];
console.log(Object.getOwnPropertyNames(arr).sort());
// logs ["0", "1", "2", "length"]

// Logging property names and values using Array.forEach
Object.getOwnPropertyNames(obj).forEach(
  function (val, idx, array) {
    console.log(val + ' -> ' + obj[val]);
  }
);
// logs
// 0 -> a
// 1 -> b
// 2 -> c



var ladders = [{
    id: 1,
    height: 20
  },
  {
    id: 2,
    height: 30
  },
  {
    id: 3,
    height: 25
  },
];

function findWhere(array, criteria) {
  return array.find(function (a) {
    var prop = Object.keys(criteria)[0];
    return a[prop] === criteria[prop];
  });
}

console.log(findWhere(ladders, {
  height: 25
})) // {height: 25, id: 3}

var prop = Object.keys({
  height: 25,
  id: 10,
  name: 'test'
});
console.log(prop); // ["height", "id", "name"]
console.log(prop[0]); // height
