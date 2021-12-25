using System;

namespace CSharpTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] brojevi = new int[5];

            for (int i = 0; i < brojevi.Length; i++)
            {
                brojevi[i] = rand.Next(0, 31);
            }
            { }
            //rastuci   1,3,5,2,4,6 -> 6,5,4,3,2,1 
            for (int i = 0; i < brojevi.Length; i++)
            {
                for (int j = 0; j < brojevi.Length; j++)
                {
                    if (brojevi[j] < brojevi[i])
                    {
                        int temp1 = brojevi[i];
                        int temp2 = brojevi[j];
                        brojevi[j] = temp1;
                        brojevi[i] = temp2;
                    }
                }
            }
            foreach (var cifra in brojevi)
            {
                Console.WriteLine(cifra.ToString());
            }
            Console.ReadLine();
        }
    }
}