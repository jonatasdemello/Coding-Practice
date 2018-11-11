
function Fn_keys(){

    const object1 = {
        a: 'somestring',
        b: 42,
        c: false
      };
      
    console.log(Object.keys(object1));
    // expected output: Array ["a", "b", "c"]

    // simple array
    var arr = ['a', 'b', 'c'];
    console.log(Object.keys(arr)); // console: ['0', '1', '2']

    const object2 = {
        a: 1,
        b: 2,
        c: 3
      };
      
    console.log(Object.getOwnPropertyNames(object2));
    // expected output: Array ["a", "b", "c"]
 
    var arr = ['a', 'b', 'c'];
    console.log(Object.getOwnPropertyNames(arr).sort()); 
    // logs ["0", "1", "2", "length"]

    // Logging property names and values using Array.forEach
    Object.getOwnPropertyNames(obj).forEach(
        function (val, idx, array) {
        console.log(val + ' -> ' + obj[val]);
        }
    );
    // logs
    // 0 -> a
    // 1 -> b
    // 2 -> c

}
function Fn_find_keys(){

    var ladders = [
        {id: 1, height: 20},
        {id: 2, height: 30},
        {id: 3, height: 25},
    ];

    function findWhere(array, criteria) {
        return array.find(function(a){
            var prop = Object.keys(criteria)[0];
            return a[prop] === criteria[prop];
        });
    }

    console.log(findWhere(ladders, {height: 25})) // {height: 25, id: 3}

    var prop = Object.keys({height: 25, id:10, name:'test'});
    console.log(prop); // ["height", "id", "name"]
    console.log(prop[0]);  // height
}
