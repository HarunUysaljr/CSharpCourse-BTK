using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppEncap.Models
{
    internal class Ogrenci : BaseKisi
    {

        public string OgrenciNo { get; set; }
        
        public void BilgileriGoster()
        {
            AdSoyadYazdir();
            Console.WriteLine(OgrenciNo);
        }
    
    }
}
