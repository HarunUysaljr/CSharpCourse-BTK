using InterfaceExampleTwo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleTwo.Concrete
{
    internal class Araba : IAraba
    {
        public void DortluYak()
        {
            Console.WriteLine("dortlu yakıldı");
        }

        public void Dur()
        {
            Console.WriteLine("Durdu");
        }

        public void Hizlan()
        {
            Console.WriteLine("Hizlandı");
        }

        public void KlimaAc()
        {
            Console.WriteLine("Klima Açıldı");
        }

        public void KoltukSogut()
        {
            Console.WriteLine("Koltuk soğutma aktif");
        }

        public void KonarCal()
        {
            Console.WriteLine("Düt");
        }

        public void SunroofAc()
        {
            Console.WriteLine("Sunroof açıldı");
        }

        public void VitesArttir()
        {
            Console.WriteLine("Vites Arttırıldı");
        }

        public void VitesAzalt()
        {
            Console.WriteLine("Vites Azaltıldı");
        }

        public void Yavasla()
        {
            Console.WriteLine("Yavaşladı");
        }
    }
}
