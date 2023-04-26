using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // //Döngü Örnekleri

            // // 1 den 10 a kadar olan sayıları ekrana yazdır       

            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine("----");
            // // -22 den 3 e kadar ekrana yazdır
            // for (int i = -22; i < 3; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine("--");
            ////Çift olan sayıları ekrana yazdır

            // //for (int i = 10; i < 100; i+=2) //i değerini 2 şer arttırarak çift olan sayılar yakalanır i+=2
            // //{
            // //        Console.WriteLine(i)   
            // //}

            // Console.WriteLine("--");

            // //Ekrana 10 kere yarınlar daha güzel olacak
            // // 1-40 arası sayıların toplamı 
            // // 20 ile 30 arasında ki toplamı

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Yarınlar Daha Güzel olacak");

            //}

            //int toplam = 0;

            //for (int i = 1; i <= 40; i++)
            //{

            //    toplam += i;

            //}

            //Console.WriteLine(toplam);

            //toplam = 0;

            //for (int i = 20; i <= 30; i++)
            //{
            //    if (i%2==0)
            //    {
            //        toplam +=i;
            //    }
            //}

            //Console.WriteLine(toplam);

            //Console.ReadLine();



            // Kullanıcıdan alınan sayının faktoriyel
            //Console.WriteLine("Bir sayı giriniz : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int toplam = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    toplam = toplam * i;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            //Console.WriteLine("bir sayı giriniz : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine("****************");
            //}

            //string x = "*";

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(x);
            //    x = x + "*";

            //}
            //string y = "*";

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(y);
            //    y = y + "**";
            //}

            //Ekrana 5 kere "Düm tek tek yazdır
            // Kullanıcının girdiği sayıda hadi deli oğlan döngü
            // 1 - 10 a kadar yazdır
            // 15 -25 arası topla

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Düm tek tek");
            //}

            //Console.WriteLine("---");

            //Console.WriteLine("Sayı gir :");
            //int x = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine("Hadi deli oğlan");
            //}
            //Console.WriteLine("---");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("----");

            //int toplam = 0;
            //for (int i = 15; i <= 20; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            Console.WriteLine("kaçtan ? ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kaça ?");
            int y = Convert.ToInt32(Console.ReadLine());

          


            if (x>y)
            {
                for (int i = x; i < y; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            else if (y>x)
            {
                  for (int i = y; i > x; i--)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
            }

            Console.ReadLine();
        }
    }
}
