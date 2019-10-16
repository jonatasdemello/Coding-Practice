function getMean(arr){
  // Mean: The "average" number; found by adding all data points and dividing by the number of data points. 
  var sum = 0;
  arr.forEach(num => {
    sum += num;
  })
  var mean = sum / arr.length;
  return mean;
}

function getMedian(arr){
  // Median: The middle number; found by ordering all data points and picking out the one in the middle (or if there are two middle numbers, taking the mean of those two numbers). 

  // middle element
  arr.sort(function(a,b){
    return a-b; // asc
  })
  var median;
  if(arr.length % 2 !== 0) { // even
    median = arr[Math.floor(arr.length / 2)];
  }
  else { // odd # elements
    var mid1 = arr[Math.floor(arr.length / 2)- 1];
    var mid2 = arr[Math.floor(arr.length / 2)];
    median = (mid1 + mid2) / 2;
  }
  return median;
}

function getMode(arr){
  // Mode: The most frequent number—that is, the number that occurs the highest number of times.
  var modeObj = {};

  arr.forEach(num => {
    if(!modeObj[num]){ // exists?
      modeObj[num] = 0;
    }
    modeObj[num]++;
  });

  var maxFrequency = 0;
  var modes = [];
  for(var num in modeObj){
    if(modeObj[num] > maxFrequency) {
      modes = [num];
      maxFrequency = modeObj[num];
    }
    else if(modeObj[num] == maxFrequency) {
      modes.push(num);
    }
  }
  //every number freequency is the same
  if(modes.length === Object.keys(modeObj).length){
    modes = [];
  }
  // console.log(modeObj);
  return modes;
}

function meanMedianMode(arr){
  return {
    mean: getMean(arr),
    median: getMedian(arr),
    mode: getMode(arr)
  };
}

var arr = [1,2,3,4,5]
var res = meanMedianMode(arr);
console.log(res);

arr = [1,2,3,4,5,7]
res = meanMedianMode(arr);
console.log(res);

arr = [3,4,2,3,6,4,1]
res = meanMedianMode(arr);
console.log(res);

arr = [1,2,3,4,5,4,6,1]
res = meanMedianMode(arr);
console.log(res);


/*
{ mean: 3, median: 3, mode: [] }
{ mean: 3.6666666666666665, median: 3.5, mode: [] }
{ mean: 3.2857142857142856, median: 3, mode: [ '3', '4' ] }
{ mean: 3.25, median: 3.5, mode: [ '1', '4' ] }
*/
