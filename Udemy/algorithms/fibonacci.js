// O(2^n)
function fibonacci(position){
  if (position < 3) return 1;
  else return (fibonacci(position-1) + fibonacci(position-2));
}
console.log(fibonacci(1));
console.log(fibonacci(2));
console.log(fibonacci(4));
console.log(fibonacci(20));
//console.log(fibonacci(40));

// O(n)
function fibMemo(index, cache) {
  cache = cache || [];
  if (cache[index]) return cache[index];
  else {
    if (index < 3) return 1;
    else {
      cache[index] = fibMemo(index - 1, cache) + fibMemo(index - 2, cache);
    }
  }
  return cache[index];
}
console.log(fibMemo(4));
console.log(fibMemo(20));


// Recursive
function fib(n) {
  return n<2?n:fib(n-1)+fib(n-2);
}
// Can be rewritten as:
function fib(n) {
 if (n<2) { return n; } else { return fib(n-1)+fib(n-2); }
}

// Iterative
function fib(n) {
  var a = 0, b = 1, t;
  while (n-- > 0) {
    t = a;
    a = b;
    b += t;
    console.log(a);
  }
  return a;
}

// Memoization
// With the keys of a dictionary,
var fib = (function(cache){
    return cache = cache || {}, function(n){
        if (cache[n]) return cache[n];
        else return cache[n] = n == 0 ? 0 : n < 0 ? -fib(-n)
            : n <= 2 ? 1 : fib(n-2) + fib(n-1);
    };
})();

// with the indices of an array
(function () {
    'use strict';
    function fib(n) {
        return Array.apply(null, Array(n + 1))
            .map(function (_, i, lst) {
                return lst[i] = (
                    i ? i < 2 ? 1 :
                    lst[i - 2] + lst[i - 1] :
                    0
                );
            })[n];
    }
    return fib(32);
})();
