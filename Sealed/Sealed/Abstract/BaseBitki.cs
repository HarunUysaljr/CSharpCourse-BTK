using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed.Abstract
{
    public abstract class BaseBitki
    {
        public abstract void AbstractMethodTest();
        //Miras Alaınınca override edilecek gövdesi burada doldurulmaz
        public virtual void VirtualMethodTest()
            //Miras Alınanca gerekirse override edilecek. Metoda ilavede yapılabilir tamamen değiştiriledebilir.
        {
            Console.WriteLine("Ben bir virtual metodum");
        }

    }
}
