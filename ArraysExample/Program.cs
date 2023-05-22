using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Örnek 1: Tanımlanan sayılar dizisi içerisindeki sayıları toplayan c# konsol uygulaması

            //int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int toplam = 0;

            //foreach (int i in number)
            //{

            //    toplam += i;
            //}

            //Console.WriteLine(toplam);

            //Örnek 2: Tanımlanan sayılar dizisi içerisindeki çift sayıları ekrana yazdıran c# konsol uygulaması

            //int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (int i in number)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Örnek 3: Tanımlanan sayılar dizisi içerisindeki pozitif çift sayıları ekrana yazdıran c# konsol uygulaması

            //int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -2, -100, 100 };

            //foreach (int i in number)
            //{
            //    if (i%2==0 && i>0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //// Örnek 4: Tanımlanan sayılar dizisi içerisindeki sayıların negafit, pozitif ve işaretsiz olma durumlarını yanına yazdıran c# konsol uygulaması

            //int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -2, -100, 100,0 };

            //int toplam = 0;

            //foreach (var s in number)
            //{
            //    if (s>0)
            //    {
            //        Console.WriteLine(s + "- pozitif");
            //    }
            //    else if (s<0)
            //    {
            //        Console.WriteLine(s + "- Negatif");
            //    }
            //    else
            //    {
            //        Console.WriteLine(s + " nötr");
            //    }
            //}

            //  int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};  Yanda verilen diziyi tanımlayarak bir döngü yardımıyla aşağıdaki soruları çözünüz.
            /* + sayilar dizisi içerisindeki 3 e bölünebilen değerleri ekrana alt alta yazdırınız
              -  sayilar dizisi içerisinde yer alan elemanları tersten alt alta yazdırınız Hazır fonksiyon kullanmayınız. (Örnek : için 100 den başlayarak 4 e doğru değerler ekrana yazdırılacak)
               + sayilar dizisi içerisinde yeralan elemanlardan kaçtanesi çift , kaçtanesi tek sayı olduğunu bularak sonucu ekrana yazdırınız.
                sayilar dizisi içerisindeki en büyük sayıyı bularak sonucu ekrana yazdırınız.
                sayilar dizisi içerisindeki en büyük negatif sayıyı bularak ekrana yazdırınız.
                sayilar dizisi elamanlarını küçükten büyüğe doğru sıralayarak oluşan yeni sıralamayı ekrana yazdırnız. Hazır fonksiyon kullanmayınız
             */
            //int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };

            //foreach (var s in sayilar)
            //{
            //    if (s%3==0)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //Console.WriteLine("-----");

            //int kacCift = 0, kacTek = 0;

            //foreach (var a in sayilar)
            //{
            //    if (a%2==0)
            //    {
            //        kacCift++;
            //    }
            //    else
            //    {
            //        kacTek++;
            //    }
            //}

            //Console.WriteLine(kacTek);
            //Console.WriteLine(kacCift);


            //Console.WriteLine("---");

            //int enBuyuk = sayilar[0];


            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (enBuyuk > sayilar[i])
            //    {
            //        enBuyuk = sayilar[i];
            //    }
            //}

            //Console.WriteLine(enBuyuk);


            //string[] student = new string[] { "harun", "uysal", "test" };

            //int[] number = new int[] { 2, 3, 4, 5, 6, 7 }; //Tanımlama 1

            //int[] number2;
            //number2 = new int[3]; // Tanımlama 2 

            //--- değer atama 

            //student[0] = "Harun";
            //student[1] = "Uysal";
            //student[2] = "müjgan";
            //student[3] = "ajda";


            //foreach (var s in student) {

            //    Console.WriteLine(s);
            //}

            //int[] number2 = { 22, 12, 50, -3, 5 };

            //Console.WriteLine("--------Sayılar-----------");

            //foreach (int n in number2)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine("------ Küçükten Büyüğe sıralama");

            //Array.Sort(number2);// hazır metod
            //foreach (int n in number2)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine("------- Büyükten küçüğe");

            //Array.Reverse(number2); // ters çevirme metodu
            //foreach (int n in number2)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.ReadLine();


            // Örnek 2

            //int[] sayilar = { 12, 40, 16, 24, 51, 21, 52 };

            ////int enBuyuk = 0;

            ////enBuyuk = sayilar[0];

            ////for (int i = 0; i < sayilar.Length; i++)
            ////{
            ////    if (enBuyuk < sayilar[i])
            ////    {
            ////        enBuyuk = sayilar[i];
            ////    }
            ////}

            //Array.Sort(sayilar);

            //Console.WriteLine("en küçük " + sayilar[0]);

            //Console.WriteLine("En büyük : "+ sayilar[sayilar.Length-1]);

            //string[] ogrenciler = new string[5];

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine("Öğrenci adını giriniz : ");
            //    ogrenciler[i] = Console.ReadLine();

            //}
            //Console.WriteLine("---- alfabetik olarak sıralama");
            //Array.Sort(ogrenciler);
            //foreach (var i in ogrenciler)
            //{

            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("----14 Mayıs seçim sonucu");
            //Random rnd = new Random();
            //int index = rnd.Next(ogrenciler.Length);


            //Console.WriteLine("Cumhurbaşkanı " + ogrenciler[index]);




            //int[] test = { 1, 2};

            //Array.Resize(ref test, test.Length+1);

            //test[test.Length-1] = 3;

            //foreach
            //    (var i in test)
            //{
            //    Console.WriteLine(i);
            //}
            //Random random = new Random();

            //int[] example = new int[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    example[i] = random.Next(0,10);
            //}

            //foreach (var item in example)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.Write("Eklemek istediğiniz sayı");
            //int kulNumber = Convert.ToInt32(Console.ReadLine());

            //Array.Resize(ref example, example.Length+1);
            //example[example.Length - 1] = kulNumber;

            //foreach (var item in example)
            //{
            //    Console.WriteLine(item);
            //}

            int[] test = { 60, 55, 55, 80, 75, 75, 25, 55, 25 };

            A:
            Console.WriteLine("bir sayı giriniz : ");
            int kull = Convert.ToInt32(Console.ReadLine());

            if (kull == 0)
            {
                Console.WriteLine("0 giremezsin yavrucum");
                goto A;
            }

            int adet = 0;

            for (int i = 0; i < test.Length; i++)
            {
                if (kull == test[i])
                {
                    adet++;
                } 
            }

            Console.WriteLine(kull + "  sayısından  " + adet + " adet vardır");


            Console.ReadLine();


        }
    }
}
