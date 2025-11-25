using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class SieveOfEratosthenes
    {
    }
}
/*
 * 
function sieveOfEratosthenes(n) {
  // return all prime numbers up to num in an array
  var primes = [];
  for (var i=0; i<=n; i++){
    primes[i] = true;
  }
  primes[0] = false;
  primes[1] = false;

  for(var i=2; i<=Math.sqrt(n); i++){
    for(var j=2; j*i <=n; j++){
      // console.log("i:", i,"j:", j);
      primes[i*j] = false;
    }
  }

  var result = [];
  for(var i=0; i<=primes.length; i++){
    if(primes[i] == true){
      result.push(i);
    }
  }
  return result;
}
console.log(sieveOfEratosthenes(20));
*/