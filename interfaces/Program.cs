
PersonManager manager = new PersonManager();

Customer customer = new Customer
{
    ıd = 1,
    ad = "Harun",
    soyAd = "Uysal"
};

manager.Add(new Worker { ıd = 3, ad = "İbrahim", soyAd = "Uysal", });

manager.Add(customer);

Student student = new Student
{
    ıd = 2,
    ad = "Ajda",
    soyAd = "Pekkan"

};

manager.Add(student);

Console.ReadLine();


interface Iperson
{

    int ıd { get; set; }
    string ad { get; set; }
    string soyAd { get; set; }
}

class Customer : Iperson
{
    public int ıd { get; set; }
    public string ad { get; set; }
    public string soyAd { get; set; }
}


class Student : Iperson
{
    public int ıd { get; set; }
    public string ad { get; set; }
    public string soyAd { get; set; }
}
class Worker : Iperson
{
    public int ıd { get; set; }
    public string ad { get; set; }
    public string soyAd { get; set; }
}

class PersonManager
{
    public void Add(Iperson person)
    {
        Console.WriteLine(person.ad);
    }
}


