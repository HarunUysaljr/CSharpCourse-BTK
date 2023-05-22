using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppEncap.Models
{
    internal class Ogretmen : BaseKisi

    {
        public decimal Maas { get; set; }

        public void ogretmenBilgileri()
        {
            AdSoyadYazdir();
            Console.WriteLine(Maas);
        }
    }
}
