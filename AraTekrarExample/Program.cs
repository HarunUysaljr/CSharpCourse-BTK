using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraTekrarExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            toplama toplama = new toplama(); // 2 sayıyı toplama 

            name name = new name(); //İsim soy isim yan yana yazdırma

            Check check = new Check();


            Console.WriteLine("Birinci sayıyı giriniz :  ");
            int sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz : ");
            int say2 = Convert.ToInt32(Console.ReadLine());



            int sonuc = toplama.ornekOne(sayı1, say2);

            Console.WriteLine(sonuc);

            Console.WriteLine("------------------------------------");

            Console.WriteLine("isim giriniz :");
            string ad = Console.ReadLine();

            Console.WriteLine("Soy isim giriniz : ");
            string SoyAd = Console.ReadLine();



            string a = name.Name(ad, SoyAd);

            Console.WriteLine(a);

            Console.WriteLine("------------------------------------");

            Console.WriteLine("Yaşınızı giriniz : ");
            int kulYas = Convert.ToInt32(Console.ReadLine());

            Check.kontrol(kulYas);




            Console.ReadLine();

        }
    }

    class toplama
    {
        public static int ornekOne(int x, int y)
        {
            int toplam = x + y;

            return toplam;
        }
    }


    class name
    {
        public static string Name(string s, string y)
        {


            return s + " " + y;
        }
    }

    class Check
    {


        public static void kontrol(int number1)
        {
            bool durum = true;

            if (number1 < 18)
            {
                durum = false;
                giremez();
            }
            else
            {
                girebilir();
            }

        }

        public static void girebilir()
        {
            Console.WriteLine("girebilir.");
        }

        public static void giremez()
        {
            Console.WriteLine("giremezsin kardeşim.");
        }

    }
}
