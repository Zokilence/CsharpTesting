using System;

namespace CSharpTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] niz = new int[5];

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rand.Next(0, 31);
            }
            { }
            /*
            //rastuci   1,3,5,2,4,6 -> 6,5,4,3,2,1 
            for (int i = 0; i < niz.Length; i++)
            {
                for (int j = 0; j < niz.Length; j++)
                {
                    if (niz[j] < niz[i])
                    {
                        int temp1 = niz[i];
                        int temp2 = niz[j];
                        niz[j] = temp1;
                        niz[i] = temp2;
                    }
                }
            }
            */
            //Bubble Sort - Rastuci
            bool provera = false;
            int temp;

            while (provera==false)
            {
                for (int i = 0; i < niz.Length-1; i++)
                { 
                    if (niz[i+1] < niz[i])
                    {
                        temp = niz[i+1];
                        niz[i + 1] = niz[i];
                        niz[i] = temp; 
                    }
                }
                provera = true;
                for (int k = 0; k < niz.Length-1; k++)
                {
                    if (niz[k+1] < niz[k])
                    {
                        provera = false;
                    }
                }
            }
             

            foreach (var cifra in niz)
            {
                Console.WriteLine(cifra.ToString());
            }
            Console.ReadLine();
        }
    }
}