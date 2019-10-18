C# Data Structures

// Array

Array
The perhaps simplest and most common data structure is the array. A C# array is basically a list of objects. Its defining traits are that all the objects are the same type (in most cases) and there is a specific number of them. The nature of an array allows for very fast access to elements based on their position within the list (otherwise known as the index). A C# array is defined like this:

[object type][] myArray = new [object type][number of elements]
Some examples:

int[] myIntArray = new int[5];
int[] myIntArray2 = { 0, 1, 2, 3, 4 };
As you can see from the example above, an array can be intialized with no elements or from a set of existing values. Inserting values into an array is simple as long as they fit. The operation becomes costly when there are more elements than the size of the array, at which point the array needs to be expanded. This takes longer because all the existing elements must be copied over to the new, bigger array.

ArrayList
The C# data structure, ArrayList, is a dynamic array. What that means is an ArrayList can have any amount of objects and of any type. This data structure was designed to simplify the processes of adding new elements into an array. Under the hood, an ArrayList is an array whose size is doubled every time it runs out of space. Doubling the size of the internal array is a very effective strategy that reduces the amount of element-copying in the long run. We won't get into the proof of that here. The data structure is very simple to use:

ArrayList myArrayList = new ArrayList();
myArrayList.Add(56);
myArrayList.Add("String");
myArrayList.Add(new Form());
The downside to the ArrayList data structure is one must cast the retrived values back into their original type:

int arrayListValue = (int)myArrayList[0];
List<>
The List C# data structure was introduced in the .NET Framework 2.0 as part of the new set of generic collections. List is the generic version of ArrayList, which means that it behaves exactly the same way, but within a specified type. So for example, a List of integers would work as follows:

List<int> intList = new List<int>();
intList.Add(45);
intList.Add(34);
Since the List<> object is tailored to a specific data type, there is no need to cast when retrieving values:

int listValue = intList[0];
This results in much cleaner, and in my times, faster code. This is especially true when working with primative types. Unless you are using the .NET Framework 1.1, you should always use List over ArrayList. (Note that List<Object> is perfectly legal, although it defeats the purpose of having a generic dynamic array collection).

LinkedList<>
Now for a completely different type of C# data structure, the LinkedList. A LinkedList is a series of objects which instead of having their references indexed (like an Array), stay together by linking to each other, in Nodes.

A LinkedList Node has basically three values: the Object's Value, a reference to the Next node, and a reference to the Previous Node.

What is the point of such C# data structure? Well, adding values to the middle of the list is much faster compared to any other Array type of data structure. It also keeps memory costs down to a minimum. Lists on the other hand use extra space to make future insertions as fast as possible.

LinkedList<int> list = new LinkedList<int>();
list.AddLast(6);
Retrieving a value is not as straight forward:

list.First.Value 
or
list.Last.Value
Since inserting and removing elements is done by updating a couple references, they can be done in constant time. The tradeoff is that accessing elements is no longer a constant time operation. In an array, with a given index an element can be instantly accessed. With a linked list, the references between nodes need to be followed until the desired element is found.

With that we can move on to more complex data structures.

Dictionary<>
The Dictionary C# data structure is extremely useful data structure since it allows the programmer to handle the index keys. What does that mean? Well an ArrayList automatically makes its "keys" integers that go up one by one, 1, 2, etc, so to access a value in an ArrayList one goes like: myArrayList[2];

So what the C# Dictionary data structure does is let us specify the keys, which can be any type of object. For example:

Dictionary<string, int> myDictionary = new Dictionary<string, int>();
myDictionary.Add("one", 1);
myDictionary.Add("twenty", 20);
Retrieving a value is pretty straight forward:

int myInt = myDictionary["one"];
Notice how convenient the Dictionary data structure is, in that there is no need to cast between types. Also there is nothing stopping you from creating a Dictionary like so:

Dictionary<int, Dictionary<string, int>> nestedDictionary = 
            new Dictionary<int, Dictionary<string, int>>();
That is a nested Dictionary C# data structure and it is fair game.

I understand that it can be confusing on how to go about getting all the values out of a Dictionary data structure since we have no way to knowing the pattern in the keys. Luckily we don't have to, here is the code to transverse a C#.Net Dictionary:

//List<[same type as index]>
List<string> keyList = new List<string>(myDictionary.Keys);
for (int i = 0; i < keyList.Count; i++)
{
    int myInt = myDictionary[keyList[i]];

}
You can read about C# Dictionary in a little more detail if you are interested.

Dictionary vs. SortedDictionary
The difference between Dictionary and SortedDictionary start with the obvious. A Dictionary keeps elements in the order the were added. Meanwhile a SortedDictionary keeps elements sorted based on their comparer.

Dictionary
Two things to consider: insertion time and searching time. Because elements are not automatically sorted, inserting elements is faster.

Similarly because elements are not sorted, it makes searching more complicated, meaning searching is slower.

SortedDictionary
In a SortedDictionary elements must be sorted when they are added, making insertion times slower.

But since elements are kept stored, searching can be done with binary search, meaning searching is faster.


Hashtable
The C# Hashtable data structure is very much like the Dictionary data structure. A Hashtable also takes in a key/value pair, but it does so as generic objects as opposed to typed data.

Values are then stored in order according to their key's HashCode. Meaning that the order in which items are added to a C# Hashtable is not preserved. On the other hand, the Dictionary data structure does keep items in the same order.

The reason is speed. A C# Hashtable stores items faster than a C# Dictionary, which sacrifices speed for the sake of order..

(For those Java programmers, a Dictionary is more or less a TreeMap and a Hashtable is a HashMap).

Hashtable myTable = new Hashtable();
HashSet
The HashSet data structure was introduced in C#.NET 3.5. This particular C# data structure very strongly resembles the List<> data strucuture.

So what is the difference? A HashSet has the very important characteristic that it does not allow duplicate values. For example:

HashSet<int> mySet = new HashSet<int>();
mySet.Add(3);
mySet.Add(5);
mySet.Add(3);
mySet.Add(10);

List<int> myListFromSet = mySet.ToList<int>();
int myInt = myListFromSet[2];
If mySet were a regular List data structure, the index 2 should return the value 3 (count it out). But if you run the example you will see that myInt actually returns the value 10. This is because the HashSet C# data structure ignored the duplicate addition of the value 3.

You might wonder what is the point of this. After all, you could achieve the same behavior with a List data structure. Something like:

if (!myList.Contains(element))
     myList.Add(element);
The result is indeed the same. But what is not apparent is the speed at which this happens. When an element is added to a HashSet, internally the same thing happens: the data structure makes sure the element doesn't already exist. However a HashSet is not a simple array, it is specifically designed to allow fast search times which dramatically improves the performace of checking whether a new element is a duplicate or not.


Stack
The Stack class is one of the many C# data structures that resembles an List. Like an List, a stack has an add and get method, with a slight difference in behavior.

To add to a stack data structure, you need to use the Push call, which is the Add equivalent of an List. Retrieving a value is slightly different. The stack has a Pop call, which returns and removes the last object added. If you want to check the top value in a Stack, use the Peek call.

The resulting behavior is what is called LIFO, which stands for Last-In-First-Out. This particular data structure is helpful when you need to retrace your steps so to speak.

There are two formats to define a Stack in C#:

Stack stack = new Stack();
Stack<string> stack = new Stack<string>();
The different between the data structures being that the simple Stack structure will work with Objects while the Stack<> one will accept only a specified object.

Here is the C# code to add and traverse through a Stack data structure:

Stack<string> stack = new Stack<string>();
stack.Push("1");
stack.Push("2");
stack.Push("3");

while (stack.Count > 0)
{
    MessageBox.Show(stack.Pop());
}
If you run the C# code you see that the list is returned in the order: 3, 2, 1.

Queue
Another one of the many C# data structures is the Queue. A Queue is very similar to the Stack data structure with one major difference.

Rather than follow a LIFO behavior, a Queue data structure goes by FIFO, which stands for First-In-First-Out. Whenever you submit an article to be approved on a website for example, the site adds your submittion to a queue. That way the first objects added are the first ones to be processed.

The Add call for a queue (or the Push version) is Enqueue:

queue.Enqueue("1");
The Remove call is Dequeue:

queue.Dequeue();
Similarly the Peek call allows you to view the top value without removing it. This specific data structure is very often used in conjucture with stack data structures.

Here is some simple C# code to add items to a queue and the transverse it:

Queue<string> queue = new Queue<string>();
queue.Enqueue("1");
queue.Enqueue("2");
queue.Enqueue("3");

while (queue.Count > 0)
{
   MessageBox.Show(queue.Dequeue());
}
Also keep in mind the queue data structure can be defined as a general Queue and as a type-specific Queue<>
