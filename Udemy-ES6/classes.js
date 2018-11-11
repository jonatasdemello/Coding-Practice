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


class Car {
    constructor({title}) {
        this.title = title;
    }
    drive() {
        return 'vroom';
    }
}

class Toyota extends Car {
    constructor({color}) {
        super({
            title: "toyota"
        });
        this.color = color;
    }
    honk() {
        return 'beep';
    }
}

const toyota = new Toyota({
    color: 'red'
});
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