
function getSecondLargest(nums) {
	var max=0;
	var sec=0;

	for(let i=0; i<nums.length; i++) {
		if(nums[i] > max) {
			sec = max;
			max = nums[i];
		}
		if(nums[i] > sec && nums[i] < max) {
			sec = nums[i];
		}
	}
	return sec;
}

var nums = [];
//var nums = [0,1,2,3];
//var nums = [1,1,5];

nums.push(2,3,6,6,5);

console.log(getSecondLargest(nums));
