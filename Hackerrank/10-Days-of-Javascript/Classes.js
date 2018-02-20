'use strict';
/*
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
*/
/**  you code here  **/
/*
 * Implement a Polygon class with the following properties:
 * 1. A constructor that takes an array of integer side lengths.
 * 2. A 'perimeter' method that returns the sum of the Polygon's side lengths.
 */
function Polygon(sides) {
    this.sides = sides;
    this.perimeter = function() {
        //console.log(typeof this.sides);
        let sum=0;
        for (let i = 0; i <this.sides.length; i++) { 
            sum = sum + this.sides[i];
        }
        return sum;
    };
}

function main() {

    const rectangle = new Polygon([10, 20, 10, 20]);
    const square = new Polygon([10, 10, 10, 10]);
    const pentagon = new Polygon([10, 20, 30, 40, 43]);

    console.log(rectangle.perimeter());
    console.log(square.perimeter());
    console.log(pentagon.perimeter());
}
main();