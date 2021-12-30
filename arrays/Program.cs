using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] niz =
            { 
                {1,2 },
                {3,4 },
                {5,6 } 
            }; 
            foreach (var item in niz)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
