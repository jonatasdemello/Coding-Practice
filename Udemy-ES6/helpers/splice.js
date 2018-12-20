// The splice() method changes the contents of an array by removing or replacing existing elements and/or adding new elements.

// array.splice(start[, deleteCount[, item1[, item2[, ...]]]])

var months = ['Jan', 'March', 'April', 'June'];
months.splice(1, 0, 'Feb'); // inserts at 1st index position
console.log(months); // expected output: Array ['Jan', 'Feb', 'March', 'April', 'June']

months.splice(4, 1, 'May'); // replaces 1 element at 4th index
console.log(months); // expected output: Array ['Jan', 'Feb', 'March', 'April', 'May']


//Remove 0 (zero) elements from index 2, and insert "drum"

var myFish = ['angel', 'clown', 'mandarin', 'sturgeon'];
var removed = myFish.splice(2, 0, 'drum');
// myFish is ["angel", "clown", "drum", "mandarin", "sturgeon"] 
// removed is [], no elements removed

//Remove 1 element from index 3

var myFish = ['angel', 'clown', 'drum', 'mandarin', 'sturgeon'];
var removed = myFish.splice(3, 1);
// removed is ["mandarin"]
// myFish is ["angel", "clown", "drum", "sturgeon"]

//Remove 1 element from index 2, and insert "trumpet"

var myFish = ['angel', 'clown', 'drum', 'sturgeon'];
var removed = myFish.splice(2, 1, 'trumpet');

// myFish is ["angel", "clown", "trumpet", "sturgeon"]
// removed is ["drum"]

//Remove 2 elements from index 0, and insert "parrot", "anemone" and "blue"
var myFish = ['angel', 'clown', 'trumpet', 'sturgeon'];
var removed = myFish.splice(0, 2, 'parrot', 'anemone', 'blue');

// myFish is ["parrot", "anemone", "blue", "trumpet", "sturgeon"] 
// removed is ["angel", "clown"]

//Remove 2 elements from index 2
var myFish = ['parrot', 'anemone', 'blue', 'trumpet', 'sturgeon'];
var removed = myFish.splice(myFish.length - 3, 2);

// myFish is ["parrot", "anemone", "sturgeon"] 
// removed is ["blue", "trumpet"]

//Remove 1 element from index -2
var myFish = ['angel', 'clown', 'mandarin', 'sturgeon'];
var removed = myFish.splice(-2, 1);

// myFish is ["angel", "clown", "sturgeon"] 
// removed is ["mandarin"]

//Remove all elements after index 2 (incl.)
var myFish = ['angel', 'clown', 'mandarin', 'sturgeon'];
var removed = myFish.splice(2);

// myFish is ["angel", "clown"] 
// removed is ["mandarin", "sturgeon"]
