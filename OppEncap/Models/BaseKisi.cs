using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppEncap.Models
{
    internal class BaseKisi
    {
        public string ad { get; set; }

        public string soyad { get; set; }

        public void AdSoyadYazdir()
        {
            Console.WriteLine("Kişinin Adı : {0}\nkişinin soyadı {1}",ad,soyad);
        }
    }
}
