using System;
using System.Collections.Generic;

namespace Roman_Numerals
{
    class Program
    {
        //C# Sharp program to convert a given integer value to Roman numerals.
        static void Main(string[] args)
        {
            Console.WriteLine("Unestie prirodan broj: ");
            int input = Int32.Parse(Console.ReadLine());
            Dictionary<int, string> romeDict = new Dictionary<int, string>
            {
                [1] = "I",
                [5] = "V",
                [10] = "X",
                [50] = "L",
                [100] = "C",
                [500] = "D",
                [1000] = "M",
            }; 
            while (input > 0)
            {
                for (int i = input; i < 0; i++)
                { 

                }
            }
        }
    }
} 