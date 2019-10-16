/* 
	Source: CodeAcademy
	-------------------
*/

Welcome to Learn JavaScript!

JavaScript is the most widely used programming language on the web and is used on most websites, including this one.

By the end of this course, you'll have a strong foundation in JavaScript. You'll be able to write full-fledged programs, make HTML and CSS dynamic, and write impressive web applications.

This unit has two parts:

Learn the building blocks of JavaScript
Do some fun stuff with those parts
Because this course starts with the building blocks of JavaScript, make sure to take notes and pace yourself. This foundation will take us through the rest of the JavaScript course.

The building blocks of JavaScript make up every program and line of JavaScript.

Just like a language has nouns, verbs, and prepositions, JavaScript has its own building blocks. Instead of calling them building blocks, however, developers call them data types.

There are three essential data types to know for now, and here is your first test of memorization (don't worry, we will practice):

String: Any grouping of words or numbers surrounded by single quotes: ' ... ' or double quotes " ... ".
Number: Any number, including numbers with decimals, without quotes: 4, 8, 1516, 23.42.
Boolean: This is always one of two words. Either true or false, with no quotations.
Let's review: a string is any grouping of words, a number's a number, and a boolean is a ghostly halloween costume. Or no, that's false! It's either true or false.


1. In the code editor, there are three variables (we will learn about variables in the next lesson). For now, replace each variable's value with each corresponding type.
On line 1, there's a variable named myString equal to undefined. Replace undefined, with a string of your name.

2. On line 2, there's a variable named myNumber, also equal to undefined. Replace undefined with your lucky number.

3. On line 3, answer this question with a boolean:
Did you like the Halloween joke?
If so, replace the word undefined with the boolean true. Otherwise, replace undefined with false.

4. Notice that your string, number, and boolean printed to the black box on the right. That is the console, and is a program that can run JavaScript programs and show their results.
We will learn how to use the JavaScript with the console in the next exercise.
Click 'Next' to continue.

var myString = "Joe";
var myNumber = 22;
var myBoolean = false;

// Do not edit the code under this line
console.log("Name: " + myString);
console.log("Lucky Number: " + myNumber);
console.log("Good joke? " + myBoolean);


We can't do much programming with our knowledge of types right now, so let's build something cool. Let's learn how to ask JavaScript to talk to us.

To do this, we need two things:

A way to ask JavaScript to talk.
Something for JavaScript to say.
We can ask JavaScript to print words to the console with this line of code:

console.log('Your message here.');
In human-speak, this is saying: "Hey console, please print/log this thing inside the parentheses. Bye, thanks!"

By writing this line, we've also solved the second thing we need: Something for JavaScript to say. We can put a String, Number, or Boolean (or any data type) inside the parentheses of a console.log statement.


1. Use console.log to log a string of your favorite pizza topping.

2. Fun fact: We can log multiple things at once by separating them with commas, like this:

console.log('bacon', 'pesto');

Use console.log to print out two of your favorite pizza toppings (plural).

console.log('Cheese');
console.log('bacon', 'pesto');

Don't worry, math does not need to be your strong-suit to learn JavaScript. There are just a few operations we'll need to know to make some awesome programs later in the course!).

JavaScript includes the general math operators that you can find on a calculator:

Add: +
Subtract: -
Multiply: *
Divide: /
These all work how you might guess: 3 + 4 will equal 7, 50 / 10 will equal 5.

Let's use each one of these math operators.

1.
Inside of a console.log, add 3.5 to your age.

This is the age you'll be when we start sending people to live on Mars.

2.
Inside another console.log, take the current year and subtract 1969.

The answer is how many years it's been since the 1969 moon landing.

3.
Create another console.log, then divide 65 by 240.

4.
Create one last console.log, then multiply the full answer from step 3 by 100.

That's the percent of the sun that is made up of helium. Assuming we could stand on the sun, we'd all sound like chipmunks!

console.log(40 + 3.5);
console.log(2017 - 1969);
console.log(65 / 240);
console.log(65 / 240 * 100);


Now let's generate a space fact while we learn a brand new operator called – drum roll please – the modulus.

The idea behind the modulus is to show you the remainder after you divide a number.

So, if you divide 13 / 5, 5 goes into 13 two times, and there will be 3 remaining. A modulus, denoted by a %, would take 13 % 5 and return the remainder 3.

How on Earth is this useful?

Let's ask a question a modulus can solve: What will the moon phase be one year from today?


1.
Let's say it's a full moon tonight, and we want to know what the moon will look like one year from today. We know from the moon phase image to the right that the moon circles the Earth every 27 days, so let's start by dividing 365 by 27.

Remember to put your calculations inside console.log to print them to the screen.

2.
That gives us a number (13), followed by a decimal(.518...).

To figure out what phase the moon will be in a year, we need to know how many extra days the moon will rotate around the earth before the end of the year. We need the decimal we just found displayed as remaining days.

Use the modulus operator to find the remaining days, then run your code.


3.
Now we know how many days into the moon's phase it will be in exactly one year.

We can now figure out, based on the moon phase image, what the moon phase will be 365 days from today. If it's a full moon today, a year from now it will be a new moon.

console.log(365 / 27);
console.log(365 % 27);


As it turns out, JavaScript has some tricks up its sleeve to make our lives easier.

JavaScript has built in functions, which help us do everyday things. We'll learn more about functions later in the course, so don't worry about understanding what they are right now.

Sometimes it's necessary to generate a random number within a program. We can do that with this code:

Math.random();
This code will return a random number between 0 and 1. JavaScript will generate a random number for us with this code.

To generate a random number between 0 and 50, we could multiply this result by 50, like so:

Math.random() * 50;
The problem with this is that the answer will most likely be a decimal. Luckily, JavaScript has our back with another built in function called Math.floor. Math.floor will take a decimal number, and round down to the nearest whole number. It is used like this:

Math.floor(Math.random() * 50);
In this case:

Math.random will generate a random number between 0 and 1.
We then multiplied that number by 50, so now we have a number between 0 and 50.
Then, Math.floor will round the number down to the nearest whole number.
Let's utilize these two methods to generate a random number between 0 and 100.
Instructions
1.
Inside of a console.log, create a random number with Math.random, then multiply it by 100.
If you run the program few times, you'll see random numbers in the console.

2.
Now, utilize Math.floor to make the output a whole number.
Inside the console.log you wrote in the last step, put Math.random() * 100 inside the parentheses of Math.floor.
Stuck? Get a hint

3.
Run the program a few times to see random numbers between 0 and 100.
Math.random() is a function that returns us a random value each time. Later in the course, we will use this to function to simulate a decision from the computer.


console.log(Math.floor(Math.random() * 100));


As we write JavaScript, we can create comments in our code.

Comments are lines that are not evaluated when the code runs. They exist just for human readers, in other words. Comments can be extremely useful when we're looking back at code we've written later on and for other people who will be looking at your code.

There are two types of code comments in JavaScript:

A single line comment will comment out a single line, and is denoted with two forward slashes // preceding a line of JavaScript code.

// The first 5 decimals of pi
console.log('Pi is equal to ' + 3.14159);
A multi-line comment will comment out multiple lines, and is denoted with /* to begin the comment, and */ to end the comment.

/*
console.log('All of this code');
console.log('Is commented out');
console.log('And will not be executed);
*/
1.
Let's practice adding some code comments.

To the right, we've provided you with the beginning of the book Catch-22 by Joseph Heller.

On line 1, write a single line comment that says 'Opening line'.
Stuck? Get a hint
2.
Single line comments are great for adding context to your code.

Multi-line comments are often best suited to prevent a block of code from running. Comment out lines 4 - 9 with a multi-line comment.


Let's take one more glance at the concepts we just learned:

There are three essential data types in JavaScript: strings, numbers, and booleans.
We can write out anything to the console with console.log.
We can do math with operators like +, -, *, and /.
We can find the remainder after dividing two numbers with a modulus: %.
We can generate a random number with Math.random, then make it a whole number with Math.floor.
We write a single line comment with // and a multi-line comment with /* and */.
You've just finished one of the toughest parts of this course, nice work!
Feel free to review the concepts you just learned in the code editor and console.

When you're ready, click 'Up Next'.


To write programs in JavaScript, we'll need to make our code reusable.

Part of making code reusable is removing the data we want to perform some logic on to leave only the logic. Then we can use our logic on any data. Here's what we mean:

Imagine you're writing a weather app. Your thermometer outside reports the temperature in Celsius and your goal is to report the temperature in Fahrenheit.

You write a program that takes a temperature like 15 degrees Celsius, then multiplies and divides it until you get the temperature in Fahrenheit.

Once you've done this though, you see the temperature now reads 16 degrees Celsius. In order to find Fahrenheit again, you'd need to write a whole new program to convert 16 degrees Celsius to Fahrenheit.

This would happen because the Celsius-to-Fahrenheit logic is operating directly on the Celsius data.

Luckily, JavaScript offers variables. Variables allow us to assign data to a word, then we can use that word within our program instead of the data. Then, if the variable's value changes we only have to change the variable's value instead of re-writing the entire program.


Let's dive in and see a variable in the wild. Here is how you declare a variable:

var myName = 'Arya';
console.log(myName);
// Output: Arya
You can almost read it aloud: "Variable myName is equal to Arya."

Let's dissect that statement and look at its parts:

var, short for variable, is the JavaScript keyword that will create a new variable for us.
myName is chosen by a developer (that's you!). Notice that the word has no spaces, and each new word is capitalized. This is a common convention in JavaScript, and is called camelCase.
= means to assign whatever's next to the variable.
'Arya' is the value that the equals = assigns into the variable myName.
After the variable is declared, we can print the variable with: console.log(myName). This will print 'Arya' to the console.
1.
Variables must be strong to hold all of our stuff. Exactly how strong are they?

Create a variable named strength, and assign the string '50,000 pounds' to it.
Stuck? Get a hint
2.
Now, under the strength variable, type

console.log('How much stuff can a variable hold? ', strength);
Now we know: What can a variable hold? Just about anything!

var strength = '50,000 pounds';
console.log('How much stuff can a variable hold? ', strength);


If variables can hold strings, can they hold other data types? Let's give it a shot:

var myAge = 15;
var likesChocolate = true;

console.log(myAge);
// Output: 15

console.log(likesChocolate);
// Output: true
Variables can hold any data type, like strings, numbers, and Booleans. They can also hold data types that we have not learned yet, like arrays, functions and objects (more on that later).
Instructions
1.
Under the strength variable, create a new variable named age and set it equal to your age as a number.

Stuck? Get a hint
2.
Under your age variable, use console.log to print it to the console.
Stuck? Get a hint
3.
Now, create another variable named hasPet, and set it equal to a boolean.

Then, print it to the console with console.log.
Stuck? Get a hint
4.
Way to go! Variables are able to hold any kind of data type.




Why do we care about variables?

Variables are useful in two ways:

They allow us to use the same value over and over, without having to write a string or other data type over and over.
More importantly, we can assign variables different values that can be read and changed by the program without altering our code.
For example, a weather app can show you a different high temperature every day. Instead of writing a new website everyday, they store the information in a variable and just change the value of that variable.

We can change a variable's value if we want, like this:

var weatherCondition = 'Monday: Raining cats and dogs';
weatherCondition = 'Tuesday: Sunny';

console.log(weatherCondition); 
// Output: 'Tuesday: Sunny'
We created a variable by using the keyword var and the name weatherCondition.
Then, we took the existing weatherCondition variable, and set its value equal to 'Tuesday: Sunny'.
True to their name, variables are indeed variable.
1.
Create a variable on line 1 named morningAlarm and set it to '6:30AM'.
Stuck? Get a hint
2.
On line 2, set morningAlarm equal to another time that's better for you, that is not at 6:30AM.
Stuck? Get a hint
3.
On line 3, use

console.log('Morning alarm is set to: ', morningAlarm)
to print out your alarm to the console.

Notice that you successfully changed the variable's value because of your code on line 2.


In the previous lessons, we've put strings into variables. Now, let's put a variable's value into a string!

Putting a variable in a string uses concepts we've already learned. The JavaScript term for this idea is interpolation.

Interpolwhat?! —Possibly the most fun JavaScript term to say.

We can use the + operator from earlier to interpolate (insert) a variable into a string, like this:

var myPet = 'armadillo';
console.log('I own a pet ' + myPet + '.'); 
// Output: 'I own a pet armadillo.'
Instructions
1.
Create a variable named favoriteAnimal and set it equal to your favorite animal.
Stuck? Get a hint
2.
Then, use console.log to print: 'My favorite animal: Koala', but replace 'Koala' with your favoriteAnimal variable.
You made it to the end of the first unit and this lesson! High five!

We learned:

How to create variables.
How to change a variable's value.
How to interpolate, or insert, a variable into a string.
In the next lesson, we will learn how to program JavaScript to make decisions for us and how to generate random numbers. Let's go!


If you think about what we've been doing so far, we've been writing instructions for computers.

That's all programming really is: a list of instructions for computers.

The main difficulty of being a developer is translating our ideas in human-speak into ideas in computer-speak.

Let's learn how we can ask JavaScript to think like us and make decisions like us.

Let's start with human-speak. Many decisions we make everyday boil down to this sentence in some form:

"If something is true, let's do option 1, or else, if it is false, let's do option 2."

This sentence looks fairly similar when we write it with JavaScript. See for yourself:

var needCoffee = true;
if (needCoffee) {
    console.log('Finding coffee');
} else {
    console.log('Keep on keeping on!');
}
If the variable needCoffee is true, JavaScript will run one code block, and if a variable is false, it will run another.
needCoffee is the condition we are checking inside the if's parentheses. Since it is equal to true, our program will run the code between the first opening curly brace { (line 2) and the first closing curly brace } (line 4). It will completely ignore the else { ... } part. In this case, we'd see 'Finding coffee' log to the console.

Note: Code between curly braces are called blocks. if/else statements have two code blocks.
If we adjusted needCoffee to be false, only the else's console.log will run.
if/else statements are how we can process yes/no questions programmatically.
1.
Create a variable named harryPotterFan and set it equal to a boolean, based on your preference.
Stuck? Get a hint
2.
Then, write an if/else statement that uses harryPotterFan as its condition. If it is true, then log, 'Mischief managed.'. If it is false, then log, 'I lead a muggle\'s life.'.

Note: Why is there a \ in 'I lead a muggle\'s life.'? Since the string is surrounded by single quotes, we can use a back slash to add a single quote within the string. This is called escaping a character.
Stuck? Get a hint
3.
Nice job!

You just taught JavaScript to make a decision for you.


if/else statements are made even more powerful with comparison operators.

There are two comparisons you might be familiar with:

Less than: <
Greater than: >
You may also recognize these:

Less than or equal to: <=
Greater than or equal to: >=
Comparisons need two things to compare and they will always return a boolean (true or false).

How can we use comparisons and an if/else statement to see if it's time to eat?
1.
Write a variable named hungerLevel and set it equal to 5.
2.
Write an if/else statement that checks if hungerLevel is greater than 7. If so, log 'Time to eat!', and if it is less than 7, log 'Let\'s eat later.'.
Stuck? Get a hint
3.
Notice that since hungerLevel is 5, the if statement evaluates to false, therefore the else's code block runs.

Now set the hungerLevel variable equal to 10 and run your code again.
4.
Now it's 'Time to eat!'

We can use the <, >=, and <= to compare variables in an if/else statement, which is a powerful way to make decisions in JavaScript.

Play around with these operators and values to see how exactly they work.

There are two more extremely useful comparisons we can make. Often times, we might want to check if two things are equal, or if they are not.

To check if two things equal each other, we can use === (three equals in a row).
To check if two things do not equal each other, we can write !== (exclamation with two equals in a row).
Slow down here, this can be easily confused with creating variables. Variables use one equals sign = to assign a value to a variable. When you're comparing two variables, make sure to use three ===.

How can we utilize === or !== and an if/else statement to write a program to see whether a werewolf will turn into its wolf form this evening?
1.
Write a variable named moonPhase and set it equal to 'full'.
Stuck? Get a hint
2.
Write an if/else statement that checks if the moon is full. If the moonPhase is 'full', log 'Howwwwlll!!' to the console, and if it is anything else, log 'I swear I am not a werewolf...'.
Stuck? Get a hint
3.
Notice the code inside the first block of curly braces { } ran. That's because moonPhase equals 'full', and therefore the condition evaluates to true.


So far, we've been able to translate certain thoughts into JavaScript code, like, "Are these things equal?" with ===, or, "Is one thing greater than another thing?" with >.

In English, sometimes we say "both of these things" or "either one of these things." Let's translate those phrases into JavaScript with some special operators called logical operators.

To say "both must be true," we can use &&.
To say "either can be true," we can use ||.
To say "I want to make sure this is the opposite of what it really is," we can use !.
To say "these should not be equal to each other," we can use !==.
For example:

if (stopLight === 'green' && pedestrians === false) {
  console.log('Go!');
} else {
  console.log('Stop');
}
In the example above, we make sure that the stopLight is 'green' and && there are no pedestrians before we log 'Go!'.
If either of those conditions are false, we log 'Stop'.
Just like the operators we learned previously, these logical operators will return either true or false.

These logical operators are helpful when writing if/else statements, since they let us make sure multiple variables are true or false.
1.
Let's say the werewolf can only become its wolf form when there is a full moon and a it's a foggy night.

We already have a moonPhase variable, so let's start with making a foggyNight variable set equal to true.
2.
Now, set moonPhase to 'full' again. Now that we have both conditions, let's write that in our if/else statement.

In the first condition of the if/else statement, make sure that moonPhase === 'full' and foggyNight are true, using &&.

Note: if/else statements check the true-ness or false-ness of variables, so there's not need to write foggyNight === true. You only need to write foggyNight, and you'll get the same result.

Once you've added it, click 'Run'.
Stuck? Get a hint
3.
Now, change the foggyNight variable to equal false and run it again.
Stuck? Get a hint
4.
Notice that the default else will print to the console. That's because && requires both moonPhase and foggyNight to be true to execute its code block.

Now, let's try out ||. Use || in place of the && that you wrote in the previous steps to make the if/else statement print 'Howwwlll!!!' if moonPhase is 'full' or if foggyNight is true.

Leave the moonPhase variable's value as 'full' and the foggyNight variable's value as false.
Stuck? Get a hint
5.
The first if statement's block was executed. That's because moonPhase is 'full', which is true. The || operator only needs one thing to be true in order to return true.

Click 'Next' to continue.


Before we move on, let's circle back to else if statements.

Using else if is a great tool for when we have a few different conditions we'd like to consider.

else if is limited however. If we want to write a program with 25 different conditions, like a JavaScript cash register, we'd have to write a lot of code, and it can be difficult to read and understand.

To deal with times when you need many else if conditions, we can turn to a switch statement to write more concise and readable code.

Note: To a computer, a switch statement and an if/else statement are the same, but a switch statement can be easier for other humans to read. Part of being a good developer is writing code that both computers and other humans can read.

switch statements look like this:

var groceryItem = 'papaya';

switch (groceryItem) {
  case 'tomato':
    console.log('Tomatoes are $0.49');
    break;
  case 'lime':
    console.log('Limes are $1.49');
    break;
  case 'papaya':
    console.log('Papayas are $1.29');
    break;
  default:
    console.log('Invalid item');
    break;
}
The switch keyword initiates the statement, and is followed by ( ... ), which contains the condition that each case will compare to. In the example, the condition is groceryItem.
Inside the block, { ... }, there are cases. case is like the else if part of an if/else if/else statement. The word following the first case is 'tomato'. If groceryItem equalled 'tomato', that case's console.log would run.
groceryItem equals 'papaya', so the first and second case statements are skipped. The third case runs since the case is 'papaya' matches groceryItem's value. This particular program will log out: 'Papayas are $1.29'.
Then the program stops with the break keyword. This keyword will prevent the switch statement from executing any more of its code.
At the end of each switch statement, there is a default condition. If none of the cases are true, then this code will run.
1.
Let's illustrate this by converting our werewolf program to a switch statement. For now, let's also delete the foggyNight variable so it doesn't fog up this concept.

moonPhase will become the condition of the switch statement. Then, each moon phase will become each case that the switch statement checks for.

Start by writing a switch statement with moonPhase as its condition.
Stuck? Get a hint
2.
Then, write each else if condition as a case.

If moonPhase is 'full', then use console.log to print 'Howwwwlll!!'.

If moonPhase is 'mostly full', then use console.log to print 'Arms and legs are getting hairier'.

If moonPhase is 'mostly new', then use console.log to print 'Back on two feet'.

Remember to add a break after each console.log, like in the example in the instructions.
Stuck? Get a hint
3.
Now, add a default at the end of the switch that uses console.log to print 'Invalid moon phase', in the case that moonPhase does not equal one of our cases.
Stuck? Get a hint
4.
Nice work! switch statements can make your code easier to read and easier for others to understand.


Way to go! We just learned a lot of control flow concepts:

if/else statements make binary decisions and execute separate code based on a condition.
We can add extra conditions with to if/else statements with else if conditions.
switch statements make complicated if/else statements easier to read, however they achieve the same result as if/else statements.
Comparison operators, like <, >, <=, and >= can compare two variables. After they compare, they always return either true or false.
Logical Operators, like &&, ||, !==, and !, can compare two variables to see if a certain condition exists:
&& checks if both sides are true.
|| checks if either side is true.
!== checks if both sides are not equal.
! changes a variable that is true to false, and vice versa.
In the next lesson, we'll learn about functions, and how to write blocks of code that are reusable.

A function is a block of code designed to perform a task.

Functions are like recipes. They take data or variables, perform a set of tasks on them, and then return the result. The beauty of functions is that they allow us to write a chunk of code once, then we can reuse it over and over without writing the same code over and over.

Take a look at this code:

var calculatorOn = false;

function pressPowerButton() {
  if (calculatorOn) {
    console.log('Calculator turning off.');
    calculatorOn = false;
  } else {
    console.log('Calculator turning on.');
    calculatorOn = true;
  }
}

pressPowerButton();
// Output: Calculator turning on.

pressPowerButton();
// Output: Calculator turning off.
This code turns the calculator on if it is currently off, and turns it off if the calculator is currently on.

See if you can figure out how this code works. In the next exercise, we'll walk through it line by line.


How does this code work?

var calculatorOn = false;

function pressPowerButton() {
  if (calculatorOn) {
    console.log('Calculator turning off.');
    calculatorOn = false;
  } else {
    console.log('Calculator turning on.');
    calculatorOn = true;
  }
}

pressPowerButton();
// Output: Calculator turning on.

pressPowerButton();
// Output: Calculator turning off.
On line 1, we have a variable named calculatorOn set to false. Our program starts with the calculator in the off position.
On line 3, there's a function named pressPowerButton. Functions follow this syntax:

• They begin with the JavaScript keyword function.

• After function comes the name of the function. pressPowerButton is the name of the function. Notice there are no spaces in the name and each new word is capitalized. This is a convention in the JavaScript community called camelCase.

• After the function's name, comes parentheses (). We'll learn about these in the next exercise.

• Finally, the function has a block of code it executes between the curly braces {}.
Inside the function is an if/else statement.
On the last few lines, we make the function run by writing pressPowerButton(). This term for this is calling the function. We call it with pressPowerButton(), and it runs all the code in the block of the function.
We executed the code in the block of the function twice without having to write it twice. Functions can make code reusable!
1.
Imagine you work at a pizza restaurant and you want to write a JavaScript program to take orders so you don't have to write them out by hand. You can write a function to perform this task!

Start by writing a function named takeOrder. Inside of its block, use console.log to print 'Order: pizza'.
Stuck? Get a hint
2.
Under the function, let's take an order.

Call the takeOrder function on the last line.
Stuck? Get a hint
3.
Nice work! Now let's make our program list what topping is on each pizza.

Click 'Next' to continue.


The calculator program should be able to perform a math operation on a number. We should be able to give a calculator a number, have it perform a task on it like multiplication, then print a result.

Currently, we have no way to give a function a number. To do this, we can use parameters. Parameters are variables that we can set when we call the function. For example:

function multiplyByThirteen(inputNumber) {
  console.log(inputNumber * 13);
}

multiplyByThirteen(9);
// Output: 117
We added inputNumber within the parentheses of the multiplyByThirteen function. inputNumber is a parameter.
Inside the multiplyByThirteen function, we use console.log to print the inputNumber by 13.
When we call the multiplyByThirteen function on the last lines, we set the inputNumber parameter. For instance, multiplyByThirteen(9) calls the multiplyByThirteen function, and sets inputNumber as 9. Then, inside the block of the multiplyByThirteen function, 9 is multiplied by 13, resulting in 117 printing to the console.
Note on terminology: inputNumber is a parameter, but when we call multiplyByThirteen(9), the 9 is called an argument. Therefore, arguments are provided when you call a function, and parameters receive arguments as their value. So, inputNumber is a parameter and its value is the argument 9, since we wrote multiplyByThirteen(9).
Parameters let us write logic inside functions that can be modified based on when we call the function, which will help make our functions more flexible.
1.
Let's include a parameter in the takeOrder function to make the orders we log to the console more descriptive.

Inside the parentheses of the takeOrder function, add a parameter named topping.
Stuck? Get a hint
2.
Now, let's include the topping parameter inside the takeOrder function.

Modify the console.log to interpolate the topping parameter to print a string like this:

Order: pizza topped with bacon
Stuck? Get a hint

3.
At the end of the program, modify the takeOrder function call to include an argument for topping.




Great work. Now, what if we want to select one item from an array?

Luckily, each item in an array has a numbered position. We can access an item using its number, just like we would in an ordinary list. There’s one catch though!

JavaScript counts starting from 0, not 1, so the first item in an array will be at position 0. This is because JavaScript is zero-indexed.

We can select the first item in an array like this:

var bucketList = ['Rappel into a cave', 'Take a falconry class', 'Learn to juggle'];
var listItem = bucketList[0];
console.log(listItem);
// Output: 'Rappel into a cave'
If we wanted the second item, we'd write:

var bucketList = ['Rappel into a cave', 'Take a falconry class', 'Learn to juggle'];
var listItem = bucketList[1];
console.log(listItem);
// Output: 'Take a falconry class'


First, push() allows us to add items to the end of an array. Here is an example of how this is used:

var bucketList = ['item 0', 'item 1', 'item 2'];

bucketList.push('item 3', 'item 4');
The method push() would make the bucketList array look like:

['item 0', 'item 1', 'item 2', 'item 3', 'item 4'];
Check out how push() works here:

It connects to bucketList with a period.
Then we call it like a function. That's because push() is a function and one that JavaScript allows us to use right on an array.
Connecting a function like this is common in JavaScript. Think: we've been connecting .log to console this whole time!


Now that we can push() items into an array, let's pop one off, using pop().

pop() is similar to push(), except that it deletes the last item of an array. Here's an example:

var bucketList = ['item 0', 'item 1', 'item 2'];

bucketList.pop();

console.log(bucketList); 
// Output: [ 'item 0', 'item 1' ]
Notice that 'item 2' was deleted from the end.



var vacationSpots = ['Ireland', 'Italy', 'London'];

for (var i = vacationSpots.length-1; i >= 0; i--) {
  console.log('I would love to visit ' + vacationSpots[i]);
}

var myPlaces  = ['Ireland', 'Italy', 'London'];
var friendPlaces  = ['Portugal', 'France', 'London'];

for(var i=0; i < myPlaces.length; i++){
  console.log(myPlaces[i]);
  for(var j=0; j < friendPlaces.length; j++){
    if(myPlaces[i] === friendPlaces[j]){
      console.log(friendPlaces[j]);
    }
	}
}


var cards = ['Diamond', 'Spade', 'Heart', 'Club'];
var currentCard = 'Heart';

while (currentCard !== 'Spade') {
  console.log(currentCard);

  var randomNumber = Math.floor(Math.random() * 4);

  currentCard = cards[randomNumber];
}



var cards = ['Diamond', 'Spade', 'Heart', 'Club'];
var currentCard = 'Heart';

while (currentCard !== 'Spade') {
  console.log(currentCard);

  var randomNumber = Math.floor(Math.random() * 4);

  currentCard = cards[randomNumber];
}
console.log('Found a Spade!');

