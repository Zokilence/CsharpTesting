using System;

namespace Reccursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //rekurzija faktorijel
            int faktorijel(int ulaz)
            {
                if (ulaz < 2) return 1;
                return ulaz * faktorijel(ulaz - 1);
            }

            //rekurzija broj karatkera u stringu
            int brKaratkera(string ulaz)
            {
                if (ulaz == null || ulaz == "") return 0;
                return brKaratkera(ulaz.Substring(1)) + 1;
            }

            //rekurzija stepen
            int stepenBroja(int ulazBroj, int ulazStepen)
            { 
                if (ulazStepen == 1) return ulazBroj;
                return ulazBroj * stepenBroja(ulazBroj, ulazStepen - 1);
            }
            Console.WriteLine(stepenBroja(1,6));
        }
    }
}
