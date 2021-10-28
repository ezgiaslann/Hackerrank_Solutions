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

    public static string gameOfThrones(string s)
    {
        int a = 0;
        int b = 0;
        string letters =  "abcdefghijklmnopqrstuvwxyz";

        for( int i = 0 ; i < 26 ; i++ )
        {
            int c = 0;
            for( int j = 0 ; j < s.Length ; j++ )
            {
                if( letters[i] == s[j] )
                {
                    c++;
                }
            }
            if( c %2 == 0 )
            {
                b++;
            }
            else{
                a++;
            }
        }
        if( a <= 1 )
        {
            return "YES";
        }
        else if( a == 2 && s.Length % 2 == 0 )
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
