using System;

namespace ZadatakBinarniBrojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisati program kojim se odredjuje broj jedinica
            // u binarnom zapisu prirodnog broja n
            // 5 -> 101b , 6 -> 110b ,  7-> 111b , 8 -> 1000b

            //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=
            //skripta koja u niz dodaje kvadrate dvojke
            int[] kvadratiDva = new int[15];
            kvadratiDva[0] = 1;
            int povecavanjeKvadrata = 1;
          
            for (int i = 1; i < kvadratiDva.Length; i++)
            {
                int a = 1;
                for (int j = 0; j < povecavanjeKvadrata; j++)
                {
                    a *= 2;
                }
                kvadratiDva[i] = a;
               povecavanjeKvadrata++;
            }
            //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=

            int broj = 917;
            int razlika = 0;
            int kolikoKvadrata=0;
            for (int i = 0; i < kvadratiDva.Length; i++)
            {
                razlika = broj - kvadratiDva[i];
                if (razlika < 0)
                {
                    kolikoKvadrata = i-1;  
                    break;
                }
            }

        }
    }
}
