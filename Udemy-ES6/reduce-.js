function Fn_reduce_0(){
    //reduce() Use it when: You want a total based on values in an array.
    const euros = [29.76, 41.85, 46.5];
    const sum = euros.reduce((total, amount) => total + amount, 0);
    sum // 118.11

    //What it does: Reduce invokes a function (in this case, total + amount) on each amount in an array. 
    //For reduce to work, it must start with an initial total value (in this case 0) to add the first amount to . 
    //When the method reduces all the values it returns the total value.
}
function Fn_reduce(){
    /*
    The reduce() method reduces the array to a single value.
    The reduce() method executes a provided function for each value of the array (from left-to-right).
    The return value of the function is stored in an accumulator (result/total).
    Note: reduce() does not execute the function for array elements without values.

    array.reduce(function(total, currentValue, currentIndex, arr), initialValue)

    total	Required. The initialValue, or the previously returned value of the function
    currentValue	Required. The value of the current element
    currentIndex	Optional. The array index of the current element
    arr	Optional. The array object the current element belongs to
    initialValue	Optional. A value to be passed to the function as the initial value
    */
    var numbers = [10, 20, 30];
    var sum = 0;
    
    sum = numbers.reduce(function(sum, n, idx){ // n is the element in the array
        //console.log(idx);
        return sum + n;
    }, 0);
    
    console.log(sum);

    var numbers = [15.5, 2.3, 1.1, 4.7];

    var res = numbers.reduce(function getSum(total, num) {
        return total + Math.round(num);
    }, 0);
    console.log(res);
}
function Fn_reduce_push(){
    var pColors = [
        {color: 'red'},
        {color: 'green'},
        {color: 'blue'},
    ];

    var c = pColors.reduce(function(prev, p){
        prev.push(p.color);
        return prev;
    }, []);

    console.log(c);
}
function Fn_balanceParentesis(){

    function balancePar(string){
        return !string
            .split("")
            .reduce(function(prev, char){
                if(prev < 0) {return prev; }
                if(char ==="(") {return ++prev; }
                if(char ===")") {return --prev; }
                return prev;
            }, 0);
    }

    console.log(balancePar("(())")); //t
    console.log(balancePar("((()")); //f
    console.log(balancePar(")(")); //f
    console.log(balancePar("()()")); //t
    console.log(balancePar(")(()())("));//f
}
function Fn_reduce_object(){

    var trips = [{ distance: 34 }, { distance: 12 } , { distance: 1 }];

    var totalDistance = trips.reduce(function(acc, curr) {
        return acc + curr.distance;
    }, 0);

    console.log(totalDistance);

    var desks = [
        { type: 'sitting' },
        { type: 'standing' },
        { type: 'sitting' },
        { type: 'sitting' },
        { type: 'standing' }
    ];
    
    var deskTypes = desks.reduce(function(acc, curr) {
        console.log(curr);
        console.log(acc);
        ++acc[curr.type];
        return acc;
    }, { sitting: 0, standing: 0 });

    console.log(deskTypes);


}
function Fn_reduce_unique(){
    var numbers = [1,1,2,3,4,4]; // return [1,2,3,4]

    function unique(array) {
        return array.reduce(function(acc, curr) {
            if (acc.indexOf(curr) === -1) {
                acc.push(curr);
            }
            return acc;
        }, []);
    }

    console.log(unique(numbers));
}
