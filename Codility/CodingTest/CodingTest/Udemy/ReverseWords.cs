using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class ReverseWords
    {
    }
}
/*
function reverseWords(string){
  var wordsArr = string.split(' ');
  var reverseWordsArr = [];

  var resultString = '';

  wordsArr.forEach(word => {
    var reversedWord = '';
    for(var i=word.length-1; i>=0; i--){
      reversedWord += word[i];
    }
    reverseWordsArr.push(reversedWord);
  })

  return reverseWordsArr.join(' ');
}

function reverseWords_v1(string){
  var strArr = string.split(' ');
  var resultString = '';

  console.log(strArr);
  strArr.forEach(word => {
    var lettersArr = [];
    lettersArr = word.split('');
    resultString += lettersArr.reverse().join('') + ' ';
  })

  return resultString.trim();
}

var res = reverseWords('Zoo Keeper');
console.log(res);
*/
