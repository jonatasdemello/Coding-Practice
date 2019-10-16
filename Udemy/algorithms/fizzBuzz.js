// O(n)
function fizzBuzz(num) {

  for(var i=0; i<num; i++) {
    var res = "";
    if(i % 3 == 0){
      res += "Fizz";
    }
    if(i % 5 ==0 ){
      res += "Buzz";
    }
    if(res=="")
      console.log(i);
    else
      console.log(res);
  }

}

fizzBuzz(20);


// or
function fizzBuzz_v1(num) {
  for (var i = 1; i <= num; i++) {
    if (i % 15 === 0) console.log('FizzBuzz');
    else if (i % 3 === 0) console.log('Fizz');
    else if (i % 5 === 0) console.log('Buzz');
    else console.log(i);
  }
}


