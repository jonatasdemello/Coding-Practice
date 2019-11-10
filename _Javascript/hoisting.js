// Declarations are Hoisted
// Initializations are Not Hoisted
// Variables and constants declared with let or const are not hoisted!

var x = 5; // Initialize x
var y;     // Declare y

console.log(x + " " + y);
// Display x and 'undefined'
// y is undefined

y = 7;    // Assign 7 to y 

console.log(x + " " + y);
// Display x and 7