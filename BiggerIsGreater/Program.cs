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

    public static string biggerIsGreater(string w)
    {
        int start = 0;
        int min = 0;
        bool flag = false;

        for( int i = w.Length - 2 ; i >= 0 ; i-- )
        {
            min = i;
            for( int j = i + 1 ; j < w.Length ; j++ )
            {
                if( w[i] < w[j] )
                {
                    min = j;
                    flag = true;
                }
                if( flag && w[min] > w[j] && w[i] < w[j] )
                {
                    min = j;
                    flag = true;
                }
            }
        if( flag )
        {
            start = i;
            break;
        }
    }
    if( flag )
    {
        string temp3 = w.Substring(min + 1, w.Length - min - 1);
        string temp2 = w.Substring(start, min - start);
        string temp1 = w.Substring(0, start);
        char[] tch = temp2.ToArray<char>();
        Array.Sort(tch);
        temp2 = new string(tch);
        tch = temp3.ToArray<char>();
        Array.Sort(tch);
        temp3 = new string(tch);

        return temp1 + w[min] + temp3 + temp2;
    }
    else
    {
        return "no answer";
    }
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
