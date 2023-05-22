using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            merhabaYaz();

            Console.WriteLine("Büyük yazılmasını istediğiniz kelimeyi yazınız");
            string byk = Console.ReadLine();

            nameSname(byk);

            Console.WriteLine("İşlem Yapmak istdiğiniz sayıyı gir");
            int x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("İşlem Yapmak istdiğiniz sayıyı gir");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(hesaplama(x, y));

            Console.WriteLine("Kdv si hesaplanacak tutarı giriniz : ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(kdv(x1));

            int q = 10, w = 20, r = 30;


          

            Console.ReadLine();
        }

        static void merhabaYaz()
        {
            Console.WriteLine("Hoş geldiniz!");
        }

        static string nameSname(string name)
        {
            Console.WriteLine(name.ToUpper());

            return name;
        }

        static int hesaplama(int x, int y)
        {

            int toplam = x + y;

            return toplam;
        }

        static double kdv(double x, double y = 0.18)
        {
            double hesapla = x * y;


            return hesapla;
        }

        static int hesaplama(int x, int y, int t)
        {


            int toplam = x + y;

            return toplam;
        }

    }
}
