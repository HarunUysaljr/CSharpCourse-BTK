using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            hello();

            string test = Merhaba();

            

        }

        static void hello()
        {
            Console.WriteLine("S.a");

        }

        static string Merhaba()
        {

            return "merhaba";
        }

        string kullanıcıText()
        {
            Console.WriteLine("bir metin giriniz : ");
            string s = Console.ReadLine();

            return s;
        }

        static string metotTheere(string s)
        {
            Console.WriteLine("bir yazı giriniz  :");
            s = Console.ReadLine();


            return s;
        
        
        }

    }
}
