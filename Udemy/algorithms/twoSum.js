// this is O(n)
function twoSum(numArray, sum){
  // Returns every pair of numbers from 'numArray' that adds up to the 'sum'
  var pairs = [];
  var hashtable = [];

  for(var i=0; i<numArray.length; i++)
  {
    var currNum = numArray[i];
    var counterpart = sum - currNum;
    if(hashtable.indexOf(counterpart) !== -1){
      pairs.push([currNum, counterpart]);
    }
    hashtable.push(currNum);
  }
  return pairs;
}

// this is O(n^2)
function twoSum2(numArray, sum){
  // Returns every pair of numbers from 'numArray' that adds up to the 'sum'
  var pairs = [];

  for(var i=0; i<numArray.length; i++)
  {
    for(var j=0; j<numArray.length; j++)
     {
      if(sum === numArray[i] + numArray[j]){
        pairs.push([numArray[i], numArray[j]]);
      }
    }
  }
  return pairs;
}

var arr = [1,6,4,5,3,3], sum = 7;
var res = twoSum(arr,sum);
console.log(res);

var arr = [40,11,19,17,-12], sum = 28;
var res = twoSum(arr,sum);
console.log(res);
