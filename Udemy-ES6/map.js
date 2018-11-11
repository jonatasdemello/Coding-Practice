function Fn_map_0() {

    // map() — creates a new array with the results of calling a provided function on every element in the calling array.
    // the map() method will also call a provided function on every element in the array. 
    // The difference is that map() utilizes return values and actually returns a new Array of the same size.
    // map() Use it when: You want to translate values in an array into another set of values.
    // What it does: Map traverses the array from left to right. It invokes a function (in this case, eachAmount * .93) on eachAmount 
    // When the method is finished mapping all the elements it returns a new array with all the translated elements.

    const dollars = [32, 45, 50];
    const euros = dollars.map(eachAmount => eachAmount * .93);

    console.log(euros); //  [29.76, 41.85, 46.5]
}

function Fn_map_1() {
    /*
    The map() method creates a new array with the results of calling a function for every array element.
    The map() method calls the provided function once for each element in an array, in order.
    Note: map() does not execute the function for array elements without values.
    Note: map() does not change the original array.

    array.map(function(currentValue, index, arr), thisValue)
        currentValue	Required. The value of the current element
        index	Optional. The array index of the current element
        arr	Optional. The array object the current element belongs to
    */

    var numbers = [1, 2, 3];
    var double = [];

    for (var i = 0; i < numbers.length; i++) {
        double.push(numbers[i] * 2);
    }

    var d = double.map(function (n) {
        return n * 2;
    });

    console.log(numbers);
    console.log(double);
    console.log(d);
}

function mapForEach(arr, fn) {
  const newArr = [];

  for (let i=0; i < arr.length; i++) {
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
