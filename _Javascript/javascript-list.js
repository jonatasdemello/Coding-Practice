var myArr = [10, 20, 30, 40, 10, 40, 70, 80, 70, 90];

<html>    
   <body>              
      <script>  
         function removeDuplicate(arr) {        
            var c;        
            var len = arr.length;        
            var result = [];        
            var obj = {};                
            for (c = 0; c<len; c++)  {            
               obj[arr[c]] = 0;        
            }  
            for (c in obj) {            
               result.push(c);        
            }            
            return result;      
         }              
         var myArr = [10, 20, 30, 40, 10, 40, 70, 80, 70, 90];      
         document.write(removeDuplicate(myArr));  
      </script>          
   </body>
</html>
10,20,30,40,70,80,90


Array.prototype.unique = function () {
    var r = new Array();
    o:for(var i = 0, n = this.length; i < n; i++)
    {
    	for(var x = 0, y = r.length; x < y; x++)
    	{
    		if(r[x]==this[i])
    		{
                alert('this is a DUPE!');
    			continue o;
    		}
    	}
    	r[r.length] = this[i];
    }
    return r;
}

var arr = [1,2,2,3,3,4,5,6,2,3,7,8,5,9];
var unique = arr.unique();
alert(unique);

var arr = [9, 9, 111, 2, 3, 4, 4, 5, 7];
var sorted_arr = arr.sort(); // You can define the comparing function here. 
                             // JS by default uses a crappy string compare.
var results = [];
for (var i = 0; i < arr.length - 1; i++) {
    if (sorted_arr[i + 1] == sorted_arr[i]) {
        results.push(sorted_arr[i]);
    }
}

alert(results);



// set
[...new Set(array)];
// filter
array.filter((item, index) => array,indexOf(item) === index);
// Reduce
array.reduce((unique, item) => unique.includes(item) ? unique : [...unique, item],[]);

const array = [0,1,2,0,0,3];

// Set is a new data object introduced in ES6. 
// Because Set only lets you store unique values. 
// When you pass in an array, it will remove any duplicate values.

const uniqueSet = new Set(array);
const newArray = [...uniqueSet];
// or
const newArray = Array.from(new Set(array);

// Filter
array.filter((item, index) => {
	console.log(item, index, array.indexOf(item), array.indexOf(item) === index);
	return array.indexOf(item) === index });

// Retrieve the duplicate values
array.filter((item, index) => array,indexOf(item) !== index);

// Reduce
array.reduce((unique, item) => {
	console.log(item, unique, unique.includes(item), unique.includes(item) ? unique : [...unique, item]);
	return unique.includes(item) ? unique : [...unique, item] }, []);
	
