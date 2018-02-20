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

/**  you code here  **/

function getLetter(s) {
    let letter;
    // Write your code here
    if (s.match("^[aeiou]") != null)
		letter = "A";
	else if (s.match("^[bcdefg]") != null)
		letter = "B";
    else if (s.match("^[hjklm]") != null)
		letter = "C";
	else if (s.match("^[npqrstvwxyz]") != null)
		letter = "D";
    return letter;
}

function main() {
    const s = readLine();
    
    console.log(getLetter(s));
}