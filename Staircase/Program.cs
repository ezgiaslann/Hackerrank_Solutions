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

    public static void staircase(int n)
    {
        for( int i = 1 ; i <= n ; i++ )
        {
            for( int j =  1 ; j <= n - i ; j++ )
            {
                Console.WriteLine(" ");
            }
            for( int t = 1 ; t <= i ; t++ )
            {
                Console.WriteLine("#");
            }
            Console.WriteLine();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
