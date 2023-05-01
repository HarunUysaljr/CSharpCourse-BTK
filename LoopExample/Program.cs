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
            //Console.WriteLine("Kaç sayı gireceksin");
            //int kullNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("------------------------");

            //int enBuyuk =0;
            //int enKucuk = 0;
            //int x = 0;

            //for (int i = 1; i < kullNumber; i++)
            //{
            //    Console.WriteLine( " - Sayıyı giriniz ");
            //    x = Convert.ToInt32(Console.ReadLine());

            //    if (enKucuk == 0)
            //        enKucuk = x;
            //        enBuyuk = x;

            //    if (i>enBuyuk)
            //    {
            //        enBuyuk = i;
            //    }
            //    else if (i<enKucuk)
            //    {
            //        enKucuk = i;
            //    }

            //}

            //Console.WriteLine(enBuyuk);
            //Console.WriteLine(enKucuk);


            //// Hocam sağlıklı çalışmıyor olabilir 
            ///


            // Bir döngüden çıkmak istediğinizde kullandığınız keyword -> break;

            // 1'den 10'a kadar olan sayıları saydır.

            //int sayac = 0;

            //while (sayac == 11)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;

            //    if (sayac == 11)  ---> eğer 11 olursa sayac otomatik olarak durdur.
            //    {
            //        break;
            //    }
            //}

            // --------


            //int sayac = 0;

            // do
            // {
            //     Console.WriteLine("test"); 
            //     sayac++;
            // } while (sayac < 6); // --> sayac 6 olduğunda bırak 


            //   Random rnd = new Random();
            //   int rasgele = rnd.Next(0,5);

            //   while (true) {
            //    Console.WriteLine("Sayıyı tahmin et");
            //    int tahmin = Convert.ToInt32(Console.ReadLine()); --> sayı tahmin

            //    if (tahmin == rasgele)
            //    {
            //        Console.WriteLine("doğru");
            //        break;
            //    }

            //}


            //----
            // 100 ile 200 arasında ki sayıların çift ve teklerin toplamını yazdırmak 

            //int tekToplmam = 0, ciftToplam = 0;

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i%2==0)
            //    {
            //        ciftToplam += i;

            //    }
            //    else
            //    {
            //        tekToplmam += i;
            //    }

            //}

            //Console.WriteLine("ciftlerin toplamı : " + ciftToplam);
            //Console.WriteLine("teklerin toplamı : " + tekToplmam);

            //int genelToplam = tekToplmam + ciftToplam;

            //Console.WriteLine(genelToplam);


            //------------------------

            // verilen 5 adet a , b , c değeri için (for)

            // y = (a + b) / c

            // Pozitif y sayılarının ortalamasını istiyorum.

            // c eğer 0 girilirse, c değerinin yeniden istenmesi lazım. (goto)

            // bitiminde bana pozitif y'lerin ortalamasını ekrana basan bir uygulama.

            // a = 5 , b = 10 , c  = -2 --> -7..
            // a = 5 , b = 20 , c = -5 --> -5
            // a = 10 , b = 20 , c = 2 --> 15
            // a = 10 , b =5 , c = 3 -->  5
            // a = 8 , b = 4 , c =2 --> 6

            // pozitif ylerimin toplamı -> 26
            // elimde kaç tane pozitif y var ? -> 3
            // Pozitif y'lerin ortalaması -> 26/3


            int pozitifYtotal = 0;
            int pozitifYsayısı = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("A sayısını gir");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("B yi gir");
                int b = Convert.ToInt32(Console.ReadLine());

 cGoTo:          Console.WriteLine("C yi gir");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c==0)
                {
                    Console.WriteLine("c Sıfır olamaz tekrar gir");
                    goto cGoTo;
                }

                int y = (a + b) / c;

                Console.WriteLine("y ------------------> " + y);
                if (y>0)
                {
                    pozitifYsayısı++;
                    pozitifYtotal = pozitifYsayısı + y;
                }
            }

            int ortalama = pozitifYsayısı / pozitifYtotal;

            Console.WriteLine("s");

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
