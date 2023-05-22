// Hazır metotlar


//string ornekMetin = "harun";

// //İki metni karşılaştırma için kullanılır. Aynı ise 0 döner değilse alfabetik sıraya göre bakar ve 1 veya -1 yazar

//int sonuc = ornekMetin.CompareTo("Bilge Adam");

//if (sonuc == 0)
//{
//    Console.WriteLine("Aynı");
//} else
//    Console.WriteLine("Değil");


//bool varMi = ornekMetin.Contains("Bilge");

//if (varMi==true)
//    Console.WriteLine("Bilge metin içerisinde geçiyor");
//else
//    Console.WriteLine("Geçmiyor");


//bool result = ornekMetin.StartsWith("h"); 
//bool resultTwo = ornekMetin.EndsWith("h");

//Console.WriteLine(result ? "h ile başlıypr " : "h ile başlamıyor");

//Console.ReadLine();


// ------------- Math METOTARI -----------------------


//double x = Math.PI;

//Console.WriteLine(DateTime.Now.ToShortDateString());


//Console.WriteLine(DateTime.Now.ToLongTimeString());


//DateTime newTıme = new DateTime(1997, 03,29,00,01,00);


//TimeSpan zamanFarkı = DateTime.Now - newTıme;

void example(string kul)
{
    //int sonuc = kul.CompareTo("hdfilmcehennemi");

    kul = kul.ToLower();

    bool varMi = kul.Contains("hdfilmcehennemi");

    if (varMi == true)
        Console.WriteLine("Yaşasın Kaçak");
    else
        Console.WriteLine("Püh Rezil");
    

    //if (sonuc == 0)

    //    Console.WriteLine("YAŞASIN KAÇAK");
    //else
    //    Console.WriteLine("PÜH REZİL");

}

Console.WriteLine("bir metin giriniz : ");
string s = Console.ReadLine();


example(s);

Console.ReadLine();