using OOPBtk;
using OOPBtk_Encapsulation1;

CustomerManager cst = new CustomerManager();


cst.MyProperty = "harun";

Console.WriteLine(cst.MyProperty);

cst.ekranaYazdir();

//Mr Etiketi CustomerManager İçerisinde ki property de bulunan getten return olarak gelmiştir.

//Property olarak tanımladığımı classlarımızdaki get ve set dediğimiz bloklar, encasulation tekniklerinin en temel versiyonu ile kullanılır.

//Encapsulation örnek -> kullanıcı adı ve şifre iste. Kullanıcı adında karakter olamaz, 

uyeKontrol uyekontrol = new uyeKontrol();

Console.WriteLine("Kullanıcı adını giriniz : ");
uyekontrol.LoginName = Console.ReadLine();

Console.WriteLine("Şifre Giriniz : ");
uyekontrol.LoginPass = Convert.ToInt32(Console.ReadLine());



//UyeKontrol uye = new UyeKontrol();
//uye.KullaniciAdi = "fatihalkan*";
//uye.Sifre = "123456";

//Console.WriteLine("Kullanici Adi: {0} - Şifre: {1}", uye.KullaniciAdi, uye.Sifre);

//Console.Read();

//class UyeKontrol
//{
//    private string _kullaniciadi;
//    private string _sifre;

//    public string KullaniciAdi
//    {
//        get
//        {
//            return _kullaniciadi;
//        }

//        set
//        {
//            //İllegal karakterleri kontrol et, harf olmayan bir karakter olması durumunda değer ataması yapma.
//            bool isOK = true;
//            for (int i = 0; i < value.Length; i++)
//            {
//                if (!char.IsLetter(value[i]))
//                {
//                    isOK = false;
//                    break;
//                }
//            }
//            if (isOK)
//            {
//                _kullaniciadi = value;
//            }
//            else
//            {
//                throw new ArgumentException("Kullanıcı Adı Harf Dışında Karakter İçeremez");
//            }
//        }
//    }

//    public string Sifre
//    {

//        get { return _sifre; }
//        set { _sifre = value; }
//    }

//}