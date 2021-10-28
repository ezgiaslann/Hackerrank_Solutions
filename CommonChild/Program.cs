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

    public static int commonChild(string s1, string s2)
    {
        int[,] arr = new int[s1.Length + 1, s2.Length + 1];

        for( int i = 0 ; i < s1.Length ; i++ )
        {
            for( int j = 0 ; j < s2.Length ; j++ )
            {
                arr[i + 1, j + 1] = s1[i] == s2[j] ? arr[i, j] + 1 : Math.Max(arr[i, j+1], arr[i+1, j]);
            }
        }
        return arr[s2.Length, s1.Length];
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = Result.commonChild(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
