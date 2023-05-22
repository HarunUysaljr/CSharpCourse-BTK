using Sealed.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed.Concrete
{
    public class Elma : BaseMeyve
    {
        public override void AbstractMethodTest()
        {
            Console.WriteLine("Abstract methot gövdesi");
        }
    }
}
