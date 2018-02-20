'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the reverseString function
 * Use console.log() to print to stdout.
 */
function reverseString(s) {
    try {
		var s1 = s.split("");
		var s2 = s1.reverse();
		var s3 = s2.join("");
		console.log(s3);
	} 
	catch (e) {
		console.log(e.message);
		console.log(s);
	} 
	/*finally {
		console.log(s);
	}*/
}

function main() {
    const s = eval(readLine());
    
    reverseString(s);
}



const arr = ['a', 'b', 'c', 'd'];

// 'i' is the index
for (let i = 0; i < arr.length; i++) {
    console.log('arr[' + i + ']: ' + arr[i]);
}

const o = {
    a: 1,
    b: 2,
    c: 3,
    d: 4
};

console.log('property: value');
// 'p' is the property
for (p in o) {
    console.log(p + ': ' + o[p]);
}

const o = ['first', 'second', false];

// 'p' is the index
for (let p in o) {
    console.log(p + ' ' + o[p]);
}

const arr = ['a', 'b', 'c', 'd'];

arr.forEach((value, index, array) => {
    console.log('index', index, 'has a value of', value,
    'which correlates to array[' + index + ']:', array[index]);
});

arr.forEach((value, index) => {
    console.log('index', index, 'has a value of', value);
});

arr.forEach((value) => {
    console.log('value:', value);
});

