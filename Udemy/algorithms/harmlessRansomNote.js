// O(n) + O(m) or O(n+m) or simply O(n)
function harmlessRansomNote(noteText, magazineText) {
  var noteArr = noteText.split(' ');
  var magazineArr = magazineText.split(' ');
  var magazineObj = {};
  // hashTable
  magazineArr.forEach(word => {
    if (!magazineObj[word]){
      magazineObj[word] = 0; // add if not exists
    }
    magazineObj[word]++;

  });

  var noteIsPossible = true;
  noteArr.forEach(word =>{
    // find if we have the necessary words in magazine
    if(magazineObj[word]) {
      magazineObj[word]--;
      if(magazineObj[word] < 0 )
        noteIsPossible = false;
    }
    else
      noteIsPossible = false;
  });

  //console.log(magazineObj);
  return noteIsPossible;
}

var res = harmlessRansomNote('test is is','this is all the text in test');
console.log(res);

res = harmlessRansomNote('this is a secret note for you from a secret admirer', 'puerto rico is a place of great wonder and excitement it has many secret waterfall locations that i am an admirer of you must hike quite a distance to find the secret places as they are far from populated areas but it is worth the effort a tip i have for you is to go early in the morning when it is not so hot out also note that you must wear hiking boots this is one of the best places i have ever visited');
console.log(res);