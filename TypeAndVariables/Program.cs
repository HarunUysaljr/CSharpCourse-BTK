using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1 = 1000000000;
            long number2 = 1000000000; // bir milyar ve üzeri - 19 karakter alabilir
            short number3 = 31111; // 16 bitlik -33k ve 33k arası
            byte number4 = 14; // 8bitlik - 0 ve 255 arası değer
            bool durum = true; //şart doğruysa şunu değilse şunu yap
            char character = 'f';
            double number5 = 10.6;
            var number6 = 6;
            var number7 = "harun";



            Console.WriteLine(Days.Pazartesi);
            Console.WriteLine(number6);
            Console.WriteLine(number7);


            Console.ReadLine();

            
        }
    }

    enum Days
    {
        Pazartesi,Salı,Çarşamba,Perşembe
    }
}
