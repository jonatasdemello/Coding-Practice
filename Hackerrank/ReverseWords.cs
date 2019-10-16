/*
1. Question #1
Write a function that reverses the order of words (not characters) in a sentence. 
Please write production-ready code (including comments).
*/

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'reverse' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING str as parameter.
     */

        public static string reverse(string str)
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

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string str = Console.ReadLine();

        string result = Result.reverse(str);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

