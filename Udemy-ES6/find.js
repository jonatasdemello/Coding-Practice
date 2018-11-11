function Fn_find(){

/*
	array.find(function(currentValue, index, arr),thisValue)
        currentValue	Required. The value of the current element
        index	Optional. The array index of the current element
        arr	Optional. The array object the current element belongs to
        thisValue	Optional. A value to be passed to the function to be used as its "this" value.
                    If this parameter is empty, the value "undefined" will be passed as its "this" value
*/

    var users = [
        {name: 'Jill'},
        {name: 'Jack', id:2},
        {name: 'Bill'},
        {name: 'Jack'},
    ];

    var u = users.find(function(u){
        return u.name ==='Jack';
    });

    console.log(u);
}