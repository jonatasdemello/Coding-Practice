
/**
 * Returns a random number between min (inclusive) and max (exclusive)
 */
function getRandomArbitrary(min, max) {
    return Math.random() * (max - min) + min;
}

/**
 * Returns a random integer between min (inclusive) and max (inclusive)
 * Using Math.round() will give you a non-uniform distribution!
 */
function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function makeid()
{
    var text = "";
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    for( var i=0; i < 5; i++ )
        text += possible.charAt(Math.floor(Math.random() * possible.length));

    return text;
}

var randtext1 = Math.random().toString(36).substring(7);
var randtext2 = Math.random().toString(36).substr(2, 5)

// $("#id").append("<div>foo</div>");
// $('#messageArea').append('<p>' + text + '</p>');



function msgLogDiv(divId, text) {

	if (divId == 0) {  // create a new div
		divId = Math.random().toString(36).substring(5);
		
		var newDiv = '<div id='+ divId +'>[ '+ text +' ]</div>';
		
		$('#messageArea').append(newDiv);
	}
	else { // existing div
	
		var elem = $('#'+divId);
		elem.append('<br />[ ' + text + ' ]');
	}
	return divId;
}





/*
var rnd = Math.random().toString(36).substring(7);

First, as others have mentioned, it has a small probability of producing short strings or even an empty string (if the random number is 0), which may break your application. Here is a solution:

(Math.random().toString(36)+'00000000000000000').slice(2, N+2)
Second, both the original and the solution above limit the string size N to 16 characters. The following will return a string of size N for any N (but note that using N > 16 will not increase the randomness or decrease the probability of collisions):

Array(N+1).join((Math.random().toString(36)+'00000000000000000').slice(2, 18)).slice(0, N)
Explanation:

Pick a random number in the range [0,1), i.e. between 0 (inclusive) and 1 (exclusive).
Convert the number to a base-36 string, i.e. using characters 0-9 and a-z.
Pad with zeros (solves the first issue).
Slice off the leading '0.' prefix and extra padding zeros.
Repeat the string enough times to have at least N characters in it (by Joining empty strings with the shorter random string used as the delimiter).
Slice exactly N characters from the string.
Further thoughts:

This solution does not use uppercase letters, but in almost all cases (no pun intended) it does not matter.
The maximum string length at N = 16 in the original answer is measured in Chrome. In Firefox it's N = 11. But as explained, the second solution is about supporting any requested string length, not about adding randomness, so it doesn't make much of a difference.
All returned strings have an equal probability of being returned, at least as far as the results returned by Math.random() are evenly distributed (this is not cryptographic-strength randomness, in any case).
Not all possible strings of size N may be returned. In the second solution this is obvious (since the smaller string is simply being duplicated), but also in the original answer this is true since in the conversion to base-36 the last few bits may not be part of the original random bits. Specifically, if you look at the result of Math.random().toString(36), you'll notice the last character is not evenly distributed. Again, in almost all cases it does not matter, but we slice the final string from the beginning rather than the end of the random string so that short strings (e.g. N=1) aren't affected.
Update:

Here are a couple other functional-style one-liners I came up with. They differ from the solution above in that:

They use an explicit arbitrary alphabet (more generic, and suitable to the original question which asked for both uppercase and lowercase letters).
All strings of length N have an equal probability of being returned (i.e. strings contain no repetitions).
They are based on a map function, rather than the toString(36) trick, which makes them more straightforward and easy to understand.
So, say your alphabet of choice is

var s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
Then these two are equivalent to each other, so you can pick whichever is more intuitive to you:

Array(N).join().split(',').map(function() { return s.charAt(Math.floor(Math.random() * s.length)); }).join('');
and

Array.apply(null, Array(N)).map(function() { return s.charAt(Math.floor(Math.random() * s.length)); }).join('');
*/

