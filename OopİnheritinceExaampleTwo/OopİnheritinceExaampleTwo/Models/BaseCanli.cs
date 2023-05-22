using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopİnheritinceExaampleTwo.Models
{
    internal class BaseCanli
    {

        public int ElSayisi { get; set; }
        public int AyakSayisi { get; set; }

        public string ad { get; set; }


        public void Konus()
        {
            Console.WriteLine("El sayisi" + ElSayisi +" " + "Ayak Sayisi "+AyakSayisi);
        }
    }
}
