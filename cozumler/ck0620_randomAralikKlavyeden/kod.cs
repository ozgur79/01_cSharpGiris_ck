int min, max, kacAdet;
Random rastgele = new Random();

Console.Write("Kaç sayı tutulacak: ");
kacAdet = Convert.ToInt32(Console.ReadLine());
Console.Write("Tutulacak sayının min değeri: ");
min = Convert.ToInt32(Console.ReadLine());
Console.Write("Tutulacak sayının max değeri: ");
max = Convert.ToInt32(Console.ReadLine());

if (min >= max)
{
    Console.WriteLine("max, min'den büyük olmalı!");
}
else
{
    for (int i = 0; i < kacAdet; i++)
    {
        int tutulansayi = rastgele.Next(min, max);
        Console.WriteLine("Bilgisayarın tuttuğu sayı: " + tutulansayi);
    }
}
Console.ReadKey();
