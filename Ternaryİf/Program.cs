using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternaryİf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // //Ternary İf 
            //int number = 10;
            // Console.WriteLine(number == 10 ? "sayı 10'a eşit " : "Sayı 10 değil" );
            // Console.ReadLine();

            Console.WriteLine("Sayı giriniz :");
            int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(x%2==0 ? "Çifttir " : " Sayı tektir");

            //Console.ReadLine();

            Console.WriteLine(x>10 && x%2==0 ? "10'dan büyük ve Çift " : "Tek veya 10 dan küçüktür");

            Console.ReadLine();

        }
    }
}
