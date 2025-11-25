using System;
using System.Collections.Generic;
using System.IO;

class ReverseWords
{
    /*
    1. Question #1
    Write a function that reverses the order of words (not characters) in a sentence. 
    Please write production-ready code (including comments).
    */
    public string reverse(string str)
    {
        var strArr = str.Split(' ');
        var strNew = new List<string>();

        for (var i = strArr.Length-1; i >= 0; i--)
        {
            strNew.Add(strArr[i]);
        }
        var newStr = strNew.ToArray();
        var res = string.Join(" ", newStr);
        return res;
    }

}


