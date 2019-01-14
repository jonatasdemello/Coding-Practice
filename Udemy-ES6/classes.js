console.log('------------- getter');
// using getter
class Rectangle {
    constructor(height, width) {
        this.height = height;
        this.width = width;
    }
    // Getter
    get area() {
        return this.calcArea();
    }
    // Method
    calcArea() {
        return this.height * this.width;
    }
}
const square = new Rectangle(10, 10);
console.log(square.area); // 100

console.log('------------- static-methods');
// static methods:
class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    static distance(a, b) {
        const dx = a.x - b.x;
        const dy = a.y - b.y;

        return Math.hypot(dx, dy);
    }
}
const p1 = new Point(5, 5);
const p2 = new Point(10, 10);

// static method is called in the class, not the object:
console.log(Point.distance(p1, p2)); // 7.0710678118654755

console.log('------------- prototype');
// using prototype:
function CarP(options) {
  this.title = options.title;
}
CarP.prototype.drive = function() {
  return 'vroom';
}
const carProto = new CarP({title: 'Focus'});
console.log("carProto.drive(): ", carProto.drive());
console.log("carProto: ", carProto);

// or 
CarP.prototype ={
  start: function() {
    return 'on';
  },
  stop: function() {
    return 'off';
  }
}


console.log('------------- samples');
class Car {
    constructor( {title} ) { // destructuring object => options.title
        this.title = title;
    }
    drive() {
        return 'vroom';
    }
}

class Toyota extends Car {
    constructor( {color} ) {
        super( { title: "toyota" } ); // calls base class' constructor
        this.color = color;
    }
    honk() {
        return 'beep';
    }
}
// create a new object
const ford = new Car( {title: "Focus"} );
console.log("ford car: ", ford);
console.log("ford car drive: ", ford.drive());

const toyota = new Toyota( { color: 'red' } ); // options object

console.log("car: ", toyota);
console.log("calling method honk:", toyota.honk());
console.log("calling method drive:", toyota.drive());

class Monster {
    constructor(options) {
        this.health = 100;
        this.name = options.name;
    }
}
class Snake extends Monster {
    bite(snake) {
        snake.health -= 10;
    }
}