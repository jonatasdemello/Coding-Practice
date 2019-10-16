/*
Is Possible
Consider a pair of integers, (a, b).
The following operations can be performed on (a, b) in any order, zero or more times:

R	(a, b) → (a + b, b)
U	(a, b) → (a, a + b)

For example, starting with (1, 1),
perform the operation (1, 1 + 1) to get (1, 2),
perform the operation (1 + 2, 2) to get (3, 2),
and perform the operation (3+2, 2) to get (5, 2).

Alternatively,
the first operation could be (1+1, 1) to get (2, 1) and so on.
The diagram below demonstrates the example representing the pairs as Cartesian coordinates:


Function Description
Complete the function isPossible in the editor below.
The function must return a string that denotes whether or not
you can convert (a, b) to (c, d) by performing zero or more of
the operations specified above.
If it is possible, return the string Yes. Otherwise, return No.

isPossible has the following parameter(s):
    a:  an integer
    b:  an integer
    c:  an integer
    d:  an integer

Constraints
1 ≤ a, b, c, d ≤ 1000

Input Format for Custom Testing
Sample Case 0
Sample Input 0
1
45
9
Sample Output 0
Yes

Explanation 0

Convert (1, 4) to (5, 9) by performing the following sequence of operations: (1, 4) → (5, 4) → (5, 9).

Sample Case 1
Sample Input 1
1
23
6
Sample Output 1
No

Explanation 1

Attempt to convert (1, 2) → (3, 6). The graph above shows possible paths toward the goal.
The dashed lines indicate next moves, which miss the destination. Return No as the answer.
*/
	static LinkedList<Pair<Integer,Integer>> pairs = new LinkedList<Pair<Integer, Integer>>();

    public static String isItPossible(Integer a, Integer b, Integer c, Integer d){
        pairs.addLast(new Pair<Integer, Integer>(a,b));
        while (!pairs.isEmpty()){
            Pair<Integer,Integer> pair = pairs.poll();
            Integer key = pair.getKey();
            Integer value = pair.getValue();
            if(key.equals(a) &&
                    value.equals(b)){
                return "YES";
            }
            int sum=key+value;
            if (sum<=c){
                pairs.addLast(new Pair<Integer, Integer>(sum,value));
            }
            if (sum<=d){
                pairs.addLast(new Pair<Integer, Integer>(key,sum));
            }
        }
        return "NO";
    }
