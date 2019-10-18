function* foo(){
    yield 1;
    yield 2;
}

for (let o of foo()) {
    console.log(o);
}

console.log('---');

let iterable = [10, 20, 30];

for (let value of iterable) {
    value += 1;
    console.log(value);
}

console.log('--- strings');

let str = 'This is a string';

for (let value of str) {
    console.log(value);
}


function Fn_forOf() {
    var colors = ['red', 'green', 'blue'];

    for (let c of colors) {
        console.log(c);
    }
}