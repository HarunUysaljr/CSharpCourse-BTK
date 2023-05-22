using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBtk_Encapsulation1
{
    internal class uyeKontrol
{

        private string _LoginName="";
        private int LoginPassword;
        public string LoginName { 
            get {
                return _LoginName;    
            } 
            set {
                bool statusOk = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        statusOk = false;
                        break;
                    }
                }
                if (statusOk)
                {
                    _LoginName = value;
                } else { Console.WriteLine("Özel karakter olmaz"); }
            } 
        }

        public int LoginPass {
            get { return LoginPassword; }
            set { LoginPassword = value; } }
    }
}
