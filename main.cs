// Created by: Kenny Le
// Created on: May 2022
//
// This program determines the type of triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function determines the type of triangle
        double lengthOne;
        double lengthTwo;
        double lengthThree;

        // input
        Console.WriteLine("This program determines the type of triangle.");
        Console.WriteLine("Please input the lengths of the triangle");

        Console.WriteLine("");
        Console.Write("Input the first length (cm): ");
        lengthOne = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input the second length (cm): ");
        lengthTwo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input the third length (cm): ");
        lengthThree = Convert.ToDouble(Console.ReadLine());

        // process and output
        if ((lengthOne <= 0) || (lengthTwo <= 0) || (lengthThree <= 0))
        {
            Console.WriteLine("");
            Console.WriteLine("You can't have negative length! Please input only positive numbers.");
        }
        else
        {
            if ((lengthOne == lengthTwo) && (lengthTwo == lengthThree))
            {
                Console.WriteLine("It is an equilateral triangle!");
            }
            else if ((lengthOne == lengthTwo) || (lengthOne == lengthThree) || (lengthTwo == lengthThree))
            {
                Console.WriteLine("It is an isosceles triangle!");
            }
            else
            {
                Console.WriteLine("It is a scalene triangle!");
            }
        }

        Console.WriteLine("\nDone.");
    }
}