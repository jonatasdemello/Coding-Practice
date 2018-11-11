function Fn_Destructuring_0(){
    var expense = {
        type: 'Business',
        amount: '$45'
    };
    
    {// normal
        console.info("normal:");
        let type = expense.type;
        let amount = expense.amount;
        console.log("fist:" , type, amount);

        function show(expense){
            console.log("type: ", expense.type);
            console.log("amount: ", expense.amount);
        }
        show(expense);
    }
    // or
    {
        console.info("Destructuring:");
        function show({ type }){
            console.log("type: ", type);
        }
        show(expense);

        //const {type} = expense;
        //const {amount} = expense;
        // var name has to match ther property name!
        let { type, amount } = expense;
        console.log("second: ", type, amount);
        
        let { myType } = expense;
        console.log("undefined: ", myType); // undefined because myType does not exist
    }
    
}
function Fn_Destructuring_1(){
    var savedFile = {
        ext: 'jpg',
        name: 'repost',
        size: 14040
    };
    function fileSummary(file){
        return `Summary 0: the file ${file.name}.${file.ext} is of size ${file.size}`;
    }
    //ES6
    function fileSummary1( { name, ext, size } ){
        return `Summary 1: the file ${name}.${ext} is of size ${size}`;
    }
    function fileSummary2( { name, ext, size }, {color} ){
        return `Summary 2: ${color} the file ${name}.${ext} is of size ${size}`;
    }
    console.log(fileSummary(savedFile));
    console.log(fileSummary1(savedFile));
    console.log(fileSummary2(savedFile, {color: 'Red'}));
}
function Fn_Destructuring_2(){
    const companies = ['Google', 'Facebook', 'Uber'];

    let [ name ] = companies;
    console.log(name);

    let [ name1, name2, name3 ] = companies;
    console.log(name1, name2, name3);

    let [ nameA, nameB, nameC, nameD ] = companies;
    console.log(nameA, nameB, nameC, nameD);

    let [ first, ...rest ] = companies;
    console.log(first, "and,", rest);
}
function Fn_Destructuring_3(){
    const companies = [
        {name: 'Google', location:"Montain View"}, 
        {name: 'Facebook', location:"Menlo Park"}, 
        {name: 'Uber', location: "San Francisco"}
    ];
    console.log(companies[1].location);

    let [ obj ] = companies;
    console.log(obj); // {location: "Montain View", name: "Google"}

    let [ { location } ] = companies;
    console.log(location); // Montain View only

    const Google = {
        locations: ["Montain View", "New York", "London"]
    };
    //console.log(Google);

    let  { locations: lc } = Google;
    console.log("lc", lc); // ["Montain View", "New York", "London"]

    let  { locations: [loc] } = Google;
    console.log("loc:", loc); //Montain View

    
}
function Fn_Destructuring_4(){
    function signup( { username, password }) {
        console.log(username, password)
    }
    function signup1( { username, password, email }) {
        console.log(username, password, email)
    }
    const user = {
        username: "myname",
        password: "pass",
        email: "my@gmail.com"
    }
}
function Fn_Destructuring_5(){
    const points = [
        [4,5],
        [1,2],
        [3,7]
    ];
    let mypoints = [
        {x: 1, y: 2},
        {x: 0, y: 0}
    ];
    let pt1 = points.map(pair => {
        //console.log(pair[0], pair[1]); 
        const [x, y] = pair;
        return { x: x, y: y };
    });
    console.log("pt1", pt1);

    let pt2 = points.map(([x ,y]) => {
        return { x: x, y: y };
    });
    console.log("pt2", pt2);

    let pt3 = points.map(([x ,y]) => {
        return { x, y }; //object literal sintax
    });
    console.log("pt3", pt3);
}
function Fn_Destructuring_6(){
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
        [ 'Chemistry', '9AM', 'Mr. Darnick' ],
        [ 'Physics', '10:15AM', 'Mrs. Lithun'],
        [ 'Math', '11:30AM', 'Mrs. Vitalis' ]
      ];
      
    //let [class0] = classes;
    //console.log(class0); // ["Chemistry", "9AM", "Mr. Darnick"]

    //let [ subject, time, teacher ] = classes;
    //console.log(subject, time, teacher);

    let classesAsObject = classes.map( ([ subject, time, teacher ]) => {
        return {subject, time, teacher};
    });
    console.log(classesAsObject);
      
}
function Fn_Destructuring_7(){
    const numbers = [1, 2, 3];

    function double(arr) {
        return arr.map(num => {
            return num * 2;
        });
    }
    console.log(double([1,2,3]));
}
