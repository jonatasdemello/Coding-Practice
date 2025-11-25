Logarithms
Logarithms are slightly trickier to explain so I'll use a common example:

Binary search is a technique used to search sorted data sets. It works 
by selecting the middle element of the data set, essentially the median, 
and compares it against a target value. If the values match it will 
return success. If the target value is higher than the value of the 
probe element it will take the upper half of the data set and perform 
the same operation against it. Likewise, if the target value is lower 
than the value of the probe element it will perform the operation 
against the lower half. It will continue to halve the data set with each 
iteration until the value has been found or until it can no longer split 
the data set. 

This type of algorithm is described as O(log N). The iterative halving 
of data sets described in the binary search example produces a growth 
curve that peaks at the beginning and slowly flattens out as the size of 
the data sets increase e.g. an input data set containing 10 items takes 
one second to complete, a data set containing 100 items takes two 
seconds, and a data set containing 1000 items will take three seconds. 
Doubling the size of the input data set has little effect on its growth 
as after a single iteration of the algorithm the data set will be halved 
and therefore on a par with an input data set half the size. This makes 
algorithms like binary search extremely efficient when dealing with 
large data sets. 



O(log N) is log base 2 as well. This is an important distinction.

Regarding O notation there is no distinction between O(log N), O(ln N) or logarithms of any base. 

This is because O notation is saying, asymptotically, that the algorithm has a time complexity limited by the log function. 
A logarithm of any base b is a real multiple of any generic logarithm: 
log_b N = log N / log b. 
These are equivalent in O notation because of its definition: 
“if g(x) is O(f(x)) there exists some real constant M such that g(x) <= M f(x)” 
obviously if we multiply by 1/log b, there is another real constant N = M / log b that satisfies this definition. 


```
X	constant	logarithmic	linear		quadratic	cubic
n	O(1)	O(log N)	O(N)	O(N log N)	O(N2)	O(N3)
1	1	1	1	1	1	1
2	1	1	2	2	4	8
4	1	2	4	8	16	64
8	1	3	8	24	64	512
16	1	4	16	64	256	4,096
1,024	1	10	1,024	10,240	1,048,576	1,073,741,824
1,048,576	1	20	1,048,576	20,971,520	1012	1016



X	constant	logarithmic	linear		quadratic	cubic
n	O(1)	O(log N)	O(N)	O(N log N)	O(N2)	O(N3)
1	1	1	1	1	1	1
2	1	1	2	2	4	8
4	1	2	4	8	16	64
8	1	3	8	24	64	512
16	1	4	16	64	256	4,096
1,024	1	10	1,024	10,240	1,048,576	1,073,741,824
1,048,576	1	20	1,048,576	20,971,520	1012	1016

```