using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBtk
{
    internal class CustomerManager
    {
        string _firstName;
        public string MyProperty { 
            get {
                return "Mr." + _firstName;
            } 
            set { 
                _firstName = value;
            } 
        }


        public void ekranaYazdir()
        {
            Console.WriteLine("test");
        }
    }
}
