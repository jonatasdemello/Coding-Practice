// O(lon n)
function binarySearch(numArray, key){
  var size = numArray.length;
  var middleIndex = Math.floor(size / 2);
  var middleElem = numArray[middleIndex];

  if(middleElem === key){
    return true;
  }
  else if(middleElem < key && size > 1) {
    return binarySearch(numArray.splice(middleIndex, size), key);
  }
  else if(middleElem > key && size > 1) {
    return binarySearch(numArray.splice(0, middleIndex), key);
  }
  else 
    return false;
}

var arr = [5,7,12,16,36,39], sum = 56;
var res = binarySearch(arr,sum);
console.log(res);

var arr = [4,11,19,27,31], sum = 13;
var res = binarySearch(arr,sum);
console.log(res);
