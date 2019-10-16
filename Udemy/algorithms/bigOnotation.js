// Big O Notation

log([1,2,3,4]);

// O(1) => constant
function log(array, pos){
	console.log(array[pos]);
}

// O(n) => linear
function logAll(array){
	for(var i=0; i<array.length; i++){
		console.log(array[i]);
	}
}

// O(n^2) => exponential
function addAndLog(array){
	for(var i=0; i<array.length; i++){
		for(var j=0; j<array.length; j++){
			console.log(array[i] + array[j]);
		}
	}
}
addAndLog(['a','b']); // 4
addAndLog(['a','b','c']); // 9
addAndLog(['a','b','c','d']); // 16
addAndLog(['a','b','c','d','e']); // 25

// O(log n) => logarithmic
function binarySarch(array, key){ // array must be sorted 
	var low = 0;
	var high = array.length - 1;
	var mid;
	var elem;
	
	while(low <= high){
		mid = Math.floor((low + high)/2, 10);
		elem = array[mid];
		if(elem < key){
			low = mid + 1;
		} else if (elem > key){
			high = mid - 1;
		} else {
			return mid;
		}
	}
	return -1; // not found
}

// O(2^n)
function fibonacci(position){
  if (position < 3)
    return 1;
  else 
    return (fibonacci(position-1) + fibonacci(position-2));
}


