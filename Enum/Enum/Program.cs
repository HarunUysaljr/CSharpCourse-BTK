using Enum.Enums;
using Enum.Models;

Kisi kisi = new Kisi
{
    Ad = "Ali",
    Soyad = "Veli",
    Burc = Burc.Koc,
    Cinsiyet = Cinsiyet.süleymanSoylu
    
};

Console.WriteLine("Kişinin adı " + kisi.Ad);
Console.WriteLine("Kişinin Sadı " + kisi.Soyad);
Console.WriteLine("Kişinin Burcu " + kisi.Burc);
Console.WriteLine("Kişinin Cinsiyet " + kisi.Cinsiyet);

Console.WriteLine("Burcun sayısal karşılığı : " + (int)kisi.Cinsiyet);
