// The filter() method creates a new array with all elements that pass the test implemented by the provided function.

// filter() Use it when: You want to remove unwanted values from an array.
// Note: filter() does not execute the function for array elements without values.
// Note: filter() does not change the original array.


var words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];
const result = words.filter(word => word.length > 6);
console.log('word.length > 6:', result);  // expected output: Array ["exuberant", "destruction", "present"]


console.log('------------- filter');
const euros = [29.76, 41.85, 46.5];
const above30 = euros.filter(euro => euro >= 30);
console.log('above-30:', above30); // [ 41.85, 46.5]


console.log('------------- cheap cars');
var cars = [
  {model: 'Buick', price: 'cheap'},
  {model: 'Audi', price: 'expensive'},
  {model: 'Ford', price: 'average'},
  {model: 'GM', price: 'cheap'}
];
// return an array filtered
var cheap = cars.filter(function(c){
  return c.price === 'cheap';
});
console.log(cheap);


console.log('------------- posts');
var post = {id: 4, title:'New Post'};

var comments = [
  {postId: 4, content: 'awesome'},
  {postId: 3, content: 'ok'},
  {postId: 4, content: 'nice'}
];

function commentsForPost(post, comments) {
  return comments.filter(function(c){
    return c.postId == post.id;
  })
};

console.log(commentsForPost(post, comments));

