using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ad = "harun"; //Arka planda charlar ile array oluşturur. index 0 h harfine denk gelir

            //foreach (var item in ad) {
            //    Console.WriteLine(item);
            //}

            //string adTwo = "uysal";

            //Console.WriteLine(string.Format("{0} {1}",ad,adTwo));

            string sentece = "Harun UYSAL";
            string sentecetwo = "Ankara";


            Console.WriteLine("string.format iki ismi birleştirme");
            Console.WriteLine(String.Format(sentece, sentecetwo));
            Console.WriteLine("--------");


            Console.WriteLine("string.length uzunluk");
            var result = sentece.Length;
            Console.WriteLine(result);
            Console.WriteLine("--------");

            Console.WriteLine("string.clone kopyasını oluşturma, Aslı değişsede kopya kalır");
            var result2 = sentece.Clone();
            Console.WriteLine(result2 + "sentece olarak değil result olarak yazdırıldı");
            Console.WriteLine("--------");

            Console.WriteLine("string.StartsWith Hangi harf ile başlıyor bulma");
            bool result3 = sentece.StartsWith("H");
            Console.WriteLine(result3);
            Console.WriteLine("başlıyorsa 1 ile döner");
            Console.WriteLine("--------");

            Console.WriteLine("string.EndsWith Hangi harf ile bitiyor bulma");
            bool result4 = sentece.EndsWith("n");
            Console.WriteLine(result4);
            Console.WriteLine("bitiyorsa 1 ile döner");
            Console.WriteLine("--------");

            Console.WriteLine("String.IndexOf kaçıncı indexde başladığını bulma");
            var result5 = sentece.IndexOf("UYSAL");
            Console.WriteLine(result5);
            Console.WriteLine("-------------------");


            Console.WriteLine("String.LastIndexOf tersten bakarak kaçıncı index olduğu");
            var result6 = sentece.LastIndexOf("HARUN");
            Console.WriteLine(result6);
            Console.WriteLine("---------");


            Console.WriteLine("String.Insert cümlenin belirli bir yerine bir şey eklemek için kullanılır");
            var result7 = sentece.Insert(0, "Eklenen ");
            Console.WriteLine(result7);
            Console.WriteLine("-------");

            Console.WriteLine("String.Substring metni parçalar belirli bir indexten sonrasını yada belirli bir indexten sonra belirli indexi almaz");
            var result8 = sentece.Substring(2, 3);
            Console.WriteLine(result8);
            Console.WriteLine("------");


            Console.WriteLine("String.ToLower hepsini küçük yazar");
            var result9 = sentece.ToLower();
            Console.WriteLine(result9);
            Console.WriteLine("------");

            Console.WriteLine("String.Toupper hepsini büyük yazar");
            var result10 = sentece.ToUpper();
            Console.WriteLine(result10);
            Console.WriteLine("--------");

            Console.WriteLine("String.Replace değiştirilmek istenilen metni değiştirir");
            var result11 = sentece.Replace(" ", "-");// boşlukları - ile değiştirir.
            Console.WriteLine(result11);
            Console.WriteLine("-------");

            Console.WriteLine("String.Remove belirli bir indexten sonrasını yada belirli bir index ve arasını atmak için kullanılır");
            var result12 = sentece.Remove(2, 3);
            Console.WriteLine(result12);
            Console.WriteLine("------");

            

            Console.ReadLine();
        }
    }
}
