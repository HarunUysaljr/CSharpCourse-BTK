// Nesne Yönelimli programlama her işlevin nesneler olarak soyutlandığı bir promgramlama yaklaşımıdır

// class-Sınıf kullanımıyla uygulanır.


// CLASS -> BİR NESNEYİ OLUŞTURMA ŞABLONUDUR
//Nesne oluşturmak --> clası newlemek - instance almakkk

using OopAraTekrar;



Hayvan hayvan = new Hayvan();
Hayvan hayvan2 = new Hayvan();
Hayvan hayvan3 = new Hayvan();
Hayvan hayvan4 = new Hayvan(4);


hayvan.Id = 1;
hayvan.Name = "test";
hayvan.Tur = "As";
hayvan.Yas = 23;

Console.WriteLine(hayvan.Name);

Console.WriteLine("-------------------------");

hayvan2.Id = 2;
hayvan2.Name = "eee";
hayvan2.Tur = "sss";
hayvan2.Yas = 3;


hayvan.bilgileriGoster();



