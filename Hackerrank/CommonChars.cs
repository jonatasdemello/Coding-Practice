/*
3. Question #3
Write a function which takes two string arguments and returns a 
string containing only the common characters found between the two strings.

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

class Solution {

        static string Common(string str1, string str2)
        {
            var s1 = str1.ToCharArray().ToList();
            var s2 = str2.ToCharArray().ToList();

            var res = s1.Intersect(s2).ToList();
            var s = String.Concat(res);

            return s;
        }

    static void Main(string[] args) {
            Console.WriteLine(common("abcd", "cdefg"));
            Console.WriteLine(common("abcde", "edcfvf"));

	}