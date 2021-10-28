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
    public static int makingAnagrams(string s1, string s2)
    {
        int[] temp = new int[26];
        for(int i = 0 ; i < s1.Length ; i++ )
        {
            temp[s1[i] - 97]++;
        }
        for(int i = 0 ; i < s2.Length ; i++ )
        {
            temp[s2[i] - 97]--;
        }
        int count = 0;
        for(int i = 0 ; i < 26 ; i++ )
        {
            count += Math.Abs(temp[i]);
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = Result.makingAnagrams(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
