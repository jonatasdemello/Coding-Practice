console.log('------------- destructuring');

var expense = {
  type: 'Business',
  amount: '$45 USD'
};
// const type = expense.type;
// const amount = expense.amount;
// or
// const {type} = expense;
// const {amount} = expense;

{ // normal
  console.info("------------- normal:");
  
  let type = expense.type;
  let amount = expense.amount;

  console.log("fist:", type, amount);

  function show(expense) {
    console.log("type: ", expense.type);
    console.log("amount: ", expense.amount);
  }
  show(expense);
}
// or
{
  console.info("------------- destructuring:");
  
  function show({ type }) {
    console.log("type: ", type);
  }
  show(expense);
  // var name has to match ther property name!
  
  let { type, amount } = expense;
  
  console.log("second: ", type, amount);
  
  let { myType } = expense;
  
  console.log("undefined: ", myType); // undefined because myType does not exist
}

console.log('------------- arguments-object');
// get by property name
var savedFile = {
  ext: 'jpg',
  name: 'repost',
  size: 14040
};

function fileSummary0(file) {
  return `Summary 0: the file ${file.name}.${file.ext} is of size ${file.size}`;
}
//ES6
function fileSummary1({ name, ext, size }) {
  return `Summary 1: the file ${name}.${ext} is of size ${size}`;
}

function fileSummary2({ name, ext, size }, { color }) {
  return `Summary 2: ${color} the file ${name}.${ext} is of size ${size}`;
}
console.log(fileSummary0(savedFile));
console.log(fileSummary1(savedFile));
console.log(fileSummary2(savedFile, { color: 'Red'}));


console.log('------------- arrays');
// get items from the array
const companies = ['Google', 'Facebook', 'Uber'];

let [name] = companies;
console.log(name); // same as companies[0] = Google

// use [] to get items and {} to get properties
let { length } = companies; // name is not a property
console.log(length); // = 3

let [name1, name2, name3] = companies;
console.log(name1, name2, name3);

let [nameA, nameB, nameC, nameD] = companies;
console.log(nameA, nameB, nameC, nameD); // nameD is undefined

let [first, ...rest] = companies;
console.log("first: ", first, "and rest:", rest);


console.log('------------- arrays-objects');

const companiesObj = [{
    name: 'Google',
    location: "Montain View"
  },
  {
    name: 'Facebook',
    location: "Menlo Park"
  },
  {
    name: 'Uber',
    location: "San Francisco"
  }
];
console.log(companiesObj[1].location);
{
  let [location] = companiesObj;
  console.log("location1: ", location); // {name: "Google", location: "Montain View"}
}
// or destructuring both arrays-objects
{
  let [{  location }] = companiesObj;
  console.log("location1: ", location); // Montain View only
}

const Google = {
  locations: ["Montain View", "New York", "London"]
};
console.log("Google obj: ", Google);

let { locations } = Google;
console.log("property locations: ", locations); // ["Montain View", "New York", "London"]

let { locations: locationArray } = Google;
console.log("locations Array: ", locationArray); // ["Montain View", "New York", "London"]

let { locations: [location] } = Google;
console.log("first element location: ", location); // Montain View




console.log('------------- when-to-use');

function signup0(username, password) {
  console.log("signup0: ", username, password); // simple variable
}
signup0('myname0', 'mypassword0');

function signup1({ username, password }) {
  console.log("signup1: ", username, password);
}

function signup2({ username, password, email }) {
  console.log("signup2: ", username, password, email);
}
const user = {
  username: "myname",
  password: "pass",
  email: "my@gmail.com"
}
signup1(user);
signup2(user);


console.log('------------- array-destructuring');

// have an array of arrays
const points = [
  [4, 5],
  [1, 2],
  [3, 7]
];
// but we need an array of objects
let mypoints = [
  { x: 1, y: 2 },
  { x: 0, y: 0 }
];

let pt1 = points.map(pair => {
  //console.log("x:", pair[0], "y:", pair[1]); 
  const [x, y] = pair;
  return { x: x, y: y };
});
console.log("pt1", pt1);

// or
let pt2 = points.map(([x, y]) => { // destructuring in the argument list
  return { x: x, y: y };
});
console.log("pt2", pt2);

let pt3 = points.map(([x, y]) => {
  return { x, y }; // simplify with object literal sintax
});
console.log("pt3", pt3);


console.log('------------- samples');

  const profile = {
    title: 'Engineer',
    department: 'Engineering'
  };

  function isEngineer0(profile) {
    var title = profile.title;
    var department = profile.department;
    return title === 'Engineer' && department === 'Engineering';
  }

  function isEngineer(profile) {
    let { title, department } = profile;
    return title === 'Engineer' && department === 'Engineering';
  }

  const classes = [
    ['Chemistry', '9AM', 'Mr. Darnick'],
    ['Physics', '10:15AM', 'Mrs. Lithun'],
    ['Math', '11:30AM', 'Mrs. Vitalis']
  ];

  //let [class0] = classes;
  //console.log(class0); // ["Chemistry", "9AM", "Mr. Darnick"]

  //let [ subject, time, teacher ] = classes;
  //console.log(subject, time, teacher);

  let classesAsObject = classes.map(([subject, time, teacher]) => {
    return { subject, time, teacher };
  });
  console.log(classesAsObject);



const numbers = [1, 2, 3];

function double(arr) {
  return arr.map(num => num * 2);
}
console.log(numbers, double([1, 2, 3]));
