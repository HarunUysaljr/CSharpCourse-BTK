using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketExample7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int begenenler = 0, begenmeyeler = 0, kararsizlar = 0;

         soru:   Console.WriteLine("Beğendin mi :  e / h / k");
            string cevap = Console.ReadLine();

            switch (cevap)
            {

                case "e":
                    begenenler++;
                    break;


                case "h":
                    begenmeyeler++; break;

                case "k":
                    kararsizlar++; break;
            }


            Console.WriteLine("Ankete katılacak başka bir kullanıcı var mı ? v / y");
            cevap = Console.ReadLine();

            switch (cevap)
            {
                case "v":
                    goto soru;
                    break;

                case "y":
                    Console.WriteLine("Sonuçlar ; ");
                    Console.WriteLine("Beğenenler : " + begenenler);
                    Console.WriteLine("Beğenmeyenler : " + begenmeyeler);
                    Console.WriteLine("Kararsizlar : " + kararsizlar);
                    Console.WriteLine("toplam : " + (begenenler+begenmeyeler+kararsizlar));
                    break;
            }
        }
    }
}
