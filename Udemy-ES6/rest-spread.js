function Fn_rest_spread(){

    function addNumbers(numbers){
        return numbers.reduce( (sum, n) => {
            return sum + n;
        }, 0)
    }
    console.log(addNumbers([1,2,3,4,5]));
    console.log('using spread');


    function addNumbers1(...numbers){ // unknown number of args: (a,b,c,d)
        // let numbers = [a,b,c,d];
        return numbers.reduce( (sum, n) => {
            return sum + n;
        }, 0)
    }
    console.log(addNumbers1(1,2,3,4,5));
    console.log(addNumbers1(1,2,3,4,5,6,7,8,9));
 
    const colors1 = ['red', 'green'];
    const colors2 = ['blue', 'yellow'];
    let c1 = colors1.concat(colors2);
    // or
    let c2 = [...colors1, ...colors2];
    let c3 = ['other', ...colors1, ...colors2];
    console.log('concat: ',c1);
    console.log('spread: ',c2);

    function validateShoppingList(...items){
        if(items.indexOf('milk') < 0 ){
            return ['milk', ...items];
        }
        return items;
    }
    console.log(validateShoppingList('bread','eggs'));

    function product1(a, b, c, d, e) {
        var numbers = [a,b,c,d,e];
        
        return numbers.reduce(function(acc, number) {
          return acc * number;
        }, 1)
      }
      //or
      function product2(...numbers) {
        return numbers.reduce( (acc, number) => {
          return acc * number;
        }, 1)
      }
      
      function join(array1, array2) {
        return array1.concat(array2);
      }
      function join1(array1, array2) {
        return [...array1, ...array2];
      }

      function unshift(array, a, b, c, d, e) {
        return [a, b, c, d, e].concat(array);
      }
      function unshift(array, ...items) {
        return [...items, ...array];
      }


    const MathLib = {
        calcProduct(...rest){
            console.log('use method multiply instead');
            return this.multiply(...rest);
        },
        multiply(a,b){
            return a*b;
        }
    };

}
