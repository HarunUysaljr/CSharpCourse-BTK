using InterfaceExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Concrete
{
    internal class Ucgen : IgeometrikSekil
    {
        public void AlanHesapla()
        {
            Console.WriteLine("Üçgenin alanı hesaplanıyor.");
        }

        public void CevreHesapla()
        {
            Console.WriteLine("Üçgenin Alanı hesaplanıyor.");
        }
    }
}
