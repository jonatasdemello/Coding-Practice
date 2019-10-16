----------------------------
Server:
----------------------------
npm install -g http-server
http-server ./
----------------------------


Links:
-----

https://www.google.ca/search?q=javascript+graphic&oq=javascript+graphic&aqs=chrome..69i57.4986j0j7&sourceid=chrome&ie=UTF-8#q=javascript+graphics+library
http://www.kaiyuanba.cn/content/develop/Perl/Graphics_Programming_With_Perl.pdf

http://konvajs.github.io/
http://graphics2d.js.org/
http://www.createjs.com/easeljs
http://www.createjs.com/getting-started/easeljs
https://jonobr1.github.io/two.js/
http://mrdoob.github.io/three.js/
https://two.js.org/	
http://code.tutsplus.com/tutorials/drawing-with-twojs--net-32024

Pixi.js
	http://www.pixijs.com/
	https://github.com/kittykatattack/learningPixi


	https://two.js.org/
	
processingjs	http://processingjs.org/learning/
fabric.js		http://fabricjs.com/
paper.js		http://paperjs.org/examples/
pixijs			http://www.pixijs.com/
D3.js			https://d3js.org/

https://square.github.io/intro-to-d3/
http://alignedleft.com/tutorials/d3

http://fabricjs.com/fabric-intro-part-1

CanvasPlus
https://code.google.com/archive/p/canvasplus/downloads



http://www.w3schools.com/html/html5_canvas.asp
http://home.cogeco.ca/~ve3ll/jstutorg.htm

https://www.khanacademy.org/computing/computer-programming/programming

http://www.walterzorn.de/en/jsgraphics/jsgraphics_e.htm

https://github.com/jonatasdemello/HTMLGraph
https://github.com/devramtal/Physics-for-JavaScript-Games-Animation-Simulations


Console
https://medium.freecodecamp.com/how-to-get-the-most-out-of-the-javascript-console-b57ca9db3e6d

http://blog.teamtreehouse.com/mastering-developer-tools-console
https://developer.chrome.com/devtools


https://developer.mozilla.org/en-US/docs/Tools/Web_Console
https://developer.mozilla.org/en-US/docs/Web/API/Console




DevTools:
---------

Ctrl+Shift+J

Use Ctrl+Shift+I 	to open the DevTools.
Use Ctrl+Shift+J 	to open the DevTools and bring focus to the Console.
Use Ctrl+Shift+C 	to open the DevTools in Inspect Element mode, or toggle Inspect Element mode if the DevTools are already open.

To open the Web Console:

either select "Web Console" from the Web Developer submenu in the Firefox Menu (or Tools menu if you display the menu bar or are on Mac OS X)
or press the CtrlShiftK (CommandOptionK on OS X) keyboard shortcut.

console.log("OK");
console.warn("warn");
console.error("error")
console.debug("debug");
console.info("info");

console.
	assert()
	clear()
	count()
	dir()
	dirxml()
	error()
	group()
	groupCollapsed()
	groupEnd()
	info()
	log()
	profile()
	profileEnd()
	table()
	time()
	timeEnd()
	timeStamp()
	trace()
	warn()

console.log(document);
console.dir(document);
	
Substitution string	Description
%o or %O	Outputs a JavaScript object. Clicking the object name opens more information about it in the inspector.
%d or %i	Outputs an integer. Number formatting is supported, for example  
			console.log("Foo %.2d", 1.1) will output the number as two significant figures with a leading 0: Foo 01
%s	Outputs a string.
%f	Outputs a floating-point value. Formatting is supported, for example  c
			onsole.log("Foo %.2f", 1.1) will output the number to 2 decimal places: Foo 1.10

%s	string
%d, %i	integer
%f	float
%o	DOM element
%O	JavaScript object
%c	styled CSS

for (var i=0; i<5; i++) {
  console.log("Hello, %s. You've called me %d times.", "Bob", i+1);
}

console.log("This is %cMy stylish message", "color: yellow; font-style: italic; background-color: blue;padding: 2px");
console.log("This is the outer level");
console.group();
console.log("Level 2");
console.group();
console.log("Level 3");
console.warn("More of level 3");
console.groupEnd();
console.log("Back to level 2");
console.groupEnd();
console.debug("Back to the outer level");

console.time("answer time");
alert("Click to continue");
console.timeEnd("answer time");


function foo() {
  function bar() {
    console.trace();
  }
  bar();
}

foo();


Selectors:

$(selection)	=> $('body'), $('h1'), $('#id')
$$(selection)	=> $$()
$x(xpath)

inspect($("#myId"))


monitorEvents($('h1'), "mouse");

Console:	$0 -> $4	select the previous element



-----------------------------------------------------------------

- hasOwnProperty
- typeof
- prototype
- for(var x in obj) {}

Array:
	concat(arr)
	join(sep)
	pop()
	push(item)
	reverse()
	shift()
	slice(start, end)
	sort()
	splice(index, cnt)
	unshift(item)
	
Promises:
	error(callback)
	success(callback)
	then(callback)
	

	toString()
	toString(2) 8, 16 base
	toFixed(n)
	toExponential(n)
	toPrecision(n)
	
	Number(str)
	parseInt(str)
	parseFloat(str)
	
	

// Find jQuery Version:
jQuery Version:
$().jquery; or $.fn.jquery 


var bob = {
    firstName: "Bob",
    lastName: "Jones",
    phoneNumber: "(650) 777-7777",
    email: "bob.jones@example.com"
};

// Literal Notation
var spencer = {
  age: 22,
  country: "United States"
};


// Object Constructor Notation
var spencer2 = new Object();
	//using dot notation
	spencer2.age = 22;
	spencer2.country = "United States";

var spencer3 = new Object();
	// using bracket notation
	spencer3["age"] = 22;
	spencer3["country"] = "United States";


// A custom constructor for book
function Book (pages, author) {
    this.pages = pages;
    this.author = author;
}
// Use our new constructor to make the_hobbit in one line
var the_hobbit = new Book(320, "J.R.R. Tolkien");




function Cat(age, color) {
  this.age = age;
  this.color = color;
}

// make a Dog constructor here
function Dog(age, name, breed){
    this.age = age;
    this.name = name;
    this.breed = breed;
}

function Person(name,age) {
  this.name = name;
  this.age = age;
  this.species = "Homo Sapiens";
}

var sally = new Person("Sally Bowles", 39);
var holden = new Person("Holden Caulfield", 16);
console.log(sally.name +" sally's species is " + sally.species + " and she is " + sally.age + " years old." );
console.log(holden.name +" holden's species is " + holden.species + " and he is " + holden.age + " years old." );


function Rectangle(height, width) {
  this.height = height;
  this.width = width;
  this.calcArea = function() {
      return this.height * this.width;
  };
  // put our perimeter function here!
  this.calcPerimeter = function() {
      return 2 * this.height + 2 * this.width;
  }
  
}

var rex = new Rectangle(7,3);
var area = rex.calcArea();
var perimeter = rex.calcPerimeter();



function Rabbit(adjective) {
    this.adjective = adjective;
    this.describeMyself = function() {
        console.log("I am a " + this.adjective + " rabbit");
    };
}

// now we can easily make all of our rabbits
var rabbit1 = new Rabbit("fluffy");
var rabbit2 = new Rabbit("happy");
var rabbit3 = new Rabbit("sleepy");

rabbit1.describeMyself();
rabbit2.describeMyself();
rabbit3.describeMyself();


// Our person constructor
function Person (name, age) {
    this.name = name;
    this.age = age;
}

// Now we can make an array of people
var family = new Array();
family[0] = new Person("alice", 40);
family[1] = new Person("bob", 42);
family[2] = new Person("michelle", 8);
// add the last family member, "timmy", who is 6 years old
family[3] = new Person("timmy", 6);




// Our Person constructor
function Person(name, age) {
    this.name = name;
    this.age = age;
}
// Now we can make an array of people
var family = new Array();
family[0] = new Person("alice", 40);
family[1] = new Person("bob", 42);
family[2] = new Person("michelle", 8);
family[3] = new Person("timmy", 6);


// loop through our new array
for(var i=0; i<family.length; i++){
    console.log(family[i].name);
}


// Our person constructor
function Person (name, age) {
    this.name = name;
    this.age = age;
}

// We can make a function which takes persons as arguments
// This one computes the difference in ages between two people
var ageDifference = function(person1, person2) {
    return person1.age - person2.age;
}

var alice = new Person("Alice", 30);
var billy = new Person("Billy", 25);

// get the difference in age between alice and billy using our function
var diff = ageDifference(alice, billy);



// Our person constructor
function Person (name, age) {
    this.name = name;
    this.age = age;
}

// We can make a function which takes persons as arguments
// This one computes the difference in ages between two people
var ageDifference = function(person1, person2) {
    return person1.age - person2.age;
};

// Make a new function, olderAge, to return the age of
// the older of two people
var olderAge = function(person1, person2) {
    if(person1.age > person2.age){
        return person1.age;
    }
    else {
        return person2.age;
    }
}

// Let's bring back alice and billy to test our new function
var alice = new Person("Alice", 30);
var billy = new Person("Billy", 25);

console.log("The older person is " + olderAge(alice, billy));



// Literal Notation
var spencer = {
  age: 22,
  country: "United States"
};

// make spencer2 here with constructor notation
var spencer2 = new Object();
spencer2.age = 22;
spencer2.country = "United States";

var spencer3 = new Object();
spencer3["age"] = 22;
spencer3["country"] = "United States";


var snoopy = new Object();
snoopy.species = "beagle";
snoopy.age = 10;

// save Snoopy's age and species into variables
// use dot notation for snoopy's species
var species = snoopy.species;
    
// use bracket notation for snoopy's age
var age = snoopy["age"];


// 3 lines required to make harry_potter
var harry_potter = new Object();
harry_potter.pages = 350;
harry_potter.author = "J.K. Rowling";

// A custom constructor for book
function Book (pages, author) {
    this.pages = pages;
    this.author = author;
}

// Use our new constructor to make the_hobbit in one line
var the_hobbit = new Book(320, "J.R.R. Tolkien");



function Circle (radius) {
    this.radius = radius;
    this.area = function () {
        return Math.PI * this.radius * this.radius;
    };
    // define a perimeter method here
    this.perimeter = function() {
        return 2 * Math.PI * this.radius;
    }
};


var bob = {
    firstName: "Bob",
    lastName: "Jones",
    phoneNumber: "(650) 777-777",
    email: "bob.jones@example.com"
};

console.log(bob.firstName);
console.log(bob.lastName);
console.log(bob.email);



var bob = {
    firstName: "Bob",
    lastName: "Jones",
    phoneNumber: "(650) 777-7777",
    email: "bob.jones@example.com"
};

var mary = {
    firstName: "Mary",
    lastName: "Johnson",
    phoneNumber: "(650) 888-8888",
    email: "mary.johnson@example.com"
};

var contacts = new Array();
contacts[0] = bob;
contacts[1] = mary;

console.log(contacts[1].phoneNumber);


var contacts = [bob, mary];

// printPerson added here
function printPerson(person){
    console.log(person.firstName +' '+ person.lastName);
}

printPerson(contacts[0]);
printPerson(contacts[1]);




var bob = {
    firstName: "Bob",
    lastName: "Jones",
    phoneNumber: "(650) 777-7777",
    email: "bob.jones@example.com"
};

var mary = {
    firstName: "Mary",
    lastName: "Johnson",
    phoneNumber: "(650) 888-8888",
    email: "mary.johnson@example.com"
};

var contacts = [bob, mary];

function printPerson(person) {
    console.log(person.firstName + " " + person.lastName);
}

function list(){
    var contactsLength = contacts.length;
    for(var i=0; i<contactsLength; i++){
        printPerson(contacts[i]);
    }
}

list();




var bob = {
    firstName: "Bob",
    lastName: "Jones",
    phoneNumber: "(650) 777-7777",
    email: "bob.jones@example.com"
};

var mary = {
    firstName: "Mary",
    lastName: "Johnson",
    phoneNumber: "(650) 888-8888",
    email: "mary.johnson@example.com"
};

var contacts = [bob, mary];

function printPerson(person) {
    console.log(person.firstName + " " + person.lastName);
}

function list() {
	var contactsLength = contacts.length;
	for (var i = 0; i < contactsLength; i++) {
		printPerson(contacts[i]);
	}
}

/*Create a search function
then call it passing "Jones"*/
function search(lastName) {
    var contactsLength = contacts.length;
    for (var i = 0; i < contactsLength; i++) {
        if(contacts[i].lastName === lastName) {
            printPerson(contacts[i]);
        }
    }   
}

search("Jones");





var bob = {
    firstName: "Bob",
    lastName: "Jones",
    phoneNumber: "(650) 777-7777",
    email: "bob.jones@example.com"
};

var mary = {
    firstName: "Mary",
    lastName: "Johnson",
    phoneNumber: "(650) 888-8888",
    email: "mary.johnson@example.com"
};

var contacts = [bob, mary];

function printPerson(person) {
    console.log(person.firstName + " " + person.lastName);
}

function list() {
	var contactsLength = contacts.length;
	for (var i = 0; i < contactsLength; i++) {
		printPerson(contacts[i]);
	}
}

/*Create a search function
then call it passing "Jones"*/
function search(lastName) {
    var contactsLength = contacts.length;
    for (var i = 0; i < contactsLength; i++) {
        if(contacts[i].lastName === lastName) {
            printPerson(contacts[i]);
        }
    }   
}

function add(firstName, lastName, phoneNumber, email){
    contacts[contacts.length] = {
        firstName: firstName,
        lastName: lastName,
        phoneNumber: phoneNumber,
        email: email
    };    
}

add("Jack", "Black", "666-7777", "jack.b@mail.com");
list();



var james = {
    // add properties to this object!
    job : "programmer",
    married: false    
};

function Person(job, married) {
    this.job = job;
    this.married = married;
}

// create a "gabby" object using the Person constructor!
var gabby = new Person("student", true);



function Person(job, married) {
    this.job = job;
    this.married = married;
    // add a "speak" method to Person!
    this.speak = function(){
        console.log("Hello!");
    };
}

var user = new Person("Codecademy Student",false);
user.speak();


// constructor vs literal notation
var someObj = {

aProperty: value,
someMethod: function(some, params) { }

};


var james = {
    job: "programmer",
    married: false,
    speak: function(text) {
        console.log("Hello, I am feeling "+ text);
    }
};

james.speak("great");
james.speak("just okay");



var james = {
    job: "programmer",
    married: false,
    sayJob: function() {
        // complete this method
        console.log("Hi, I work as a "+ this.job);
    }
};

// james' first job
james.sayJob();

// change james' job to "super programmer" here
james.job = "super programmer";

// james' second job
james.sayJob();



Who's in Your Bracket?
And finally, let's go over retrieving property values. Throughout this section, we've been using dot notation to get the value of an object's property:

someObj.propName;
However, remember that we can also use bracket notation:

someObj["propName"];
An advantage of bracket notation is that we are not restricted to just using strings in the brackets. We can also use variables whose values are property names:

var someObj = {propName: someValue};
var myProperty = "propName";
someObj[myProperty];
The last line is exactly the same as using someObj["propName"];.




var james = {
    job: "programmer",
    married: false
};

// set to the first property name of "james"
var aProperty = "job";

// print the value of the first property of "james" 
// using the variable "aProperty"
console.log(james[aProperty]);





// complete these definitions so that they will have
// the appropriate types
var anObj = { job: "I'm an object!" };
var aNumber = 42;
var aString = "I'm a string!";

console.log( typeof anObj ); // should print "object"
console.log( typeof aNumber ); // should print "number"
console.log( typeof aString ); // should print "string"



var myObj = {
    // finish myObj
    name: "name",
    maried: false
};

console.log( myObj.hasOwnProperty('name') ); // should print true
console.log( myObj.hasOwnProperty('nickname') ); // should print false




var suitcase = {
    shirt: "Hawaiian"
};

if(suitcase.hasOwnProperty("shorts")){
    console.log(suitcase.shorts);
}



var nyc = {
    fullName: "New York City",
    mayor: "Bill de Blasio",
    population: 8000000,
    boroughs: 5
};

for(var property in nyc){
    console.log(property);
}


List ALL the Properties!
We've just seen how to print all of an object's property names with a for-in loop. But how do we print out all the values associated with every property? Surprise! The for-in loop will be our friend again! Let's get there slowly. Our dog object can help us.

var dog = {
species: "bulldog",
age: 3,
color: brown
};
First, remember that
dog.species = dog["species"] = "bulldog";

And if we say:

var x = "species";

then

dog[x] = "bulldog";

We see that by assigning the property name to a variable, we can then use the variable name in bracket notation to get the property's value. So to get all the values from the dog object, we would use the for-in loop and the bracket notation we just saw above. See the hint to see the code to print the property values for dog.




var nyc = {
    fullName: "New York City",
    mayor: "Bill de Blasio",
    population: 8000000,
    boroughs: 5
};

// write a for-in loop to print the value of nyc's properties
for(var property in nyc){
    console.log(nyc[property]);
}




function Person(name,age) {
  this.name = name;
  this.age = age;
}

// Let's make bob again, using our constructor
var bob = new Person("Bob Smith", 30);
var susan = new Person("Susan Jordan", 35);

// make your own class here
function Circle(radius) {
    this.radius = radius;
}




Teach Snoopy
So we know that a class will have certain properties and methods, but what keeps track of what a given class can or can't do? What a class has or doesn't have? That is the job of the prototype.

JavaScript automatically defines the prototype for class with a constructor. For example, our Dog constructor ensures that the Dog prototype has a breed property. Remember, the Dog prototype keeps track of what Dog has, doesn't have, can, or can't do.

We know we can add methods to objects, and in line 7 we add the bark method to buddy. Hit run and you will see one "Woof" printed when buddy barks. Notice what happens when we try to get snoopy to bark in line 17 though. Even though snoopy is of the class Dog, he doesn't know how to bark because only buddy had bark added as a method.


function Dog (breed) {
  this.breed = breed;
}

// here we make buddy and teach him how to bark
var buddy = new Dog("Golden Retriever");
buddy.bark = function() {
  console.log("Woof");
};
buddy.bark();

// here we make snoopy
var snoopy = new Dog("Beagle");
// we need you to teach snoopy how to bark here

// this causes an error, because snoopy doesn't know how to bark!
snoopy.bark();

snoopy.bark = function(){
    console.log("au");
};
snoopy.bark();



function Person(name,age) {
  this.name = name;
  this.age = age;
}
// a function that prints the name of any given person
var printPersonName = function (p) {
  console.log(p.name);
};

var bob = new Person("Bob Smith", 30);
printPersonName(bob);

// make a person called me with your name and age
// then use printPersonName to print your name
var me = new Person("Jonatas", 40);
printPersonName(me);




Prototype to the Rescue
Here we have very similar code as last time, but there is an important difference. Instead of using buddy.bark to add the bark method to just the buddy object, we use Dog.prototype.bark.

Click run this time, and both buddy and snoopy can bark just fine! Snoopy can bark too even though we haven't added a bark method to that object. How is this so? Because we have now changed the prototype for the class Dog. This immediately teaches all Dogs the new method.

In general, if you want to add a method to a class such that all members of the class can use it, we use the following syntax to extend the prototype:

className.prototype.newMethod =

function() {
statements;
};



function Dog (breed) {
  this.breed = breed;
};

// here we make buddy and teach him how to bark
var buddy = new Dog("golden Retriever");
Dog.prototype.bark = function() {
  console.log("Woof");
};
buddy.bark();

// here we make snoopy
var snoopy = new Dog("Beagle");
/// this time it works!
snoopy.bark();



function Cat(name, breed) {
    this.name = name;
    this.breed = breed;
}

// let's make some cats!
var cheshire = new Cat("Cheshire Cat", "British Shorthair");
var gary = new Cat("Gary", "Domestic Shorthair");

// add a method "meow" to the Cat class that will allow
// all cats to print "Meow!" to the console
Cat.prototype.meow = function(){
    console.log("Meow!");
}

// add code here to make the cats meow!
cheshire.meow();
gary.meow();


// create your Animal class here
function Animal(name,numLegs){
    this.name = name;
    this.numLegs = numLegs;
}
// create the sayName method for Animal
Animal.prototype.sayName = function(){
    console.log("Hi my name is "+ this.name);
}

// provided code to test above constructor and method
var penguin = new Animal("Captain Cook", 2);
penguin.sayName();



// the original Animal class and sayName method
function Animal(name, numLegs) {
    this.name = name;
    this.numLegs = numLegs;
}
Animal.prototype.sayName = function() {
    console.log("Hi my name is " + this.name);
};

// define a Penguin class
function Penguin(name){
    this.name = name;
    this.numLegs = 2;
}

// set its prototype to be a new instance of Animal
Penguin.prototype = new Animal();





// the original Animal class and sayName method
function Animal(name, numLegs) {
    this.name = name;
    this.numLegs = numLegs;
}
Animal.prototype.sayName = function() {
    console.log("Hi my name is " + this.name);
};

// define a Penguin class
function Penguin(name){
    this.name = name;
    this.numLegs = 2;
}

// set its prototype to be a new instance of Animal
Penguin.prototype = new Animal();

var penguin = new Penguin("sally");
penguin.sayName();




function Penguin(name) {
    this.name = name;
    this.numLegs = 2;
}

// create your Emperor class here and make it inherit from Penguin
function Emperor(name) {
    this.name = name;
}

Emperor.prototype = new Penguin();

// create an "emperor" object and print the number of legs it has
var emperor = new Emperor("joe");

console.log(emperor.numLegs);



Up the Food-I-mean-Prototype Chain
A penguin is an animal and an emperor penguin is a penguin. Are emperor penguins animals too? Of course!

The "prototype chain" in JavaScript knows this as well. If JavaScript encounters something it can't find in the current class's methods or properties, it looks up the prototype chain to see if it's defined in a class that it inherits from. This keeps going upwards until it stops all the way at the top: the mighty Object.prototype (more on this later). By default, all classes inherit directly from Object, unless we change the class's prototype, like we've been doing for Penguin and Emperor.




// original classes
function Animal(name, numLegs) {
    this.name = name;
    this.numLegs = numLegs;
    this.isAlive = true;
}
function Penguin(name) {
    this.name = name;
    this.numLegs = 2;
}
function Emperor(name) {
    this.name = name;
    this.saying = "Waddle waddle";
}

// set up the prototype chain
Penguin.prototype = new Animal();
Emperor.prototype = new Penguin();

var myEmperor = new Emperor("Jules");

console.log( myEmperor.saying ); // should print "Waddle waddle"
console.log( myEmperor.numLegs ); // should print 2
console.log( myEmperor.isAlive ); // should print true



function Person(first,last,age) {
   this.firstName = first;
   this.lastName = last;
   this.age = age;
}

var john = new Person('John','Smith',30);
var myFirst = john.firstName;
var myLast = john.lastName;

//declare variable myAge set to the age of the john object.
var myAge = john.age;




Private Variables
Good! But what if an object wants to keep some information hidden?

Just as functions can have local variables which can only be accessed from within that function, objects can have private variables. Private variables are pieces of information you do not want to publicly share, and they can only be directly accessed from within the class.

The Person class has been modified to have a private variable called bankBalance. Notice that it looks just like a normal variable, but it is defined inside the constructor for Person without using this, but instead using var. This makes bankBalance a private variable.


function Person(first,last,age) {
   this.firstname = first;
   this.lastname = last;
   this.age = age;
   var bankBalance = 7500;
}

// create your Person 
var john = new Person("John","C",30);

// try to print his bankBalance
console.log(john.bankBalance);
// => undefined


function Person(first,last,age) {
   this.firstname = first;
   this.lastname = last;
   this.age = age;
   var bankBalance = 7500;
  
   this.getBalance = function() {
      // your code should return the bankBalance
      return bankBalance;
   };
}

var john = new Person('John','Smith',30);
console.log(john.bankBalance);
// prints => undefined

// create a new variable myBalance that calls getBalance()
myBalance = john.getBalance();
console.log(myBalance);




Private Methods
Why did that code work? An object's private variables can only be accessed by other methods that are part of that same object. So, we just used an object's public method to access a private variable!

Methods can also be private within a class and inaccessible outside of the class. Changing this.returnBalance from the last exercise to var returnBalance makes this method private. If you run the program trying to access the method you get an undefined error this time.

The way to access a private method is similar to accessing a private variable. You must create a public method for the class that returns the private method.

Instructions
Create a method called askTeller within the Person class that returns the returnBalance method. This means that it returns the method itself and NOT the result of calling that method. So you should NOT have parentheses after returnBalance.

Because askTeller returns a method, we need to call it to make it any use. This is what var myBalance = myBalanceMethod(); does.

?
Hint
Your method should resemble how we defined getBalance last time—you should use this.askTeller = function() { }. Don't declare askTeller with var.

You return method the same way that you would return simple variables. Be careful not to call the method though and leave out parentheses in your return statement!


function Person(first,last,age) {
   this.firstname = first;
   this.lastname = last;
   this.age = age;
   var bankBalance = 7500;
  
   var returnBalance = function() {
      return bankBalance;
   };
       
   // create the new function here
   this.askTeller = function() {
        return returnBalance;   
   }
}

var john = new Person('John','Smith',30);
console.log(john.returnBalance);
var myBalanceMethod = john.askTeller();
var myBalance = myBalanceMethod();
console.log(myBalance);




function Person(first,last,age) {
   this.firstname = first;
   this.lastname = last;
   this.age = age;
   var bankBalance = 7500;
  
   this.askTeller = function(pass) {
     if (pass == 1234) return bankBalance;
     else return "Wrong password.";
   };
}

var john = new Person('John','Smith',30);
/* the variable myBalance should access askTeller()
   with a password as an argument  */
var myBalance = john.askTeller(1234);




var languages = {
    english: "Hello!",
    french: "Bonjour!",
    notALanguage: 4,
    spanish: "Hola!"
};

// print hello in the 3 different languages
for(var x in languages) {
    if(typeof languages[x] === "string"){
        console.log(languages[x]);
    }
}


function Dog (breed) {
    this.breed = breed;
};

// add the sayHello method to the Dog class 
// so all dogs now can say hello
Dog.prototype.sayHello = function(){
    console.log("Hello this is a "+ this.breed +" dog");
}

var yourDog = new Dog("golden retriever");
yourDog.sayHello();

var myDog = new Dog("dachshund");
myDog.sayHello();




So Meta I Can't Take It!
Do you remember how we said every JavaScript object has some baggage associated with it? Part of this baggage was the hasOwnProperty method available to all objects. Now let's see where this came from...

If we have just a plain object (i.e., not created from a class constructor), recall that it automatically inherits from Object.prototype. Could this be where we get hasOwnProperty from? How can we check?

Instructions

// what is this "Object.prototype" anyway...?
var prototypeType = typeof Object.prototype;
console.log(prototypeType);

// now let's examine it!
var hasOwn = Object.prototype.hasOwnProperty("hasOwnProperty");
console.log(hasOwn);



Private Eye
Recall that:

Public properties can be accessed from outside the class
Private properties can only be accessed from within the class
Using constructor notation, a property declared as this.property = "someValue;" will be public, whereas a property declared with var property = "hiddenValue;" will be private.

In this exercise, hit run and you'll see that all your grades are exposed! You really just want people to know your overall GPA.



function StudentReport() {
    this.grade1 = 4;
    this.grade2 = 2;
    this.grade3 = 1;
    this.getGPA = function() {
        return (this.grade1 + this.grade2 + this.grade3) / 3;
    };
}

var myStudentReport = new StudentReport();

for(var x in myStudentReport) {
    if(typeof myStudentReport[x] !== "function") {
        console.log("Muahaha! " + myStudentReport[x]);
    }
}

console.log("Your overall GPA is " + myStudentReport.getGPA());


function StudentReport() {
    var grade1 = 4;
    var grade2 = 2;
    var grade3 = 1;
    this.getGPA = function() {
        return (grade1 + grade2 + grade3) / 3;
    };
}

var myStudentReport = new StudentReport();

for(var x in myStudentReport) {
    if(typeof myStudentReport[x] !== "function") {
        console.log("Muahaha! " + myStudentReport[x]);
    }
}

console.log("Your overall GPA is " + myStudentReport.getGPA());




//Create the object called cashRegister 
//and initialize its total property
var cashRegister = {
    total: 0
}

//Using dot notation change the total property
cashRegister.total = 2.99;

var cashRegister = {
    total:0,
    add: function(itemCost){
        this.total += itemCost;
    }
};

//call the add method for our items
cashRegister.add(0.98);
cashRegister.add(1.23);
cashRegister.add(4.99);
cashRegister.add(0.45);

//Show the total bill
console.log('Your bill is '+cashRegister.total);


var cashRegister = {
    total: 0,
    //insert the add method here    
    add: function(itemCost){
        this.total += itemCost;
    },    
    scan: function (item) {
        switch (item) { 
        case "eggs": 
            this.add(0.98); 
            break;
        
        case "milk": 
            this.add(1.23); 
            break;
        
        //Add other 2 items here
        case "magazine":
            this.add(4.99);
            break;
            
        case "chocolate":
            this.add(0.45);
            break;        
        }
        return true;
    }
};

//Scan 2 eggs and 3 magazines
cashRegister.scan("eggs");
cashRegister.scan("eggs");

cashRegister.scan("magazine");
cashRegister.scan("magazine");
cashRegister.scan("magazine");

//Show the total bill
console.log('Your bill is '+cashRegister.total);





var cashRegister = {
    total:0,
    add: function(itemCost){
        this.total += itemCost;
    },
    scan: function(item, quantity=1) {
        switch (item) {
        case "eggs": this.add(0.98 * quantity); break;
        case "milk": this.add(1.23 * quantity); break;
        case "magazine": this.add(4.99 * quantity); break;
        case "chocolate": this.add(0.45 * quantity); break;
        }
    }
};

// scan each item 4 times
cashRegister.scan("eggs",4);
cashRegister.scan("milk",4);
cashRegister.scan("magazine",4);
cashRegister.scan("chocolate");


//Show the total bill
console.log('Your bill is '+cashRegister.total);


var cashRegister = {
    total:0,
    //Dont forget to add your property
    lastTransactionAmount: 0,
    
    add: function(itemCost) {
        this.total +=  itemCost;
        this.lastTransactionAmount = itemCost;
    },
    scan: function(item,quantity) {
        switch (item) {
        case "eggs": this.add(0.98 * quantity); break;
        case "milk": this.add(1.23 * quantity); break;
        case "magazine": this.add(4.99 * quantity); break;
        case "chocolate": this.add(0.45 * quantity); break;
        }
        return true;
    },
    //Add the voidLastTransaction Method here
    voidLastTransaction: function(){
        this.total -= this.lastTransactionAmount;
    }    
};

cashRegister.scan('eggs',1);
cashRegister.scan('milk',1);
cashRegister.scan('magazine',1);
cashRegister.scan('chocolate',4);

//Void the last transaction and then add 3 instead
cashRegister.voidLastTransaction();

cashRegister.scan('chocolate',3);

//Show the total bill
console.log('Your bill is '+cashRegister.total);



// create a constructor for the StaffMember class
var StaffMember = function(name, discountPercent){
    this.name = name;
    this.discountPercent = discountPercent;
}

var sally = new StaffMember("Sally",5);
var bob = new StaffMember("Bob",10);

//Create a StaffMember for yourself called me
var me = new StaffMember("me",20);



function StaffMember(name,discountPercent){
    this.name = name;
    this.discountPercent = discountPercent;
}

var sally = new StaffMember("Sally",5);
var bob = new StaffMember("Bob",10);

// Create yourself again as 'me' with a staff discount of 20%
var me = new StaffMember("me",20);

var cashRegister = {
    total:0,
    lastTransactionAmount: 0,
    add: function(itemCost){
        this.total += (itemCost || 0);
        this.lastTransactionAmount = itemCost;
    },
    scan: function(item,quantity){
        switch (item){
        case "eggs": this.add(0.98 * quantity); break;
        case "milk": this.add(1.23 * quantity); break;
        case "magazine": this.add(4.99 * quantity); break;
        case "chocolate": this.add(0.45 * quantity); break;
        }
        return true;
    },
    voidLastTransaction : function(){
        this.total -= this.lastTransactionAmount;
        this.lastTransactionAmount = 0;
    },
    // Create a new method applyStaffDiscount here
    applyStaffDiscount: function(employee){
        this.total -= this.total * (employee.discountPercent / 100);
    }    
};

cashRegister.scan('eggs',1);
cashRegister.scan('milk',1);
cashRegister.scan('magazine',3);
// Apply your staff discount by passing the 'me' object 
// to applyStaffDiscount
cashRegister.applyStaffDiscount(me);

// Show the total bill
console.log('Your bill is '+cashRegister.total.toFixed(2));






We can link a JavaScript file to HTML by including it as the src of a <script> tag inside of an HTML file, like this:

<script src='js/main.js'></script>
This line of code will link the file located at js/main.js. You can find this file in the file navigator by clicking the file button located at the top left of the code editor. Within the navigator, there's a folder named js, and within that folder is the main.js file.

By linking js/main.js in the index.html file, we are asking the browser to run our JavaScript code each time index.html loads.

We've provided you with a sample website (and the corresponding HTML and CSS code). Our goal: use JavaScript to make this page more dynamic. We will add interactive features to it as we go through the lesson.

In the code editor, we've loaded the files for a static HTML and CSS website. If you've never seen HTML before, don't worry, we'll walk through how JavaScript is added to an existing HTML and CSS project in this lesson. This lesson won't require you to greatly modify the HTML and CSS code itself. (For a deeper dive, see our HTML & CSS course here.)
1.
Let's start by writing some JavaScript that we will soon link to our HTML document.

Click the folder icon attached to the code editor, and navigate inside the js folder and open main.js.

Inside main.js, write:

alert('Hello JavaScript!');
Note: alert is a JavaScript function that will create a pop-up window with text inside it. When we link the main.js file to the HTML file, we will see a pop-up window that was generated by this code. alert is not used by JavaScript developers in practice, however it is useful here to demonstrate linking these two files. We will use it over the next few exercises for demonstration purposes.
2.
Navigate back to index.html. Before the closing </body> tag, create a link to the main.js file using a <script> tag.

Once you've add it, click 'Run'.
Stuck? Get a hint

3.
Nice alert pop-up! We just connected JavaScript to an HTML file. When the HTML document loaded, it ran the code inside main.js, which created the alert pop-up.

Now let's take this a step further.


We've just covered how to select HTML elements using the syntax: document.getElementsByClassName. This is verbose and clunky, however. If we were to select a lot of elements this way, our code would get dense and difficult to read.

Wouldn't it be nice if there was a simpler way to select DOM elements? As you might have guessed, there is!

To better interact with DOM elements, we can use a library. A library is a set of code that contains useful pre-written functions that help with certain tasks.

A great library for interacting with the DOM is jQuery.

jQuery is a library written in JavaScript. The syntax and functions it contains will help us interact with DOM efficiently. We'll walk through a few examples in the following exercises.

In order to use jQuery, we need to:

Include jQuery in our project. jQuery is a library, which means it is a set of code in a file, therefore we will need to link that file in our HTML in order to access it.

Once we link it in our HTML file, we can use its functions and syntax in our js/main.js file.
Once linked, we'll need to make sure our HTML is loaded before we run our jQuery and JavaScript code.

This will prevent our jQuery and JavaScript code from running before the elements they select are rendered.
1.
Since jQuery is a library of code, we need to include a link to it in our index.html file before we can use it. Before the closing </body> tag, right above your current <script> tag, include this code:

<script src='https://code.jquery.com/jquery-3.1.0.min.js'></script>
The link to jQuery needs to be above the link to the js/main.js file, which will give main.js access to the jQuery library.

Note: If you're curious, you can see all the code that makes up jQuery here. You'll notice that jQuery is just JavaScript!
Stuck? Get a hint
2.
Now that we've included jQuery, let's get it ready to run.

Navigate to js/main.js.

Delete or comment out your existing code in js/main.js. Then, write a function named main. The function should take no parameters and should have an empty block.
Stuck? Get a hint
3.
jQuery has a built in function to check if the page is ready before it will run our code. After the main function, write this code:

$(document).ready(main);
Notice that we put main inside the parentheses of ready. main here is a callback, which means that our code will wait until the document (in other words, the DOM) is loaded, or ready. When it is, then it will execute the main function. jQuery calls back to the main function, therefore it's a callback.

In the event that our HTML and CSS took 5 minutes to load, this code would wait until it loaded completely before running
4.
Nice work! We are now ready to start using jQuery. Let's try in the next exercise.

Click 'Next' to continue.


With plain JavaScript we selected an HTML element with this code:

document.getElementsByClassName('skillset');
With jQuery we can select the same element with:

$('.skillset');
We can wrap any CSS selector, like class, id, or tag, with $('.example-class') to select it with jQuery.
The selectors jQuery uses are the exact same as CSS selectors. For instance, if there's an element with a class of supporting-text, you could select it with $('.supporting-text'). Another example, if an element had an id of 'header', you could select it with $('#header').
1.
Let's select the element with the class of skillset, but this time with jQuery.

In js/main.js, inside the main function, write a variable named $skillset. Set $skillset equal to a jQuery selector for the skillset class.

Note: It is a common convention to name variables that hold jQuery selectors with a dollar sign $.
Stuck? Get a hint

2.
On the line below the jQuery selector for skillset, write an alert on $skillset.
Stuck? Get a hint
3.
The alert shows [object Object]. This is right and means that we successfully selected the same HTML element as before, but this time using jQuery.

Now let's see what we can do once we've selected an DOM element.



Now that we can select an element with jQuery, we can use built-in jQuery functions to modify it. From here on, we will start building features into our skills website.

First off, it would be nice to make the page fade in when loaded.

To make a page fade in, it must first be hidden. We can hide elements with jQuery with a function named hide.

We can hide elements with jQuery, like this:

$('.my-selector').hide();
We attached the hide function directly to the jQuery selector.
The hide function will add the CSS property display: none to the DOM element from the page, which will hide it.
1.
We want all of our skills to fade in, so we need to hide the skills first. In index.html, the element around all of our skills has the class skillset.

Inside the main function, delete the $skillset variable and the alert you wrote in the last exercise. Then use jQuery to hide the skillset element. Do this by writing a selector for skillset, then attaching hide() to it with a period.

Then, click 'Run'.
Stuck? Get a hint
2.
Notice that the skills have been hidden. hide added a CSS property of display: none to .skillset element, which hid the elements.

Now, let's learn how to fade in the skillset when the page loads. Click 'Next' to continue.



The next feature we'd like to build is making the 'Recent Projects' clickable. When clicked, the button should show the individual projects, and when clicked again, it should hide the projects.

In order to make an element clickable, we need to write jQuery that listens to an element for a click event. jQuery can do this with an event listener function named on('click').

This function will wait for a click event, and when one occurs, it will execute a provided function. The syntax looks like this:

$('.example-class').on('click', function() {
  // execute the code here when .example-class is clicked.
});
$('.example-class') selects an HTML element with the class example-class.
.on('click', function() { ... }) adds a click listener to the selector. When it's clicked the function will execute the code within its block.
1.
Our goal is to show our HTML projects when the 'Recent Projects' button in each section is clicked, and to hide them when we click it again.

Let's start by hiding the projects that are currently there.

Under your existing code in the main function, use jQuery to hide the elements with a class of projects.
Stuck? Get a hint
2.
Our elements are now hidden. The next step is to make the 'Recent Projects' button clickable.

Under the hide you just wrote, write a jQuery selector for the 'Recent Projects' button. Its class is .projects-button.

Then, attach on('click'), and provide it an empty function as the second parameter to on.
Stuck? Get a hint
3.
Now that the click listener is set up on the 'Recent Projects' buttons, let's make the projects appear when we click them.

Click 'Next' to continue.



When we click on a 'Recent Projects' button, the projects show. Next, let's hide the projects if we click the 'Recent Projects' button again.

jQuery provides a function named toggle that is helpful in this situation. toggle will hide or show an element, each time it is triggered. The syntax looks like this:

$('example-class').toggle();
toggle can be called directly on an jQuery selector.
When toggle is executed, it will hide or show the element that the selector points to. If the element is currently hidden, toggle will show the element, and vice versa.
1.
Inside the click function, we wrote a selector for the projects class and we called show on it.

Replace the show function with toggle.

Then 'Run' your code and click on the 'Recent Projects' buttons multiple times.
Stuck? Get a hint
2.
Making progress!

Now the projects toggle in and out when we click.

Next, let's make our button change appearance when it is clicked.

Click 'Next' to continue.


In the last exercise, we were toggling every 'Recent Projects' button instead of only the one we clicked on.

We can select the specific element we clicked on with the jQuery selector $(this).

The syntax looks like this:

$('.example-class').on('click', function() {
  $(this).toggleClass('active');
});
$(this) selects the clicked element. If there are multiple elements with a class of .example-class, this will only toggle the class of the one that is clicked on.
Notice that $(this) does not require quotes around it, since it is not a CSS class. Instead, this is a JavaScript keyword.
$(this) behaves just like our other selectors. We can attach toggleClass or toggle to it in the same way.
1.
Let's begin by only changing the class of the element we clicked.

Modify the toggleClass we wrote in the last exercise to use $(this) as its selector.
Stuck? Get a hint
2.
Now click on the 'Recent Project' buttons within each section and see that only the button you click on will toggle its class.

Next up, let's toggle the projects in the section we clicked on, instead of toggling them all.

Click 'Next' to continue.



In order to toggle the projects in each section, we will need to use $(this) to select the button we clicked on. The issue is that $(this) refers to the projects-button in our current code, and not the projects themselves.

We need a way to select the projects elements next to the button that we clicked.

Luckily, jQuery can select elements logically. In index.html, notice that the projects-button element is directly followed by the projects list. Therefore the projects element is next after it.

jQuery has a function named next to help us select elements that are next to another element. If we have this in our HTML:

<div class='item-one'> ... </div>
<div class='item-two'> ... </div>
If we wanted to hide item-two, we could write:

$('.item-one').next().hide();
We can attach next to any jQuery selector to select the next direct element.
Then, we can attach any jQuery function to next(). In this case, we attached hide, which would hide the next element after the $('.item-one') element.
1.
Inside the click function, let's modify this line:

$('.projects').toggle();
Instead of selecting all the projects elements, use $(this) and next to select the projects, then attach toggle on the end to toggle the projects on the page.
Stuck? Get a hint

2.
When you click on the 'Recent Projects' buttons now, only that section's buttons projects toggle.

Nice work, this page is really coming together.

Let's add two more features.

Click 'Next' to continue.


Since we have a few areas to click on, it may be helpful to show users which sections they have viewed by changing the text inside the 'Recent Projects' buttons.

When a user clicks on a button, we will permanently change the text of the button to 'Projects Viewed'.

We can change the text of an element with the jQuery function text. It's syntax looks like this:

$('.my-selector').text('Hello world!');
text attaches directly to a jQuery selector.
Inside of text's parentheses, we can provide text that will become the text of our DOM element. The text we supply will replace any existing text, and if the element has no pre-existing text, text will add it.
1.
Within the projects-button click function, under the toggleClass line, write jQuery to change the text of the button that was clicked to say 'Projects Viewed'.
Stuck? Get a hint
2.
Now click on the 'Recent Project' buttons and notice that they now turn to 'Projects Viewed' after each click. Very nice!


The last feature we'd like to add is an aesthetic one. Right now when we click the 'Recent Projects' buttons, the projects appear instantly.

Let's instead make the projects slide onto the page when we click the 'Recent Projects' button and then slide off the page when we click the button again.

jQuery provides a method named slideToggle that can animate an element's entrance and exit. The syntax looks like this:

$('.example-class').slideToggle(400);
slideToggle can be called directly on a jQuery selector.
slideToggle also takes a parameter of milliseconds that the animation should last. The default is 400 milliseconds, or 0.4 seconds.
1.
Let's make our projects slide in and out when we click on the 'Recent Projects' button.

Inside the click function, delete or comment out this line in your code:

$(this).next().toggle();
This line can prevent the slideToggle from working properly, since it is also affecting the showing and hiding behavior of the projects element.

Then, select the projects element of the button that is clicked. Use slideToggle on the selector to animate its appearance and exit on the page. The animation should last 400 milliseconds.
Stuck? Get a hint
2.
Now the projects slide in and out of the page when we click the 'Recent Projects' buttons.

By using jQuery, we've made this page much better by adding interactive elements.

Click 'Next' to review what you've learned.



Nice work! jQuery is a complete library, and we've only covered the basics. If you're interested in adding animations to websites and creating more dynamic elements, take our jQuery course here.

In this lesson we learned:

How to link a JavaScript file to an HTML file using a <script> tag.
jQuery is a library to help JavaScript interact with HTML elements.
We can make sure our page is ready to go with $(document).ready(). Then, we can pass in a function to ready that will execute when the page is loaded.
jQuery uses the same selector names as CSS.
We can hide elements with hide, and show them with show.
We can make elements appear with fadeIn.
on('click') functions allow us to make HTML elements clickable. When an element is clicked, the click function will execute the function we provide. It's full sytnax looks like:
$('.example-class').on('click', function() {
  // Execute when .example-class is clicked
});
toggle will toggle an element on and off the page.
$(this) will select the specific element that was clicked if placed inside a click function.
toggleClass can toggle a class on and off.
We can select elements next to each other with next.
text will replace a DOM element's text with text we specify.
slideToggle will make an element slide into and out of the page with an animation.
Impressive work on completing Learn JavaScript!

The next Javascript course, Intermediate JavaScript, is coming soon! In the course you'll learn how to write full-fledged programs in JavaScript.

Until then, try out our jQuery course to make websites more dynamic, or start building applications with JavaScript with our AngularJS course and our React course. AngularJS and React are two application frameworks written in JavaScript. With them, you'll be able to create web applications.

Congrats again on your progress in completing Learn JavaScript! 






// Slower (the zero-based :even selector is a jQuery extension)
$( "#my-table tr:even" );
 
	// Better, though not exactly equivalent
	$( "#my-table tr:nth-child(odd)" );

// Avoid Excessive Specificity
$( ".data table.attendees td.gonzalez" );
 
	// Better: Drop the middle if possible.
	$( ".data td.gonzalez" );

// Fast:
$( "#container div.robotarm" );
 
// Super-fast:
$( "#container" ).find( "div.robotarm" );


// Unoptimized:
$( "div.data .gonzalez" );
 
// Optimized:
$( ".data td.gonzalez" );


$( ".buttons > *" ); // Extremely expensive.
$( ".buttons" ).children(); // Much better.
 
$( ":radio" ); // Implied universal selection.
$( "*:radio" ); // Same thing, explicit now.
$( "input:radio" ); // Much better.




Canvas:
https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API/Tutorial/Drawing_shapes#Drawing_paths

- clearRect()
	void ctx.clearRect(x, y, width, height);
	A common problem with clearRect is that it may appear it does not work when not using paths properly. 
	Don't forget to call beginPath() before starting to draw the new frame after calling clearRect.


- requestAminationFrame()


function animate() {
    render();
    requestAnimationFrame(animate);
}

function render() {
    drawClock(mainContext);
}


// Center Origin

var canvas;
var mainContext;

$(document).ready(function () {
    console.log("Starting clock...");

    canvas = document.getElementById("canvas");  
    mainContext = canvas.getContext("2d");
    
    var center = {};
    center.x = canvas.width / 2;
    center.y = canvas.height / 2;
    
    // so that we can use a centered coordinate system
    mainContext.translate(center.x, center.y);
    animate();
});




http://creativejs.com/resources/requestanimationframe/index.html

function draw() {
    // Drawing code goes here
}
setInterval(draw, 100);

This piece of code will call the draw function once every 100ms forever and ever, until at some point later the clearInterval function is called. An alternative to this code is to use a setTimeout function instead, this time inside the draw function:

function draw() {
    setTimeout(draw, 100);
    // Drawing code goes here
}
draw();

The single call to the draw function kicks off the animation loop, and from then on it will call itself repeatedly every 100ms.

https://www.nczonline.net/blog/2011/05/03/better-javascript-animations-with-requestanimationframe/

function draw() {
    requestAnimationFrame(draw);
    // Drawing code goes here
}
draw();


var fps = 15;
function draw() {
    setTimeout(function() {
        requestAnimationFrame(draw);
        // Drawing code goes here
    }, 1000 / fps);
}



