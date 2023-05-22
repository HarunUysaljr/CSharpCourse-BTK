//// 10- Bu diziyi büyükten küçüğe ekrana yazdırınız.

//// 11- Kullanıcıdan 2 tane metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

//// 12- Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

//// 13- İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

//// 14- Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

//// 15- 3 Kişinin yaşlarını alıo , en yaşlı olanının yaş bilgisini dönen bir metot yazınız.


//Console.WriteLine("Merhaba"); Console.WriteLine("Nasılsın?"); Console.WriteLine("İyiim"); Console.WriteLine("Sen");

//String sText = "harun"; int number1 = 0; int number2 = 0;

//Random rnd = new Random();

//number1 = rnd.Next(0, 100);
//Console.WriteLine(number1);
//Console.WriteLine("--------------------------");

//Console.Write("Yaşın kaç ");
//number1 = Convert.ToInt32(Console.ReadLine());

//if (number1 > 18)
//{
//    Console.Write(" +");
//}
//else
//    Console.Write(" -");
//Console.WriteLine("--------------------------");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i + " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
//}

//Console.WriteLine("--------------------------");

//int[] diziler = new int[10];

//for (int i = 0; i < diziler.Length; i++)
//{
//    Console.Write(i + " .elemanı gir ");
//    diziler[i] = Convert.ToInt32(Console.ReadLine());
//}

//foreach (int i in diziler)
//{
//    Console.Write(i + " - ");
//}
//Console.WriteLine("");

//Array.Resize(ref diziler, 11);

//Console.WriteLine("11. değeri ekleyiniz ; ");
//diziler[10] = Convert.ToInt32(Console.ReadLine());

//foreach (int i in diziler)
//{
//    Console.Write(i + " - ");
//}

//Array.Sort(diziler); //Küçükten büyüğe doğru sıralama

//foreach (var item in diziler)
//{
//    Console.WriteLine(item  );
//}


string ad = "harun";
string ad2 = "sertan";

string Name = (String)ad.Clone();
Console.WriteLine(ad);
Console.WriteLine(ad2);
Console.WriteLine(Name);

ad = ad2;
ad2 = Name;

Console.WriteLine(ad);
Console.WriteLine(ad2);

Console.ReadLine();