int sayi;
Console.BackgroundColor = (ConsoleColor)12;
Console.Write("Bir sayı girin: ");
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 5 == 0)
{
    Console.BackgroundColor = (ConsoleColor)14;
    Console.Clear();
}
else if (sayi % 2 == 0)
{
    Console.BackgroundColor = (ConsoleColor)9;
    Console.Clear();
}
else
{
    Console.BackgroundColor = (ConsoleColor)10;
    Console.Clear();
}
Console.ReadKey();
// 5'in katı olma kontrolü ÖNCE yapılmalı — yoksa 10 gibi hem çift hem 5'in katı
// olan bir sayı, hep "çift" dalına düşer, üçüncü renk hiç kullanılmaz.
