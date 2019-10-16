// C# code​​​​​​‌​​​‌​​‌​‌​‌‌​‌​‌​​‌​‌‌​‌ below
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

class Solution
{
	
	public static bool isTwin(String a, String b)
	{
		if (a.Length != b.Length)
			return false;

		var arrA = a.ToLower().ToCharArray().ToList();
		var arrB = b.ToLower().ToCharArray().ToList();

		arrA.Sort();
		arrB.Sort();
		// or 
		var strA = string.Concat(arrA);
		var strB = string.Concat(arrB);

		var equal = strA.Equals(strB);
		Console.WriteLine("\n{0} - {1} - {2}", strA, strB, equal);

		var res = arrA.Intersect(arrB);

		if (res.Count() != a.Length)
			return false;

		return (res.Count() > 0);
	}
	
	public static bool isTwin(String a, String b)
	{
	    // doesnt' work, I have to make a hash table and verify if both letters count are equal
	    
	    if(a.Length != b.Length)
	        return false;
	        
	    var aArr = a.ToCharArray().ToList();
	    var bArr = b.ToCharArray().ToList();
	    
	    var res = aArr.Intersect(bArr);
	    
	    if(res.Count() != a.Length)
	        return false;

	    return (res.Count() > 0);
    }
}
/*
isTwin("hello", "world"));// false
isTwin("abc", "cab"));// true
isTwin("Lookout", "outlook"));// true


console.clear();
const print = console.log;

function isTwin(a, b) {
    if (a.length !== b.length) {
        return false;
    }
    
    const sorteda = a.toUpperCase().split('').sort().join('');
    const sortedb = b.toUpperCase().split('').sort().join('');
    
    return sorteda === sortedb;
}

print(isTwin("Hello", "world")); // false
print(isTwin("acb", "bca")); // true
print(isTwin("Lookout", "Outlook")); // true
print(isTwin("a", "a")); // true
print(isTwin("peon", "peon")); // true
*/