var homes = [
    {
        "h_id": "3",
        "city": "Dallas",
        "state": "TX",
        "zip": "75201",
        "price": "162500"
    }, 
    {
        "h_id": "4",
        "city": "Bevery Hills",
        "state": "CA",
        "zip": "90210",
        "price": "319250"
    }, 
    {
        "h_id": "5",
        "city": "New York",
        "state": "NY",
        "zip": "00010",
        "price": "962500"
    }
];

homes.sort(function(a, b) {
    return parseFloat(a.city) - parseFloat(b.city);
});

console.log(homes.length);

for(var i=0; i < homes.length; i++)
	console.log(homes[i].city +' : '+ homes[i].price) ;

var h1 = homes.sort();
console.log('\n------')
for(var i=0; i < homes.length; i++)
	console.log(homes[i].city +' : '+ homes[i].price) ;



var items = [
  { name: 'Edward', value: 21 },
  { name: 'Sharpe', value: 37 },
  { name: 'And', value: 45 },
  { name: 'The', value: -12 },
  { name: 'Magnetic', value: 13 },
  { name: 'Zeros', value: 37 }
];

// sort by value
items.sort(function (a, b) {
  return a.value - b.value;
});

console.log('\n------ by value: ')
for(var i=0; i < items.length; i++)
	console.log(items[i].name +' : '+ items[i].value) ;

// sort by name
items.sort(function(a, b) {
  var nameA = a.name.toUpperCase(); // ignore upper and lowercase
  var nameB = b.name.toUpperCase(); // ignore upper and lowercase
  if (nameA < nameB) {
    return -1;
  }
  if (nameA > nameB) {
    return 1;
  }

  // names must be equal
  return 0;
});

console.log('\n------ by name: ')
for(var i=0; i < items.length; i++)
	console.log(items[i].name +' : '+ items[i].value) ;