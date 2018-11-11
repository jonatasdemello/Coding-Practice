function Fn_forEach(){

    // forEach() — executes a provided function once for each array element.

    // the forEach() method doesn’t actually return anything (undefined). 
    // It simply calls a provided function on each element in your array. 
    // This callback is allowed to mutate the calling array.

    var colors = ['red', 'green', 'blue'];

    for(var i=0; i<colors.length; i++) {
        console.log(colors[i]);
    }

    colors.forEach(function(c){
        console.log(c);
    });

    let arr = [1, 2, 3, 4, 5];

    console.log(arr);
    arr.forEach((num, index) => {
        arr[index] = num * 2;
    });
    console.log(arr);

    let doubled = arr.map(num => {
        return num * 2;
    });
    console.log(doubled);
}