using ArrayListExample.Models;
using System.Collections;

test t1 = new test()
{
    MyProperty = "harun",
    yas = 25,
};

ArrayList liste = new ArrayList();

liste.Add("Merhaba");
liste.Add(123);
liste.Add(true);
liste.Add(t1.MyProperty);
liste.Add(t1.yas);
liste.Add(t1);

foreach (var item in liste)
{
    Console.WriteLine(item);
}