using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingTest
{
    public class IsTwin
    {
        public bool Solution1(String a, String b)
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

        public bool Solution2(String a, String b)
        {
            if (a.Length != b.Length)
                return false;

            var aArr = a.ToLower().ToCharArray().ToList();
            var bArr = b.ToLower().ToCharArray().ToList();

            var res = aArr.Intersect(bArr);

            if (res.Count() != a.Length)
                return false;

            return (res.Count() > 0);
        }
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