using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class FactorialClass
    {
        public long Factorial(long x)
        {
            long fact = 1;
            long i = 1;
            while (i <= x)
            {
                fact = fact * i;
                i++;
            }
            return fact;
        }

        public long Factorial(long x, long lowerBound)
        {
            long fact = 1;
            while (x >= 1 && x > lowerBound)
            {
                fact *= x;
                x--;
            }

            return fact;
        }
    }
}
/*
function factorial(num) {
  if(num <= 1) {
    return num;
  }
  else {
    return num * factorial(num - 1);
  }
}

console.log(factorial(4));
*/
