using System;

namespace zadatakNizoviPremestanje
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Premestiti elemente niza tako da neprani brojevi budu na pocetku
             Parni na kraju niza*/
            // 1, 3, 2, 5, 6, 8, 9, 4 -> 2,6,8,4,1,3,5,9

            Random rand = new Random();
            int[] niz = new int[9];
            for (int i = 0; i < 9; i++)
            {
                niz[i] = rand.Next(1, 51);
            }

            //main
            int a = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    int temp1 = niz[a];
                    niz[a] = niz[i];
                    niz[i] = temp1;
                    a++;
                }
            }
        }
    }
}
