// O
function isPalindrome(string){
  str = string.toLowerCase();
  var charactersArr = str.split('');
  // ignore punctuation
  var validCharacters = 'abcdefghijklmnopqrstuvwxyz'.split('');

  var lettersArr = [];
  charactersArr.forEach(char =>{
    if(validCharacters.indexOf(char) > -1){
      lettersArr.push(char);
    }
  });
  if(lettersArr.join('') === lettersArr.reverse().join('')){
    return true;
  }
  return false;
}

var res;
res = isPalindrome('race car');
console.log(res);

res = isPalindrome("Madam, I'm Adam");
console.log(res);

res = isPalindrome("no this is not");
console.log(res);

// or using regex
function extract(){
  var answer = "5 Madam, I'm Adam";
  answer = answer.replace(/[0-9]/gi, '');
  console.log(answer);

  answer = answer.replace(/[^a-z]/gi, '');
  console.log(answer);
}

