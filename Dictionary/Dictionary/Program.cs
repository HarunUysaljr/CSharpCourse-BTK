/*
Dictionary
bir koleksiyon yapıdır
key, value mantığıyla çalışır
bir nevi kendi indeximizi kendimiz belirliyoruz.
 */


Dictionary<int, string> sehirler = new Dictionary<int, string>();

sehirler.Add(0, "adana");
sehirler.Add(1, "istanbul");
sehirler.Add(2, "ankara");
sehirler.Add(3, "Jüpiter");

Console.WriteLine("3 plakalı şehri yazdırın : " + sehirler[3]);

/******************************************************************************/

//bütün şehirler plakalarını ve isimlerini yazdırınız.

Console.WriteLine("Şehirler ; ");

foreach (var item in sehirler)
{
    Console.WriteLine(item.Key +" "+ item.Value);
    

    // ---> Yalnızca itemlere ulaşmak için item.key
    // ---> yanlızca valuelara ulaşmak için item.value
}