using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class ReverseArrayInPlace
    {
    }
}
/*
function reverseArrayInPlace(arr){
  if(arr == undefined || arr.length < 2){
    return arr;
  }
  for(var i=0; i<arr.length / 2; i++){
    var tempVar = arr[i];
    arr[i] = arr[arr.length - 1 - i];
    arr[arr.length - 1 - i] = tempVar;
  }
}

var res = [1,2,3,4,5]
reverseArrayInPlace(res);
console.log(res);

res = [1,2,3,4]
reverseArrayInPlace(res);
console.log(res);

res = [1]
reverseArrayInPlace(res);
console.log(res);

res = []
reverseArrayInPlace(res);
console.log(res);


function reverseArrayInPlace_v1(arr){
  var tmpArr = [];
  for(var i=arr.length-1; i>=0; i--){
    tmpArr.push(arr[i]);
  }
  for(var i=0; i<arr.length; i++){
    arr[i] = tmpArr[i];
  }
}
*/