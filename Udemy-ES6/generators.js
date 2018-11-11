
function Fn_Generators_0(){

    function* colors(){
        yield 'red';
        yield 'blue';
        yield 'green';
    }

    const myColors = [];
    for (let c of colors()){ 
        myColors.push(c);
    }
    console.log(myColors);

    console.log("---using forEach()")

    const myColors1 = [];
    const cl = colors();
    cl.forEach(function(c){
        myColors1.push(c);
    });
    console.log(myColors1);

}
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
F_Generators_4();

