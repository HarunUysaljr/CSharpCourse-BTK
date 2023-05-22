// ClassPropertyType

// Sınıf --> İsmi - Ders - Eğitmen Adı - eğitmen Soyadı - Eğitmen Alanı - Öğr Sayısı
//Eğitmen --> Eğitmen Adı - Eğitmen Soyadı - Eğitmen Alanı

using ClassPropertyType.Models;

egitmen egt = new egitmen()
{
    Ad = "harun",
    soyAd = "uysal",
    Alani = "ortaya karışık"
};

Sinif snf = new Sinif()
{
    İsim = "yzl8144",
    Ders = "yazılım ve verit",
    Egitmen = egt,

    OgrSayisi = 8
};

Console.WriteLine(snf.Ders);
Console.WriteLine(snf.Egitmen.Ad);


