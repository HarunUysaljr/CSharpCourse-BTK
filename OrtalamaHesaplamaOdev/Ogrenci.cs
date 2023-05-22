using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplamaOdev
{
    internal class Ogrenci
    {
        public string ad { get; set; }

        public string soyAd { get; set; }

        public int OgrenciNo { get; set; }

        public double vizeNot { get; set; }

        public int finalNot { get; set; }

        public void OrtalamaHesaplama()
        {
            double ortalama = (vizeNot + finalNot) / 2;
            Console.WriteLine(ad+""+soyAd +" ortalaması " + ortalama);
        }


    }
}
