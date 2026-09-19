Console.Write("Kaç adet sayı üretilsin: ");
int adet = Convert.ToInt32(Console.ReadLine());

Random rastgele = new Random();
for (int i = 0; i < adet; i++)
{
    int tutulansayi = rastgele.Next(0, 10);
    Console.WriteLine("Bilgisayarın tuttuğu sayı: " + tutulansayi);
}
Console.ReadKey();
