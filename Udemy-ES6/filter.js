function Fn_filter_0(){
    // filter() Use it when: You want to remove unwanted values from an array.

    const euros = [29.76, 41.85, 46.5];
    const above30 = euros.filter(euro => euro >= 30);
    above30 // [ 41.85, 46.5]

    // What it does: Filter invokes a function (in this case, euro >= 30) on each amount in an array. 
    // When the method has filtered all the values it returns a new array with all values that returned true.
}
function Fn_map_filter(){

    /*
    The filter() method creates an array filled with all array elements that pass a test (provided as a function).
    Note: filter() does not execute the function for array elements without values.
    Note: filter() does not change the original array.

    array.filter(function(currentValue, index, arr), thisValue)
        currentValue	Required. The value of the current element
        index	Optional. The array index of the current element
        arr	Optional. The array object the current element belongs to
        thisValue	Optional. A value to be passed to the function to be used as its "this" value.
                    If this parameter is empty, the value "undefined" will be passed as its "this" value
    */
    var cars = [
        {model: 'Buick', price: 'cheap'},
        {model: 'Audi', price: 'expensive'},
        {model: 'Ford', price: 'average'},
        {model: 'GM', price: 'cheap'}
    ];

    // return an array with prices
    var prices = cars.map(function(c){
        return c.price;
    });

    // return an aray filtered
    var cheap = cars.filter(function(c){
        return c.price === 'cheap';
    });

    console.log(prices);
    console.log(cheap);
}
function Fn_filter(){
    /*
    array.filter(function(currentValue, index, arr), thisValue)
    currentValue	Required. The value of the current element
    index	Optional. The array index of the current element
    arr	Optional. The array object the current element belongs to
        thisValue	Optional. A value to be passed to the function to be used as its "this" value.
                    If this parameter is empty, the value "undefined" will be passed as its "this" value
    */
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
}
