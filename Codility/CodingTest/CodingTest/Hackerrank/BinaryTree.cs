using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    public class BinaryTree
    {
    }
}

/*
node
left 
right

root = 4
height = 0
size = 1


# Let's create a tree using an array!
tree = BinaryTree([4, 3, 6, 1, 5, 2, 7])

root = 4
height = 2
size = 7

    4
 3     6
1  2  5  7

level = 1 	nodes = 1	root 4
level = 2	nodes = 2	left 3	right 6
level = 3	nodes = 4	left 1	left 5	rigth 2	right 7


[3, 6, 2, 9, -1, 10]
level 1 nodes 1 root= 3
level 2 nodes 2 left 6 right 2
level 3 nodes 4 left 9 right -1 left 10 right ?


A complete binary tree is a binary tree that each level except possibiliy the last level, is completed filled. Suppose you are giving a binary tree represented as an array. For example, [3, 6, 2, 9, -1, 10] retpresents the following binary tree, where -1 indicates it is a NULL node.

    3
  6   2
9    10

Suppose you're given a binary tree represented as an array.
For example, [3,6,2,9,-1,10] represents the following binary tree (where -1 is a non-existent node): 
3 6 2 9 10 
Write a function that determines whether the left or right branch of the tree is larger. 
The size of each branch is the sum of the node values.
The function should return the string "Right" if the right side is larger and "Left" if the left side is larger.
If the tree has a nodes or if the size of the branches are equal, return the empty string. 
Example Input: [3,6,2,9,-1,10] Example Output: Left 

We can use an array to index/store a complete binary tree where the root index starts at ONE, and the left child index is always twice its parent index, and the right index is the twice parent index plus one.

For example, in above complete binary tree, the Node 6 has index 2 which is equal to 2*ROOT = 2 * 1. and the Node 2 is 2*ROOT+1 = 2*1+1 = 3.


const solution = (arr) => {
    if (!arr) return "";
    if (arr.length === 0) return "";    
    const sum = (arr, idx) => {
        if (idx - 1 < arr.length) {
            if (arr[idx - 1] === -1) return 0;
            return arr[idx - 1] + sum(arr, idx * 2) + sum(arr, idx * 2 + 1);
        }
        return 0;
    };
    const left = sum(arr, 2);
    const right = sum(arr, 3);
    return (left == right) ? "" : (left > right ? "Left" : "Right");
};


A level in a tree is 1 + amount of edges between the node and the root
A node’s depth is the amount of edges between the node and the root
A node’s height is the amount of edges on its longest branch to a leaf
A tree’s height is the amount of edges on its longest branch
A tree’s size is the amount of nodes it contains

The size of each branch is the sum of node values

each node v is stored at index i
if v is the root, i=1
left child of v is 2i
right child of v is 2i+1
parent of v ?

h is the height

Heap
A heap is a balanced binary tree where each node contains a value.

A heap can be represented by an array A where the value at each node of the heap is represented by an element of A. 
If A is zero-based, then the root of the tree is at A[0] and (because A is zero-based) 
the children of the node at A[n] are found at A[(2*n)+1] and A[(2*n)+2].

*/
