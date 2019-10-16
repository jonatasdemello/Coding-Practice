function mergeSort(arr) {
  // take a single array and split into two halves
  if(arr.length < 2)
    return arr;

  var midIdx = Math.floor(arr.length /2);
  var firstHalf = arr.slice(0, midIdx);
  var secondHalf = arr.slice(midIdx);

  return merge(mergeSort(firstHalf), mergeSort(secondHalf));
}
function merge(arr1, arr2){
  // takes 2 sorted arrays and merge into one
  var result = [];

  while(arr1.length && arr2.length){
    var minElem;
    if(arr1[0] < arr2[0]) {
      minElem = arr1.shift();
    }
    else {
      minElem = arr2.shift();
    }
    result.push(minElem);
  }
  if (arr1.length) {
    result = result.concat(arr1);
  }
  if (arr2.length) {
    result = result.concat(arr2);
  }
  return result;
}
console.time('mergeSort');
console.log(mergeSort([10,2,1,3,5,4,6,50,1,45,34,17,59,70,100,-1,-50]));
console.timeEnd('mergeSort');

// merge 2 sorted arrays
console.log(merge([1,3,5],[2,4,6]));
