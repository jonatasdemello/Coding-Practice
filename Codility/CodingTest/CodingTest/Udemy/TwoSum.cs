
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class TwoSum
    {
        public List<string> TestTwoSum(int[] numArray, int sum)
        {
            // Returns every pair of numbers from 'numArray' that adds up to the 'sum'
            // var arr = [1,6,4,5,3,3], sum = 7; => [6,1], [3,4], [3,4]

            var pairs = new List<string>();
            var hashtable = new HashSet<int>(); // HashSet does not allow duplicate values and allow fast search

            for (var i = 0; i < numArray.Length; i++)
            {
                var currNum = numArray[i];
                var counterpart = sum - currNum; // number that adds up to sum

                if (hashtable.Contains(counterpart))
                {
                    pairs.Add("[ " + currNum + " , " + counterpart + " ]");
                    // pairs.Add(currNum, counterpart); Dict
                }
                hashtable.Add(currNum);
            }
            return pairs;
        }

        public List<int[]> TestTwoSum1(int[] numArray, int sum)
        {
            // Returns every pair of numbers from 'numArray' that adds up to the 'sum'
            // var arr = [1,6,4,5,3,3], sum = 7; => [6,1], [3,4], [3,4]
            var pairs = new List<int[]>();

            for (var i = 0; i < numArray.Length; i++)
            {
                for (var j = i+1; j < numArray.Length; j++)
                {
                    // Console.WriteLine("i: {0}  j: {1}  a[i]: {2}  a[j]: {3}  sum: {4}", i, j, numArray[i], numArray[j], (numArray[i] + numArray[j]));
                    if (sum == numArray[i] + numArray[j])
                    {
                        pairs.Add(new int[] { numArray[i], numArray[j] });
                    }
                }
            }
            return pairs;
        }
    }
}
/*// this is O(n)
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
*/
