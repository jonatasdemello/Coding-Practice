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
function getCount(objects) {
    var count = 0;

    for (let i = 0; i < objects.length; i++) {
        if(objects[i].x == objects[i].y){
            count++;
        }
    }
    return count;

    // or for (let p in objects) { p + objects[p] }
    /* or
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
    */
}



function main() {
    const n = +(readLine());
    let objects = [];
    
    for (let i = 0; i < n; i++) {
        const [a, b] = readLine().split(' ');
        
        objects.push({x: +(a), y: +(b)});
    }
    
    console.log(getCount(objects));
}