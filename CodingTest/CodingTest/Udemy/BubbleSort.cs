using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class BubbleSort
    {
    }
}
/*
function bubbleSort(array) {
  for(var i=array.length; i>0; i--){
    for(var j=0; j<i; j++) {
      //console.log("i:", i,"j:", j);
      if(array[j] > array[j+1]){
        var tmp = array[j];
        array[j] = array[j+1];
        array[j+1] = tmp;
      }
    }
  }
  return array;
}

console.time('bubbleSort');
console.log(bubbleSort([10,2,1,3,5,4,6,50,1,45,34,17,59,70,100,-1,-50]));
console.timeEnd('bubbleSort');


console.time('bubbleSort1');
console.log(bubbleSort1([10,2,1,3,5,4,6,50,1,45,34,17,59,70,100,-1,-50]));
console.timeEnd('bubbleSort1');

//console.log(bubbleSort([10,2,1,3,5,4,6]));

function bubbleSort1(array) {
  for(var i=array.length; i>0; i--){
    for(var j=0; j<i; j++) {
      //console.log("i:", i,"j:", j);
      if(array[j] > array[i]){
        var tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
      }
    }
  }
  return array;
}
*/
