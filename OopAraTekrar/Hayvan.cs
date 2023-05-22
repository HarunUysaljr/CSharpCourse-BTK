using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAraTekrar
{
    internal class Hayvan
    {
        public Hayvan()
        {
            Console.WriteLine("bir hayvan oluşturuldu");

        }

        public Hayvan(int id)
        {
            Id = id;
            Console.WriteLine("id si" + id + " olan bir hayvan oluşturuldu");
        }

    


        public int Id { get; set; }
        public string Name { get; set; }
        public string Tur { get; set; }

        public int Yas { get; set; }

        public void bilgileriGoster()
        {
            Console.WriteLine("Id - > " + Id);
            Console.WriteLine("Name - > " + Name);
        }
    }

}
