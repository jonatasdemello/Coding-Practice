/* Javascript - 
	https://www.hackerrank.com/domains/tutorials/10-days-of-javascript 

	https://www.hackerrank.com/challenges/js10-switch/topics
	https://www.hackerrank.com/challenges/js10-arrays/topics
	https://www.hackerrank.com/challenges/js10-switch/topics/javascript-strings
	
	https://www.hackerrank.com/challenges/js10-try-catch-and-finally/topics
	
	*/


console.log('Hello, World!');


function getPerimeter(length, width) {
    let perimeter;
    perimeter = 2 * (length + width);
    return perimeter;
}


function factorial(n){
    if(n==1)
        return n;
    else
        return n * factorial(n-1);
}

function factorial(n) {
	if (n > 1) {
		return n * factorial(n - 1);
	}
	// Returns 1 if n <= 1
	return 1;
}
			
var fib = function fibonacci(n){
	if (n > 2) {
		return fibonacci(n - 1) + fibonacci(n - 2);
	}
	else if (n < 1) {
		return 0;
	}
	// else, return 1
	return 1;
}


var square = function(x) {
	return x * x;
};


const PI = Math.PI;
var r = 0;
r = readLine();
var area = PI * (r * r);
var perimeter = 2 * PI * r;
// Print the area of the circle:
console.log(area);
// Print the perimeter of the circle:
console.log(perimeter);
	
	switch (expression) {
    case label1:
        statement1;
        break;
    case label2:
        statement2;
        break;
    case label3:
        statement3;
        statement4;
        break;
    default:
        statement;
	}

function getGrade(score) {
    let grade;
	if (score > 25 && score <= 30)
		grade = "A";
	if (score > 20 && score <= 25)
		grade = "B";
	if (score > 15 && score <= 20)
		grade = "C";
	if (score > 10 && score <= 15)
		grade = "D";
	if (score > 5 && score <= 10)
		grade = "E";
	if (score >= 0 && score <= 5)
		grade = "F";
    return grade;
}

function getLetter(s) {
    let letter;
    // Write your code here
    
    return letter;
}

	
var input = "";
process.stdin.on('data', function (data) {
    input = data;
    switchDemo();
});
function readLine() { return input; }
/**** Ignore above this line. ****/

function switchDemo() {
    // This will read n as an object.
    var n = readLine();

    switch (n) {
        case 2:
            console.log("A");
            break;
        case 3:
            console.log("B");
            break;
        case 4:
            console.log("C");
            break;
        case 5:
            console.log("D");
            break;
        default:
            console.log("E");
    }

    console.log("Exited switch.");
}


var input = "";
process.stdin.on('data', function (data) {
    input = data;
    switchDemo();
});
function readLine() { return input; }
/**** Ignore above this line. ****/

function switchDemo() {
    var n = +(readLine());

    switch (n) {
        case 2:
        case 4:
        case 6:
            console.log("A");
            break;
        case 3:
        case 5:
        case 7:
            console.log("B");
            break;
        default:
            console.log("C");
    }

    console.log("Exited switch.");
}


var myNumber = 4;
var myString = String(myNumber);

console.log(myNumber + " is a " + typeof myNumber);
console.log(myString  + " is a " + typeof myString)


var input = "";
process.stdin.on('data', function (data) {
    input = data;
    main();
});
function readLine() { return input; }
/** Ignore above this line. **/
var s = "HackerRank";
var i = +(readLine());
console.log(s.charAt(i));

var s = "Hacker";
var t = "Rank";
var u = s.concat(t);
console.log(s + " " + t);
console.log(u);

var s = "HackerRank"; 
console.log(s.includes() + " " + s.includes(""));
console.log(s.includes("hack") + " " + s.includes("Hack"));

var s = "HackerRank"; 
console.log(s.endsWith() + " " + s.endsWith(""));
console.log(s.endsWith("rank") + " " + s.endsWith("Rank"));

var s = "HackerRank";
console.log(
    s.indexOf("a") + " " 
    + s.indexOf("a", s.length) + " " 
    + s.indexOf("a", 6)
);
console.log(
    s.indexOf("an") + " " 
    + s.indexOf("x") + " " 
    + s.indexOf("")
);

var s = "HackerRank";
console.log(
    s.lastIndexOf("a") + " " 
    + s.lastIndexOf("a", s.length) + " " 
    + s.lastIndexOf("a", 6)
);
console.log(
    s.lastIndexOf("ac") + " " 
    + s.lastIndexOf("x") + " " 
    + s.lastIndexOf("")
);



String.match()

Match a regular expression passed as an argument against the calling 
string. If a match is found, it returns an object with three properties: 
the matched substring, the index it was found at, and the input (i.e., 
the initial string); if no match is found, it returns null. For example: 


var s = "HackerRank";
console.log(s.match());
console.log(s.match("[a-z]+"));

[ '', index: 0, input: 'HackerRank' ]
[ 'acker', index: 1, input: 'HackerRank' ]


String.normalize()
Returns a string containing the Unicode Normalization Form of the calling string's value. The argument must be one of the following:

"NFC": Normalization Form Canonical Composition. This is the default in the event that no argument is given.
"NFD": Normalization Form Canonical Decomposition.
"NFKC": Normalization Form Compatibility Composition.
"NFKD": Normalization Form Compatibility Decomposition.
For example:


var s = "HackerRank";
console.log(s.normalize());
console.log(s.normalize("NFKC"));

var s = "HackerRank";
console.log(s.repeat () + "x" + s.repeat(0));
console.log(s.repeat(2));


String.replace()
Finds a match between a regular expression and a string, then returns a string where the first matched substring is replaced with a new substring. If no match is found, the returned string is the same as the original string. For example:

var s = "HackerRank";
console.log(s.replace() + " " + s.replace("a", ""));

HackerRank HckerRank

String.search()
Executes the search for a match between a regular expression and a specified string, then returns the index of the first character of the first match. For example:

var s = "HackerRank";
console.log(s.search() + " " + s.search("[a-z]"));
console.log(s.search("a") + " " + s.search("an"));

0 1
1 7

String.slice()
Extracts a section of a string and returns it as a new string. The extracted section depends on the arguments passed to the function:

If no arguments are passed to the function, it returns the entire string.
If one integer argument, i , is passed to the function, it returns a substring starting at index i and ending at the end of the string.
If two integer arguments, i and j, are passed to the function, it returns a substring consisting of characters in the range [i,j); in other words, this is a substring starting at index i and ending at j-1. For example:
If one (or both) of the arguments passed to this function is negative, then the index corresponding to that argument is calculated as String.length minus the given argument. For example:


var s = "HackerRank";
console.log(s.slice(0, 6) + " " + s.slice(6));
console.log(
    s.slice() + " " 
    + s.slice(-4, 8) + " " 
    + s.slice(-4, -2)
);

Hacker Rank
HackerRank Ra Ra


String.split()
Splits a String object into an array of strings by separating the string into substrings:

If no argument is given, it returns an array containing the original string.
If the empty string is passed as an argument, it returns an array of the string's individual letters.
If a string consisting of one or more letters is passed as an argument, it splits the string at each occurrence of that string and returns an array of the split substrings.


var s = "HackerRank";
console.log(s.split(""));
console.log(s.split("k"));
console.log(s.split());

[ 'H', 'a', 'c', 'k', 'e', 'r', 'R', 'a', 'n', 'k' ]
[ 'Hac', 'erRan', '' ]
[ 'HackerRank' ]

var s = "HackerRank";
console.log(s.startsWith("Hack"));
console.log(s.startsWith("Hacks"));

true
false



String.substr()
Returns a substring consisting of characters in a given range, depending on the arguments passed to the function:

If no arguments are passed to the function, it returns the entire string.
If one integer argument, , is passed to the function, it returns a substring starting at index  and ending at the end of the string.
If two integer arguments,  and , are passed to the function, it returns a substring consisting of characters in the range [i,j); in other words, this is a substring starting at index i and ending at j-1.

var s = "HackerRank";
console.log(s.substr());
console.log(s.substr(0, 6) + " " + s.substr(6));

HackerRank
Hacker Rank


String.substring()
Returns a substring consisting of characters in a given range, depending on the arguments passed to the function:

If no arguments are passed to the function, it returns the entire string.
If one integer argument, i, is passed to the function, it returns a substring starting at index i and ending at the end of the string.
If two integer arguments, i and j, are passed to the function, it returns a substring consisting of characters in the range [i,j); in other words, this is a substring starting at index i and ending at j-1.
For example:

var s = "HackerRank";
console.log(s.substring());
console.log(s.substring(0, 6) + " " + s.substring(6));

HackerRank
Hacker Rank

var s = "HackerRank";
s = s.toLowerCase();
console.log(s);

var s = "HackerRank";
s = s.toUpperCase();
console.log(s);

var s = "    HackerRank    ";
console.log("Original Length: " + s.length);
s = s.trim();
console.log("Trimmed Length: " + s.length);

var s = "    HackerRank    ";
console.log("Original Length: " + s.length);
s = s.trimLeft();
console.log("Trimmed Length: " + s.length);

var s = "    HackerRank    ";
console.log("Original Length: " + s.length);
s = s.trimRight();
console.log("Trimmed Length: " + s.length);


for-of
This loop iterates over iterable objects such as an Array, Map, Set, String, TypedArray, arguments object, etc. It essentially iterates over the value of each distinct property in the structure, such as each letter in a word or each element in an array.

'use strict';
process.stdin.on('data', function (data) {
    main(String(data).trim());
});
/**** Ignore above this line. ****/

function main(input) {
    // Split the words read as input into an array of words
    var array = input.split(new RegExp("[ \n]+"));

    // Print array
    console.log(array);

    // Print each of its elements on a new line
    for (let value of array) {
        console.log(value);
    }
}
hi bye 
hello goodbye

[ 'hi', 'bye', 'hello', 'goodbye' ]
hi
bye
hello
goodbye

'use strict';

let actress = new Map([
    ["firstName", "Julia"],
    ["lastName", "Roberts"],
    ["dateOfBirth", "October 28, 1967"],
    ["nationality", "American"],
    ["firstMovie", "Satisfaction"]
]);

// Print each Key-Value pair in the map
for (let info of actress) {
    console.log(info);
}

// Print each Key and Value as "Key: Value"
console.log();
for (let info of actress) {
    console.log(info[0] + ": " + info[1]);
}

[ 'firstName', 'Julia' ]
[ 'lastName', 'Roberts' ]
[ 'dateOfBirth', 'October 28, 1967' ]
[ 'nationality', 'American' ]
[ 'firstMovie', 'Satisfaction' ]

firstName: Julia
lastName: Roberts
dateOfBirth: October 28, 1967
nationality: American
firstMovie: Satisfaction



//Arrays
var a = ['first', 'second'];

a.forEach(function(e, i, array) {
    // 'i' is the index
    // 'e' is the element
    console.log(i + ' ' + e);
});


var a = ['first', 'second', 'third', 'fourth'];

let position = a.indexOf('second');

console.log('a:', a);
console.log('position:', position);


var a = ['c', 'a', 'd', 'b', 'aa'];
var b = [9, 2, 13, 7, 1, 12, 123];

// Sort in ascending lexicographical order using a built-in
a.sort();
b.sort();

console.log('a:', a);
console.log('b:', b);

var a = ['c', 'a', 'd', 'b', 'aa'];
var b = [9, 2, 13, 7, 1, 12, 123];

// Sort in descending lexicographical order using a compare function
a.sort(function(x, y) { return x < y; } );
b.sort(function(x, y) { return x < y; } );

console.log('a:', a);
console.log('b:', b);

var a = ['c', 'a', 'd', 'b', 'aa'];

// Sort in descending lexicographical order using a compare arrow function
a.sort((x, y) => x < y);

console.log('a:', a);


var a = ['first', 'second', 'third', 'fourth'];

for (let e of a) {
    console.log('e:', e);
}


