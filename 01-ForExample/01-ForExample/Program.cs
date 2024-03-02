//int toplam = 0;


//for (int i = 0; i < 10; i++)
//{
//    if (i % 2 == 0) //0-10 arasında çift olan sayıların toplamını yazdırır
//    {
//        toplam += i;
//    }
//}
//Console.WriteLine(toplam);

//Console.ReadLine();

// ----------------------------------------------------------------------------------------

//string[] isimler = { "Arda", "harun", "uysal" };

//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler[i]); bir dizi içerisinde ki isimleri sırasıyla yazdırma / i yazan yere 2 yazılsaydı şayet uysal yazardı.
//}

// ----------------------------------------------------------------------------------------

//int start = 0;
//int stop = 0;
//int artısMiktarı = 0;




//Console.WriteLine("Başlangıç Sayısını Gir");
//start = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Bitiş Sayısını Gir");
//stop = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("artıs miktarını Sayısını Gir");
//artısMiktarı = Convert.ToInt32(Console.ReadLine());

//int sayac = 0;
//int toplam = 0;

//for (int i = start; i < stop; i = i + artısMiktarı)
//{
//    sayac++;
//    toplam += i;
//    Console.WriteLine($"{sayac}.sayı : {i}");
//}

//Console.WriteLine("toplam : " + toplam);

//int[] sayilar = { 1, 2, 4, 5, 6, 7, 8, 3, 2, 5, 25, 2, 35, 14, 662, 726, };

//for (int i = 0; i < sayilar.Length; i++)
//{
//	if (sayilar[i]%3==0)
//	{
//        Console.WriteLine(sayilar[i]);
//    }
//}

//int[] sayilar = { 1, 2, 4, 5, 6, 7, 8, 3, 2, 5, 25, 2, 35, 14, 662, 726, };

//int toplam = 0;

//for (int i = 0; i < sayilar.Length; i++)
//{
//    toplam += sayilar[i];
//}

//Console.WriteLine(toplam);

string[] markalar = {"opel", "mercedes" , "bmw", "jetta"};

for (int i = 0; i < markalar.Length; i++) 
{
    if (markalar[i].Length >= 5)
    {
        Console.WriteLine(markalar[i]);
    }
}