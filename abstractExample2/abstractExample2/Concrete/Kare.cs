using InterfaceExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Concrete
{
    internal class Kare : IgeometrikSekil
    {
        public void AlanHesapla()
        {
            Console.WriteLine("Karenin Alanı hesaplanıyor");
        }

        public void CevreHesapla()
        {
            Console.WriteLine("Karenin Çevresi Hesaplanıyor");
        }


    }
}
