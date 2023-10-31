/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab11B
*/

using System;


class Lab11B
{

    public static void Main(string[] args)
    {
        Console.Write("Enter a password: ");
        string pass= Console.ReadLine();
        bool L_true=false, U_true=false, D_true=false;
        int size = pass.Length;
        char[] pass_array=pass.ToCharArray();
        foreach(char c in pass_array)
        {
            if(c >= '0' && c <= '9')
            {
                D_true = true;
            }
            if(c >= 'A' && c <= 'Z')
            {
                U_true = true;
            }
        }
        if (size >= 8)
        {
            L_true = true;
        }
        if (L_true && U_true && D_true)
        {
            Console.WriteLine("Valid password");
        }
        else
        {
            Console.WriteLine("Invalid password");
        }
        Console.Writeline("Program Ends");
    }
}
