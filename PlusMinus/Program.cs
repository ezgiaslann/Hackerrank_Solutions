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

    public static void plusMinus(List<int> arr)
    {
        float negNumbers = 0;
        float pozNumbers = 0;
        float zeroNumbers = 0;

        for( int i = 0 ; i < arr.Count ; i++ )
        {
            if( arr[i] > 0 )
            {
                pozNumbers++;
            }
            else if( arr[i] < 0 )
            {
                negNumbers++;
            }
            else if( arr[i] == 0 )
            {
                zeroNumbers++;
            }
        }
        Console.WriteLine( pozNumbers / arr.Count );
        Console.WriteLine( negNumbers / arr.Count );
        Console.WriteLine( zeroNumbers / arr.Count );
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
