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
            int[] kvadratiDva = new int[16];
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
            //int brojUnos;
            //Console.ReadLine("Unesite broj dekadnog br. sistema:"+"\n" + brojUnos);
            int broj = 917;
            int[] binarniZapis = new int[1];
            int[] velicinaNiza(int x)
            {
                return binarniZapis = new int[x];
            }
            //-=-=-=-=METODA POPUNJAVANJA NIZA BINARNIM BROJEVIMA-=-=-=-=-=
            int[] popunjavanjeNiza(int broj1, int provera1, bool binaryFormat1, int[] binarniZapis1)
            {
                for (int p = 0; p <= provera1; p++)
                {
                    if (broj1 == kvadratiDva[p])
                    {
                        //   binaryFormat1 = true;
                        binarniZapis1[p] = 1;
                    }
                    else
                    {
                        //  binaryFormat1 = false;
                        binarniZapis1[p] = 2;
                    }
                    //switch (binaryFormat1)
                    //{
                    //    case true:
                    //        binarniZapis1[p] = 1;
                    //        break;
                    //    case false:
                    //        binarniZapis1[p] = 2;
                    //        break;
                    //} 
                }
                return binarniZapis1;
            }
            int provera = 0;
            bool ogranicenje = false;
            for (int i = kvadratiDva.Length - 1; i >= 0; i--)
            {
                bool binaryFormat = false;
                if (broj - kvadratiDva[i] >= 0)
                {
                    broj -= kvadratiDva[i];
                    provera = i;
                    if (ogranicenje == false)
                    {
                        velicinaNiza(provera+1);
                    }
                    ogranicenje = true;
                    popunjavanjeNiza(kvadratiDva[i], provera, binaryFormat, binarniZapis);
                }
                
            }
         }
    }
}