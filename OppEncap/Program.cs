using OppEncap.Models;

Ogrenci ogren = new Ogrenci()
{
    ad = "ali",
    soyad = "veli",
    OgrenciNo = "123"

};




Console.WriteLine("----------------");

Ogretmen ogretmen = new Ogretmen()
{
    ad = "hande",
    soyad = "veli",
    Maas = 231

};


ogretmen.AdSoyadYazdir();

ogretmen.ogretmenBilgileri();