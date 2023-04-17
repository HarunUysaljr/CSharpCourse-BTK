using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Şart ifadeleri ile ilgili örnekler.


            // Mini bir hesap makinesi örneği
            //int x;
            //int number;
            //int number1;


            //Console.WriteLine("Bir sayı giriniz : ");
            //number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bir sayı giriniz : ");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Çarpma işmei için 1 , toplama işlemi için 2 ");
            //x = Convert.ToInt32(Console.ReadLine());    

            //if (x==1)
            //{
            //    Console.WriteLine(number1 * number);
            //} else
            //{
            //    Console.WriteLine(number + number1);
            //}



            // Kullanıcının girdiği yaşı Çocuk, Genç, Orta yaş ve yaşlı olarak göster

            //int kulYas;

            //Console.Write("yaşınızı giriniz ;");
            //kulYas = Convert.ToInt32(Console.ReadLine());

            //if (kulYas > 0 && kulYas <= 18 ) {
            //    Console.WriteLine("Gençsiniz");
            //}
            //else if (kulYas > 18 && kulYas <= 26)
            //{
            //    Console.WriteLine("Gençsiniz.");
            //}
            //else if (kulYas > 26 && kulYas <= 50)
            //{
            //    Console.WriteLine("Orta yaş");
            //}
            //else if (kulYas > 50 )
            //{
            //    Console.WriteLine("Yaşlı");
            //}

            //else { Console.WriteLine("Yaşınız 0 ve 0 dan küçük olamaz");
            //}


            // Single line if örneği 
            // kullanıcının yaşına göre mekana girip giremeyeceği örneği


            //int age;

            //Console.WriteLine("Yaşınızı giriniz : ");
            //age = Convert.ToInt32(Console.ReadLine()); 

            //Console.WriteLine(age>=18 ? "Girebilir" : "giremez");


            //


            //iç içe if örnekleri

            // Kullanıcının maaşı asgarinin üzerinde mi üzerindeyse düzey durumu

            //int maasBilgisi;
            //int asgari = 8500;

            //Console.WriteLine("Maaş bilgisi : ");
            //maasBilgisi = Convert.ToInt32(Console.ReadLine());

            //if (maasBilgisi > asgari)
            //{
            //    if (maasBilgisi >= 10000 && maasBilgisi <= 12500)
            //    {
            //        Console.WriteLine("Allah bereket versin");
            //    }
            //    else if (maasBilgisi > 12500 && maasBilgisi <= 18500)
            //    {
            //        Console.WriteLine("iyisin iyi");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Maaşın asgarinin altında bulunmaktadır doğru avrupa");
            //}


            // switch ile hesap makinesi yapımı

            //Console.Write("Hangi işem ? çarpma 1- bölme 2 - toplama 3 - çıkarma 4");
            //int karar = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Birinci sayıyı giriniz : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ikinci sayıyı giriniz : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //switch (karar)
            //{

            //    case 1:
            //        Console.WriteLine(number1 * number2);
            //        break;
           

            //    case 2:
            //        Console.WriteLine(number1 / number2);
            //    break;
           

            //    case 3:
            //        Console.WriteLine(number2 + number1);
            //    break;
          
            //    case 4:
            //        Console.WriteLine(number1 - number2);
            //    break;
            //}


           // Console.ReadLine();

        }
    }
}
