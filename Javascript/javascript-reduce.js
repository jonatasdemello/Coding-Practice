const bricks = [
    {set: 'b-wing', type: 'brick', size: '2x2', color: 'black'},
    {set: 'house', type: 'roof', size: '4x2', color: 'red'},
    {set: 'hp', type: 'spider', size: '1x1', color: 'black'},
    {set: 'b-wing', type: 'panel', size: '4x8', color: 'gray'},
    {set: 'b-wing', type: 'brick', size: '2x2', color: 'black'},
    {set: 'house', type: 'brick', size: '6x1', color: 'white'}
]

// array.reduce(function(total, currentValue, currentIndex, arr), initialValue)

const bricks = [....]; //the pile of bricks defined above
const shelf = bricks.reduce(
	(shelfOfBoxes, brick, brickNumber, pile) => 
	{    
		console.log(`Checking the brick number ${brickNumber + 1}`);
		if(!shelfOfBoxes.hasOwnProperty(brick.set)) {
			shelfOfBoxes[brick.set] = []; //add a new box if needed
		}
		shelfOfBoxes[brick.set].push(brick); //put the brick in its box
		console.log(`Bricks left: ${pile.length - (brickNumber + 1)}`)
	}, {}); //the empty shelf

console.log(shelf);
	
