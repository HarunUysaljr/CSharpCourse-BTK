// Kullanıcıdan şehir adı ve plaka no iste

using ListOrnek1;

sehirler city = new sehirler();


string durum;

while (true)
{

    Console.WriteLine("Plaka kodunu giriniz ");
    city.plakaNo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Sehir bilgisini giriniz : ");
    city.sehir = Console.ReadLine();


    Console.WriteLine("başka şehir girilecek mi");
    durum = Console.ReadLine();
    if (durum == "h")
    {
        break;
    }
}

List<sehirler> citys = new List<sehirler>();

foreach (sehirler s in citys)
{
    Console.WriteLine(s);
}



