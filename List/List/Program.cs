// generic list

// List<T>

// Generic -> hangi deüişken tiği verilirse, ona göre oluşur

// Generic -> T -> Type

using List;

List<int> sayilar = new List<int>();

sayilar.Add(3);
sayilar.Add(4);
sayilar.Add(5);
sayilar.Add(-1);

//Bir listedeki eleman sayısı
Console.WriteLine(sayilar.Count);
Console.WriteLine("---------------------------");
//elemanları yazdırma

foreach (int i in sayilar)
{
    Console.WriteLine(i);
}
Console.WriteLine("---------------------------");


//Eleman çıkarma

sayilar.Remove(5);
sayilar.RemoveAt(2); // -> index e göre silme
foreach (int i in sayilar)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------------");

List<string> sehirler = new List<string>();

sehirler.Add("İstanbul");
sehirler.Add("Ankara");
sehirler.Add("İzmir");

foreach (string s in sehirler)
{
    Console.WriteLine(s);
}


Console.WriteLine("---------------------------");

Musteri musteri = new Musteri()
{
    ad = "Ali",
    Soyad = "veli",
    AldigiUrunSayisi = 2,
    telno = "21313",
};

Musteri musteri2 = new Musteri()
{
    ad = "CCCC",
    Soyad = "ahmet",
    AldigiUrunSayisi = 3,
    telno = "1231231",
};

Musteri musteri3 = new Musteri()
{
    ad = "AAA",
    Soyad = "haydar",
    AldigiUrunSayisi = 0,
    telno = "6123",
};

List<Musteri> Customer = new List<Musteri>();

Customer.Add(musteri);
Customer.Add(musteri2);
Customer.Add(musteri3);

// bütün müşterilerin adını yazdırma
// ürün alamyan müşterilerin adını yazdırma

foreach (var item in Customer)
{
    Console.WriteLine(item.ad);
}


foreach (var item in Customer)
{
    if (item.AldigiUrunSayisi == 0)
    {
        Console.WriteLine(item.ad + item.Soyad + item.telno + item.telno);
    } else
        Console.WriteLine("Hiç ürün almayan yok");
}
