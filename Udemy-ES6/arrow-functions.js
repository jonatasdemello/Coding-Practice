// Arrow functions also called "fat arrow functions"
// arrow functions are anonymous, which means that they are not named.

// When to use:
// - with anything that requires "this" to be bound to the context, and not the function itself
// - with map() and reduce(), to make code more readable

// When not to use:
// - when it makes your code less readable
// - in object methods, because "this" is not bound to anything 
//   and will inherit the value of this from its parent scope
    var cat = {
        lives: 9,
        jumps: () => {
            this.lives--;  // lives is never decreased
        }
    }
// - in callback function with dynamic context
//    var button = document.getElementById('press');
//    button.addEventListener('click', () => {
//        this.classList.toggle('on');
//    });
// gives a "TypeError" because "this" is not bound to the button
// it is bound to its parent scope


// ES5 syntax:
function timesTwoA(params) {
    return params * 2;
}
console.log(timesTwoA(4)); // 8

// using arrow function:
var timesTwoB = params => params * 2;
console.log(timesTwoB(4)); // 8


var add = function (a, b) {
    return a + b;
}
console.log(add(1, 2));

const add0 = (a, b) => {
    return a + b
}; // with {} must use retrun 

const add1 = (a, b) => a + b; // no need for return

console.log(add0(1, 2));
console.log(add1(3, 4));


const two = () => {
    return 2
};
// or: tow = () => 2;

const double = number => {
    return 2 * number;
};

console.log(two());
console.log(double(4));

// arrow functions are usefull in map() and reduce()
const numbers = [1, 2, 3]
let res = numbers.map(function (n) {
    return 2 * n;
});
console.log('Numbers:', res);
// or
let resMap = numbers.map(n => 2 * n);
console.log('Numbers:', resMap);


const team = {
    members: ['Jane', ' Bill'],
    teamName: 'Super Squad',
    teamSummary: function () {
        return this.members.map((m) => {
            return `${m} in on team ${this.teamName}`;
        });
    }
};
console.log(team.teamSummary());


// ES5
// bind(this) is required to help pass the this context into the function.
// Otherwise, by default this would be undefined.
var objES5 = {
    id: 42,
    counter: function counter() {
        setTimeout(function () {
            console.log(this.id);
        }.bind(this), 1000);
    }
};

// ES6
// ES6 arrow functions can’t be bound to a this keyword, so it will lexically go up a scope, 
// and use the value of this in the scope in which it was defined.
var objES6 = {
    id: 42,
    counter: function counter() {
        setTimeout(() => {
            console.log(this.id);
        }, 1000);
    }
};