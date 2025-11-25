# Arrayzing - The JavaScript array cheatsheet

This is a work-in-progress cheatsheet for JS arrays. Please feel free to leave a comment if this has helped you or you would like to suggest anything.

* [Create an array](#user-content-create-an-array)
* [Empty an array](#user-content-empty-an-array)
* [Clone an array](#user-content-clone-an-array)
* [Get last item](#user-content-get-last-item)
* [Remove first item](#user-content-remove-first-item)
* [Remove last item](#user-content-remove-last-item)
* [Add new item(s) to beginning](#user-content-add-new-items-to-beginning)
* [Add new item(s) to end](#user-content-add-new-items-to-end)
* [Overwrite item at a specific index](#user-content-overwrite-item-at-a-specific-index)
* [Add new item(s) at a specific index](#user-content-add-new-items-at-a-specific-index)
* [Remove single item at a specific index](#user-content-remove-single-item-at-a-specific-index)
* [Remove several items](#user-content-remove-several-items)
* [Reverse an array](#user-content-reverse-an-array)
* [Randomise an array](#user-content-randomise-an-array)
* [Delimit an array](#user-content-delimit-an-array)
* [Sort in alphabetical/numerical order](#user-content-sort-in-alphabeticalnumerical-order)
* [Sort in reverse alphabetical/numerical order](#user-content-sort-in-reverse-alphabeticalnumerical-order)
* [Join two arrays together](#user-content-join-two-arrays-together)
* [Copy specific item(s)](#user-content-copy-specific-items)
* [Augment items within an array](#user-content-augment-items-within-an-array)
* [Return true if every item meets a condition](#user-content-return-true-if-every-item-meets-a-condition)
* [Return true if at least one item matches a condition](#user-content-return-true-if-at-least-one-item-matches-a-condition)
* [Execute a function once per array item](#user-content-execute-a-function-once-per-array-item)
* [Filter an array](#user-content-filter-an-array)
* [Detect an array](#user-content-detect-an-array)
 * [ES4 and below](#user-content-es4-and-below)
 * [ES5 and above](#user-content-es5-and-above)
* [Simple FIFO queue](#user-content-simple-fifo-queue)
* [Find index of an item](#user-content-find-index-of-an-item)
 * [ES4 and below](#user-content-es4-and-below-1)
 * [ES5 and above](#user-content-es5-and-above-1)
* [Chaining Methods](#chaining-methods)

## Create an array

```javascript
var meals = ['breakfast', 'lunch', 'dinner'] ;
```

Or

```javascript
var meals = new Array('breakfast', 'lunch', 'dinner');
```

## Empty an array

```javascript
var meals = new Array('breakfast', 'lunch', 'dinner');
meals.length = 0
```

## Clone an array

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

var copy = meals.slice(0, meals.length);
// ['breakfast', 'lunch', 'dinner']
```

## Get last item

```javascript

var meals = ['breakfast', 'lunch', 'dinner'];

meals[meals.length - 1];
// 'dinner'
```

Or

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];
meals.slice(-1);
// 'dinner'
```

## Remove first item

```javascript

var meals = ['breakfast', 'lunch', 'dinner'];

meals.shift();
// 'breakfast'

meals;
// ['lunch', 'dinner']
```

## Remove last item

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

meals.pop();
// 'dinner'

meals;
// ['breakfast', 'lunch'];
```

## Add new item(s) to beginning

```javascript
var meals = ['lunch', 'dinner'];

meals.unshift('breakfast');
// 3 - the array length

meals;
// ['breakfast', 'lunch', 'dinner']
```

## Add new item(s) to end

```javascript

var meals = ['breakfast', 'lunch', 'dinner'];

meals.push('supper');
// 2

meals;
// ['breakfast', 'lunch', 'dinner', 'supper'];
```

## Overwrite item at a specific index

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

meals[1] = 'brunch';
// ['breakfast', 'brunch', 'dinner'];
```

Or
```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

meals.splice(1, 1, 'brunch');
```

## Add new item(s) at a specific index

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

meals.splice(1, 0, 'brunch', 'more brunch');
// ['breakfast', 'brunch', 'more brunch', 'lunch', 'dinner']
```

## Remove single item at a specific index

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

meals.splice(1, 1);
// ['lunch']

meals;
// ['breakfast', 'dinner']
```

## Remove several items

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

meals.splice(1, 2);
// ['breakfast']

meals;
// ['breakfast']
```

## Reverse an array

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

meals.reverse();
// ['dinner', 'lunch', 'breakfast'];
```

## Randomise an array

```javascript
function randomiseArray(arr) {
    var buffer = [], start;

    for(var i = arr.length; i >= arr.length && i > 0;i--) {
        start = Math.floor(Math.random() * arr.length);
        buffer.push(arr.splice(start, 1)[0])
    };

    return buffer;
}

randomiseArray([0,1,2,3,4]);
// [2,1,0,3,4]

randomiseArray([0,1,2,3,4]);
// [3,2,1,4,0]

randomiseArray([0,1,2,3,4]);
// [1,2,4,0,3]
```

## Delimit an array

```javascript

var meals = ['breakfast', 'lunch', 'dinner'];

meals.join(' AND ');
// 'breakfast AND lunch AND dinner'
```

## Sort in alphabetical/numerical order

```javascript

var meals = ['breakfast', 'lunch', 'dinner'];

meals.sort();
// ['breakfast', 'dinner', 'lunch']
```

## Sort in reverse alphabetical/numerical order

```javascript
[0, 1, 2, 3, 4, 5, 6].sort(function(a, b) {
  return b > a;
});
// [6, 5, 4, 3, 2, 1, 0]
```

Or
```javascript
[0, 1, 2, 3, 4, 5, 6].sort().reverse();
// [6, 5, 4, 3, 2, 1, 0]
```

## Join two arrays together

```javascript
var dayTimeMeals = ['breakfast', 'lunch'];
var nightTimeMeals = ['merienda', 'dinner'];

var allTheMeals = dayTimeMeals.concat(nightTimeMeals);
// ['breakfast', 'lunch', 'merienda', 'dinner']
```

## Copy specific item(s)

```javascript
var meals = ['breakfast', 'lunch', 'dinner', 'supper'];

nightTimeMeals = meals.slice(2,4);
// ['dinner', 'supper']
```

## Augment items within an array

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];
var type = ['king', 'prince', 'pauper'];

meals.map(function(item, i) {
  return item + ' like a ' + type[i];
});
// ["breakfast like a king", "lunch like a prince", "dinner like a pauper"]
```

## Return true if every item meets a condition

```javascript
var meals = ['breakfast', 'lunch', 'dinner', 'supper'];

meals.every(function(item){ return item.length > 0 });
// true

meals.every(function(item){ return item.length > 6 });
// false
```

## Return true if at least one item matches a condition

```javascript
var meals = ['breakfast', 'lunch', 'dinner', 'supper'];

meals.some(function(item){ return item === 'lunch';});
// true

meals.some(function(item){ return item === 'burgers!!';});
//false
```

## Execute a function once per array item

```javascript
var meals = ['breakfast', 'lunch', 'dinner', 'supper'];

meals.forEach(function(currentValue, index, arr){
  console.log(index, currentValue, arr);
});
```

## Filter an array

```javascript
var meals = ['breakfast', 'lunch', 'dinner', 'supper'];

meals.filter(function() (item) {
  return item !== 'breakfast';
});
// ['lunch', 'dinner', 'supper'];
```
## Detect an array

### ES4 and below

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

function isArray(arr) {
  return !!(Object.prototype.toString.call(arr) === '[object Array]');
}

isArray(meals);
// true
```

### ES5 and above

```javascript
var meals = ['breakfast', 'lunch', 'dinner'];

Array.isArray(meals)
// true
```

## Simple FIFO queue

```javascript
var meals = ['breakfast', 'elevenses', 'brunch'];

meals.shift(); 
meals.push('lunch');

// ['elevenses', 'brunch', 'lunch']

meals.shift()
meals.push('afternoon tea');

// ['brunch', 'lunch', 'afternoon tea']
// ... and so on ...
```

## Find index of an item

### ES4 and below

```javascript
var meals = ['breakfast', 'elevenses', 'brunch'];

function inArray(arr, query){
  var found = -1,
      len = arr.length, 
      i = 0; 

  for(; i < len; i++){
    if(arr[i] === query){
      found = i;
    }
  }
  return found;
}

inArray(meals, 'brunch');
// 2 - the index of the item in the array

inArray(meals, 'dinner');
// -1
```

## ES5 and above

```javascript
var meals = ['breakfast', 'elevenses', 'brunch'];
meals.indexOf('brunch');
// 2
```

# Chaining methods

```javascript
var meals = [
  {type: 'breakfast', name: 'Full English', calories: 1500},
  {type: 'breakfast', name: 'Colacao', calories: 260},
  {type: 'breakfast', name: 'Croissant and jam', calories: 520},
  {type: 'breakfast', name: 'Granola with Greek yoghurt and blueberries', calories: 680},
  {type: 'brinner', name: 'Shepherds Pie with strawberry yoghurt', calories: 915},
  {type: 'brinner', name: 'Milky Porridge with beef and green beans', calories: 875},
  {type: 'dinner', name: 'Phad Thai', calories: 750},
  {type: 'dinner', name: 'Chicken Katsu curry and rice', calories: 830},
];

function getMealsByMaxCalories(meals, maxCalories, dailyAllowance) {
  return meals
    .filter(function(meal) {
        return meal.calories <= maxCalories;
    })
    .map(function(meal) {
        return {
            name: meal.name,
            calories: meal.calories,
            percentageOfDailyAllowance: meal.calories / dailyAllowance * 100
        }
    });
}
    
getMealsByMaxCalories(meals, 850, 2000);

/*
[
  {
    "name": "Colacao",
    "calories": 260,
    "percentageOfDailyAllowance": 13
  },
  {
    "name": "Croissant and jam",
    "calories": 520,
    "percentageOfDailyAllowance": 26
  },
  {
    "name": "Granola with Greek yoghurt and blueberries",
    "calories": 680,
    "percentageOfDailyAllowance": 34
  },
  {
    "name": "Phad Thai",
    "calories": 750,
    "percentageOfDailyAllowance": 37.5
  }
]
*/
```