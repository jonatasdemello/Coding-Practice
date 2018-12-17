// The find() method returns the value of the first element in the array that satisfies the provided testing function. Otherwise undefined is returned.

// findIndex() method, which returns the index of a found element in the array instead of its value.

var array1 = [5, 12, 8, 130, 44];
var found = array1.find(function(element) {
  return element > 10;
});
console.log(found); // expected output: 12


var users = [
    {name: 'Jill'},
    {name: 'Jack', id: 2},
    {name: 'Bill'},
    {name: 'Jack'},
];
console.log('------------- for');
var user1;
for (let i = 0; i < users.length; i++) {
  if(users[i].name === 'Bill') {
    user1 = users[i];
    break;
  }
}
console.log('user1:', user1)

console.log('------------- find');
var user2;
var user2 = users.find(function(u){
    return u.name === 'Jack';
});
console.log('user2:', user2)


console.log('------------- find');
var ladders = [
  { id: 1, height: 20 },
  { id: 3, height: 25 }
];

function findWhere(array, criteria) {
  return array.find(function(a){
    var property = Object.keys(criteria)[0];
    return a[property] === criteria[property];
}); 
}

var res = findWhere(ladders, {height: 25});
console.log(res);
