using System; 
namespace octalBrojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            string decOctalConv(int unos)
            {
                string konv = "";
                while (unos != 0)
                {
                    konv = konv.Insert(0, (((double)unos / 8 - Math.Truncate((double)unos / 8)) * 8).ToString());
                    unos /= 8;
                }
                return konv;
            }
            Console.Write("Unesite broj dekadnog sistema: ");
            Console.WriteLine($"Broj u oktalnom sistemu: {decOctalConv(Int32.Parse(Console.ReadLine()))}");
        }
    }
}
