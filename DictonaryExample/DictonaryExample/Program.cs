using DictonaryExample.Models;


Dictionary<string, Kisi> kisiler = new Dictionary<string, Kisi>();


Kisi kisi1 = new Kisi()
{
    Ad = "harun",
    SoyAd = "uysal",
    TcNo = 123456,
};


Kisi kisi2 = new Kisi()
{
    Ad = "ali",
    SoyAd = "veli",
    TcNo = 1234567,
};

Kisi kisi3 = new Kisi()
{
    Ad = "Ajda",
    SoyAd = "Pekkan",
    TcNo = 12345678,
};

kisiler.Add(kisi1.TcNo, kisi1);

