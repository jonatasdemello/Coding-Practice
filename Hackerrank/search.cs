public class MainClass{
   public static void Main(){
		object[] doubles = {1.0, 2.0, 3.0};
		IEnumerable<double> d = doubles.Cast<double>();
		Console.Write(d);
	}
}


Write a program that prints the temperature closest to 0 among input data.
 
INPUT:
Line 1: N, the number of temperatures to analyse
Line 2: The N temperatures expressed as integers ranging from -273 to 5526
 
OUTPUT:
Display 0 (zero) if no temperature is provided
Otherwise, display the temperature closest to 0, knowing that if two numbers are equally close to zero, positive integer has to be considered closest to zero (for instance, if the temperatures are -5 to 5, then display 5)
 
CONSTRAINTS:
0 ≤ N < 10000
 
EXAMPLE:
Input
5
1 -2 -8 4 5


10
-5 -4 -2 12 -40 4 2 18 11 5
out 2

5
1 -2 -8 4 5
out 1

// Read inputs from Standard input.
// Write outputs to Standard output.

using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
	static void Main(String[] args)
	{
	    var min = 0;
	    
		string line = Console.ReadLine();
		int n = Convert.ToInt32(line);
		if (n > 0)
		{
		    var val = Console.ReadLine();
		    var arr = val.Split(' ');
		    
		    min = Int32.Parse(arr[0]);
		    for (int i = 1; i < arr.Length; i++)
    		{
    		    int value = Int32.Parse(arr[i]);

    		    if(value > 0 && value < Math.Abs(min))
    		        min = value;
                else if(value < 0 && Math.Abs(value) < Math.Abs(min))
    		        min = value;    		        
    		       
    		    if (min < 0 && value > 0 &&  Math.Abs(value) == Math.Abs(min))
    		        min = value;
			}
		}
	    Console.WriteLine(min);
	}
}


The aim of this exercise is to check the presence of a number in an array.

Specifications:
The items are integers arranged in ascending order.
The array can contain up to 1 million items
The array is never null
Implement the method boolean Answer.Exists(int[] ints, int k) so that it returns true if k belongs to ints, otherwise the method should return false.

Important note: Try to save CPU cycles if possible.

Example:
int[] ints = {-9, 14, 37, 102};
Answer.Exists(ints, 102) returns true
Answer.Exists(ints, 36) returns false


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
	    var min = 0;
	    
		string line = Console.ReadLine();
		int n = Convert.ToInt32(line);
		if (n > 0)
		{
		    var val = Console.ReadLine();
		    var arr = val.Split(' ');
		    
		    var minPos = Int32.Parse(arr[0]);
		    var minNeg = Int32.Parse(arr[0]);
		   
		    for (int i = 0; i < arr.Length; i++)
    		{
    		    int value = Int32.Parse(arr[i]);

    		    if(value > 0 && value <= minPos)
    		        minPos = value;
    		        
                if(value < 0 && Math.Abs(value) <= Math.Abs(minNeg))
    		        minNeg = value;

    		}
    		
    		if (Math.Abs(minNeg) < Math.Abs(minPos))
    		    min = minNeg;
    		    
    		if (Math.Abs(minPos) <= Math.Abs(minNeg))
    		    min = minPos;
    		
		}
	    Console.WriteLine(min);
    }
}


// C# code below
using System;
using System.IO;

public class Answer
{
    public static bool Exists(int[] ints, int k)
    {
    }
}

int[] ints = {-9, 14, 37, 102};
Console.WriteLine(Answer.Exists(ints, 102)); // true
Console.WriteLine(Answer.Exists(ints, 36)); // false


public class Answer
{
    public static bool Exists(int[] ints, int k)
    {
        // sequential search
        for (int i=0; i<ints.Length; i++)
        {
            if(ints[i] == k){
                return true;
            }
        }
        return false;
    }
}



// C# code below
using System;
using System.IO;

public class Answer
{
    public static bool Exists(int[] ints, int k)
    {
        // sequential search
        /*
        for (int i=0; i<ints.Length; i++)
        {
            if(ints[i] == k){
                return true;
            }
        }
        return false;
        */
        // binary search
        var found = false;
        var size = ints.Length;
        var left = 0;
        var right = size;
        
        while(size > 0)
        {
            if(ExistsRange(ints, k, 0, (int)size/2))
            {
                //exist left
                Console.WriteLine("left");
            }
            else if(ExistsRange(ints, k, (int)size/2, size-1))
            {
                //exist right
                Console.WriteLine("right");
            }    
        }
        
        return found;
    }
    public static bool ExistsRange(int[] ints, int k, int start, int end)
    {
        var min = ints[start];
        var max = ints[end];
        
        if(k > min && k < max)
            return true;
        
        return false;
    }
}


public static object BinarySearchDisplay(int[] arr, int key) {
   int minNum = 0;
   int maxNum = arr.Length - 1;

   while (minNum <= maxNum) {
      int mid = (minNum + maxNum) / 2;
      if (key == arr[mid]) {
         return ++mid;
      } else if (key < arr[mid]) {
         maxNum = mid - 1;
      }else {
         minNum = mid + 1;
      }
   }
   return -1;
}

public static int IntArrayBinarySearch(int[] data, int item) 
{
	 int min = 0;
	 int N=data.Length;
	 int max= N-1;
	 do {
		int mid = (min+max) / 2;
		if (item > data[mid])
		   min = mid + 1;
		else
		   max = mid - 1;
		if (data[mid] == item)
		   return mid;
		//if (min > max)
		//   break;
	 } while(min <= max);
	 return -1;
}

  public static void Main (string[] args)
  {
	 Console.WriteLine ("Please enter some integers, separated by spaces:");
	 string input = Console.ReadLine();
	 string[] integers = input.Split(' ');
	 int[] data = new int[integers.Length];
	 for (int i=0; i < data.Length; i++)
		data[i] = int.Parse(integers[i]);

	 Sorting.IntArrayShellSortBetter(data);
	 while (true) {
		Console.WriteLine("Please enter a number you want to find (blank line to end):");
		input = Console.ReadLine();
		if (input.Length == 0)
		   break;
		int searchItem = int.Parse(input);
		int foundPos = IntArrayBinarySearchPrinted(data, searchItem);
		if (foundPos < 0)
		   Console.WriteLine("Item {0} not found", searchItem);
		else
		   Console.WriteLine("Item {0} found at position {1}", searchItem, foundPos);
	 }
  }

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
Thread.Sleep(2000);
stopwatch.Stop();
TimeSpan stopwatchElapsed = stopwatch.Elapsed;
Console.WriteLine(Convert.ToInt32(stopwatchElapsed.TotalMilliseconds));
