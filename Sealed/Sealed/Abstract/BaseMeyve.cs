using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed.Abstract
{
    public abstract class BaseMeyve : BaseBitki
    {
        public sealed override void VirtualMethodTest()
        {
            Console.WriteLine("BaseBitki'den gelen metot ezildi meyveler için böyle çalışacak.");
            //Sealed keyword kullanarak, metodun bundan sonraki aşamalarda override edilnesi engellenmiş oldu.
        }
    }
}
