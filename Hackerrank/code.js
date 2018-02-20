/* Javascript - 
	https://www.hackerrank.com/domains/tutorials/10-days-of-javascript 
*/


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

function getLetter(s) {
    let letter;
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


function vowelsAndConsonants(s) {
    
	for(var i=0; i < s.length; i++){
		if(s[i].match("[aeuoi]") != null)
			console.log(s[i]);
	}
	for(var i=0; i < s.length; i++){
		if(s[i].match("[^aeuoi]") != null)
			console.log(s[i]);
	}	
}



function main() {
    const s = readLine();
    console.log(getLetter(s));
	vowelsAndConsonants(s);
}


function getSecondLargest(nums) {
    // Complete the function
	var max=0;
	var sec=0;
	
	for(let i=0; i<nums.length; i++) {
		if(nums[i] > max) {
			max = nums[i];
		}
		if(nums[i] >= sec && nums[i] < max) {
			sec = nums[i];
		}
	}
	return sec;
}


function main() {
    const n = +(readLine());
    const nums = readLine().split(' ').map(Number);
    console.log(getSecondLargest(nums));
}


