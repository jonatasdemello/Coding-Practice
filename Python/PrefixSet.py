""" 
A non-empty array A consisting of N integers is given. 
The first covering prefix of array A is the smallest integer P such that 0=P<N and such that 
every value that occurs in array A also occurs in sequence A[0], A[1], ..., A[P].

For example, the first covering prefix of the following 5-element array A:
  A[0] = 2
  A[1] = 2
  A[2] = 1
  A[3] = 0
  A[4] = 1
is 3, because sequence [ A[0], A[1], A[2], A[3] ] equal to [2, 2, 1, 0], contains all values that occur in array A.

Write a function
class Solution { public int solution(int[] A); }
that, given a non-empty array A consisting of N integers, returns the first covering prefix of A.
For example, given array A such that
  A[0] = 2
  A[1] = 2
  A[2] = 1
  A[3] = 0
  A[4] = 1
the function should return 3, as explained above.
Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..1,000,000];
each element of array A is an integer within the range [0..N-1].
"""
def prefixSetSlow(A):
    n = len(A)
    p = n - 1
    i = p - 1
    # keep decreasing p by 1
    while (i >= 0):
        # check if A[p] appears before in A
        while (i > 0) and (A[i] != A[p]):
            i = i - 1
        # decrease p if possible, otherwise set it to -1
        if (A[i] == A[p]):
            p = p - 1
            i = p - 1
        else:
            i = -1
    return p

def prefixSetFast(A):
    n = len(A)
    l = 0
    r = n - 1
    T = n * [False]
    # invariant: l <= p <= r
    while l < r:
        s = (l + r) / 2
		# check if p <= s
        T = n * [False]
        for i in xrange(s + 1):
			T[A[i]] = True
        i = s + 1
        while (i < n) and T[A[i]]:
            i = i + 1
        # reduce the range l..r
        if i == n:
            r = s
        else:
            l = s + 1
    return l

def prefixSetGolden(A):
	n = len(A)
	occur = [False] * n
	for i in xrange(n):
		if (occur[A[i]] == False):
			occur[A[i]] = True
			result = i
	return result



A = [2, 2, 1, 0, 1]
print 'A = ', A
print prefixSetSlow(A)
print prefixSetFast(A)
print prefixSetGolden(A)