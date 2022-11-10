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
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
       
        Stack<char> myStack = new Stack<char>();
        string sqbra="[";
        string par="(";
        string bra="{";
        
        string csqbra="]";
        string cpar=")";
        string cbra="}";
        
        foreach(char letter in s){
            if(letter==sqbra[0]|letter==par[0]|letter==bra[0]){
               myStack.Push(letter);
            }
            
            if(letter==csqbra[0]|letter==cpar[0]|letter==cbra[0]&&myStack.Count==0){
                return "NO";
            }
            
            if(s.Count()%2!=0) return "NO";
            
             if(letter==csqbra[0]&&myStack.Peek()==sqbra[0]){
                 myStack.Pop();
             }
             if(letter==cpar[0]&&myStack.Peek()==par[0]){
                 myStack.Pop();
             }
             if(letter==cbra[0]&&myStack.Peek()==bra[0]){
                 myStack.Pop();
             }
        }
        Console.WriteLine(myStack.ToArray());
       if(myStack.Count>0) return "NO";
        return  "YES";  
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
