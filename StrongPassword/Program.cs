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

    public static int minimumNumber(int n, string password)
    {
    string numbers = "0123456789";
    string lowerCase = "abcdefghijklmnoprstuvwyz";
    string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string specialCharacters = "!@#$%^&*()-+";

    int count = 0;
    
    if( !numbers.ToCharArray().Any(password.Contains) )
    {
        count++;
    }
    else if( !lowerCase.ToCharArray().Any(password.Contains) )
    {
        count++;
    }
     else if( !upperCase.ToCharArray().Any(password.Contains) )
    {
        count++;
    }
     else if( !specialCharacters.ToCharArray().Any(password.Contains) )
    {
        count++;
    }
    
        return Math.Max( 6 - n, count );
    
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
