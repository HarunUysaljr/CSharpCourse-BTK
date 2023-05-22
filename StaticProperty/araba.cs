using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperty
{
    public static class araba
    {
        public static string Marka { get; set; }
        public  string Model { get; set; }
        public  string Renk { get; set; }


        public static int topla(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
