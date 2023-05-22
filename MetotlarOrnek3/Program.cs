static int buyukluk(int s, int y)
{
    

    if (s < y)
    {
        
        Console.WriteLine("Büyük olan sayı " + y);
        return y * 2;
    } else
        Console.WriteLine("Buyuk olan sayı : " + s);
    return s * 2;



}

Console.WriteLine("Birinci sayıyı giriniz : ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinici sayıyı giriniz : ");
int number2 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine(buyukluk(number1,number2));

Console.ReadLine();