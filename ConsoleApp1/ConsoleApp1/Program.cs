////Console.WriteLine("Üçgenin boyutunu giriniz :");
////int x = Convert.ToInt32(Console.ReadLine());

////for (int i = 0; i < x; i++)
////{
////    for (int z = 0; z < i; z++)
////    {
////        Console.Write("*");
////    }
////    Console.WriteLine();
////}

////Console.ReadLine();

//Console.WriteLine("Kaç adet fibo olacak.");
//int kul = Convert.ToInt32(Console.ReadLine());

//int a =1;
//int b = 1;
//int c= 0;
//int ort;

//for (int i = 1; i <= kul; i++) /* 8 adet sayıyı üst üste toplayarak gidecektir. Eğer burada sekiz yerine faklı rakam yazarsak o kadar toplama yapacaktır. */
///* ekran çıktısında başta alt alta 1 1 yazacaktır a ve b ye 1 değerlerine 1 verdiğimiz için */
///* 1+1= 2 daha sonra her çıkan sonuçlar bir önceki değeri toplayarak gidecektir. */
//{
//    c = a + b;
//    a = b;
//    b = c;

//    Console.WriteLine(c);
//}

//    ort = (c/ kul);
//Console.WriteLine(ort);
//Console.ReadLine();


back:
double radius;
double thickness = 0.2;
Console.WriteLine("Lütfen 0 tam büyük  bir tamsayı  yarıçap giriniz: ");

if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
    goto back;

Console.WriteLine();
double innerCircle = radius - thickness;
double outerCircle = radius + thickness;

/*çemberin iki tarafı olduğu için koordinat eksenine göre + ve - tarafları olacaktır bu  yüzden yarıçaptan başlayayıp 0 'a oradan da 
 -radiusa inerek çemberi tamamlar*/
for (double y = radius; y >= -radius; --y)
{
    for (double x = -radius; x < outerCircle; x += 0.5)
    {
        /*Çemberin çiziminde olan formül iç çember ve dış çembere göre belirlenir
         * Eğer hesaplanan nokta, çemberin içindeyse, yani x^2 + y^2 <= radius^2 ise "*" karakteri yazdırılır
         * değilse boşluk karakteri yazdırılır.  */
        double value = x * x + y * y;
        if (value >= innerCircle * innerCircle && value <= outerCircle * outerCircle)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
Console.ReadKey();