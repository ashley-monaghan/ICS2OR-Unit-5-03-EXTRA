// Created by: Ashley Monaghan
// Created on: Nov 2022
//
//This program tells you what age rating you can see

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int userAge;

        Console.WriteLine("What age rated are you allowed to watch?");
        Console.WriteLine("");

        Console.Write("Enter your age to find out: ");
        Console.WriteLine("");
        userAge = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine(" ");
        if (userAge >= 17)
        {
            Console.WriteLine("You can see G, PG and R rated movies!");
        }
        else if (userAge >= 13)
        {
            Console.WriteLine("You can see G and PG rated movies!");
        }
        else if (userAge <= 12)
        {
            Console.WriteLine("You can see G rated movies!");
        }
        else
        {
            Console.WriteLine("Error!");
        }

        Console.WriteLine("\nDone.");
    }
}