using System;
using System.Collections.Generic;

namespace Roman_Numerals
{
    class Program
    {
       //C# Sharp program to convert a given integer value to Roman numerals.
            Console.WriteLine("Unestie prirodan broj: ");
            Dictionary<int, string> romeDict = new Dictionary<int, string>
            {
                [1000] = "M",
                [500] = "D",
                [100] = "C",
                [50] = "L",
                [10] = "X",
                [5] = "V",
                [1] = "I",
            };
            int input = Int32.Parse(Console.ReadLine()), b = 0, c = 0;
            string final = "", s;
            foreach (var x in romeDict)
            {
                while (input - x.Key >= 0)
                {
                    input -= x.Key;
                    final += x.Value;
                    c += 1;
                    if (c > 3)
                    {
                        final = final.Substring(b, 2);
                        s = final[b].ToString();
                    }
                }
                c = 0;
            }
            Console.WriteLine($"Unos u Rimskim Ciframa: {final}");
Console.ReadKey();
        }
    }
    }}