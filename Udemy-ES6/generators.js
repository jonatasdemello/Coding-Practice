
function* generator(i) {
  yield i;
  yield i + 10;
}

var gen = generator(10);

console.log(gen.next().value);
// expected output: 10

console.log(gen.next().value);
// expected output: 20

// {value: undefined, done: true}.

function* makeRangeIterator(start = 0, end = Infinity, step = 1) {
  let iterationCount = 0;
  for (let i = start; i < end; i += step) {
      iterationCount++;
      yield i;
  }
  return iterationCount;
}
//{done: true}

//function Fn_Generators_0(){

    function* colors(){
      console.log("---red")
      yield 'red';

      console.log("---blue")
      yield 'blue';

      console.log("---green")
      yield 'green';

      console.log("---fim")
    }

    var c = colors();
    console.log(c.next().value);
    console.log(c.next(0).value);
    console.log(c.next().value);

    const myColors = [];
    for (let c of colors()){ 
        //console.log(JSON.parse(JSON.stringify(c)));
        //console.log(c);
        //console.log(typeof c);
        myColors.push(c);
    }
    console.log(myColors);

    c = colors();
    console.log(c);

    //console.log("---using forEach()")
    // const myColors1 = [];
    // const cl = colors();
    // cl.forEach(function(c){
    //     myColors1.push(c);
    // });
    // console.log(myColors1);

//}
function Fn_Generators_1(){

    const engineeringTeam = {
        size: 3,
        department: 'Engineering',
        lead: 'Jill',
        manager: 'Alex',
        engineer: 'Dave'
    };

    function* TeamIterator(team){
        yield team.lead;
        yield team.manager;
        yield team.engineer;
    }

    const names = [];
    for (let name of TeamIterator(engineeringTeam)){
        names.push(name);
    }
    console.log(names);
}
function Fn_Generators_2(){

    const testingTeam = {
        lead: 'Amanda',
        tester: 'Bill'
    };
    const engineeringTeam = {
        testingTeam,
        size: 3,
        department: 'Engineering',
        lead: 'Jill',
        manager: 'Alex',
        engineer: 'Dave'
    };

    function* TeamIterator(team){
        yield team.lead;
        yield team.manager;
        yield team.engineer;
        const testingTeamGenerator = TestingTeamIterator(team.testingTeam);
        yield* testingTeamGenerator;
    }

    function* TestingTeamIterator(team){
        yield team.lead;
        yield team.tester;
    }

    const names = [];
    for (let name of TeamIterator(engineeringTeam)){
        names.push(name);
    }
    console.log(names);
}

function Fn_Generators_3(){

    const testingTeam = {
        lead: 'Amanda',
        tester: 'Bill' ,
        [Symbol.iterator]: function* () {
            yield this.lead;
            yield this.tester;
            yield 5;
        }
    };
    const engineeringTeam = {
        testingTeam,
        size: 3,
        department: 'Engineering',
        lead: 'Jill',
        manager: 'Alex',
        engineer: 'Dave'
    };

    function* TeamIterator(team){
        yield team.lead;
        yield team.manager;
        yield team.engineer;
        yield* team.testingTeam;
    }

    const names = [];
    for (let name of TeamIterator(engineeringTeam)){
        names.push(name);
    }
    console.log(names);
}
function Fn_Generators_4(){

    const testingTeam = {
        lead: 'Amanda',
        tester: 'Bill' ,
        [Symbol.iterator]: function* () {
            yield this.lead;
            yield this.tester;
            yield 2;
        }
    };
    const engineeringTeam = {
        testingTeam,
        size: 3,
        department: 'Engineering',
        lead: 'Jill',
        manager: 'Alex',
        engineer: 'Dave',
        [Symbol.iterator]: function* () {
            yield this.lead;
            yield this.manager;
            yield this.engineer;
            yield 3;
            yield* this.testingTeam;
        }
    };

    const names = [];
    for (let name of engineeringTeam){
        names.push(name);
    }
    console.log(names);
}

//Fn_Generators_0();



// Recursion 

class Comment {
  constructor(content, children){
    this.content = content;
    this.children = children;
}
// Array Helpers (map & foreach) doesn't work inside iterators
*[Symbol.iterator](){
    yield this.content;
    for (let child of this.children) {
        yield* child;
    }
}
}

const children = [
new Comment('good',[]),
new Comment('bad',[]),
new Comment('ugly',[])
];
const tree = new Comment('New Post!', children);
console.log(tree);

const values = [];
for(let value of tree){
values.push(value);
}
console.log('values: ', values);
