# Golden solution O(n) 
# For every index p we need to know whether the value A[p] has appeared before the index p. 
# Notice that the range of all the numbers is quite small, so we can count the elements. 
# More precisely, we can iterate through all the elements 
# and in the cell of index A[p] we mark that the value A[p] has just appeared. 

# 3: Golden solution — O(n).
# The time complexity is O(n).

def prefixSetGolden(A): 
	n = len(A) 
	occur = [False] * n 
	for i in xrange(n): 
		if (occur[A[i]] == False): 
			occur[A[i]] = True 
			result = i 
	return result

