using System;
using System.Collections.Generic;

class Program
{
	//C# program that uses HashSet for duplicates
	
    public static List<string> RemoveDuplicatesSet(List<string> items)
    {
        // Use HashSet to maintain table of duplicates encountered.
        var result = new List<string>();
        var set = new HashSet<string>();
        for (int i = 0; i < items.Count; i++)
        {
            // If not duplicate, add to result.
            if (!set.Contains(items[i]))
            {
                result.Add(items[i]);
                // Record as a future duplicate.
                set.Add(items[i]);
            }
        }
        return result;
    }

    static void Main()
    {
        var input = new List<string>() { "a", "b", "a", "b", "b", "b", "c" };
        var output = RemoveDuplicatesSet(input);
        Console.WriteLine("Input: " + string.Join(",", input));
        Console.WriteLine("Output: " + string.Join(",", output));
    }
}

Output

Input: a,b,a,b,b,b,c
Output: a,b,c