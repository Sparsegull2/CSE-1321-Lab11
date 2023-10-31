/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab11A
*/

using System;


class Lab11A
{

    public static void Main(string[] args)
    { string cont = "no";
        do
        {
            Console.WriteLine("Menu \n0) Hello World \n1) Goodbye Moon \n2) Walking on Sunshine");
            Console.Write("\nWhat would you like to do: ");
            int choice= int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 0: Console.WriteLine("\nHello!");break;
                    case 1: Console.WriteLine("\nOk, bye.");break;
                    case 2: Console.WriteLine("\nWHOA!");break;
                    default: Console.WriteLine("\nInvalid choice");break;
            }
            Console.Write("\nType YES to rerun. ");
             cont= Console.ReadLine();
            cont=cont.ToLower();
        }while (cont=="yes");
        Console.WriteLine("Program Ends");
    }
    
}
