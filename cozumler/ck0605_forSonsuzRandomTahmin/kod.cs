Random rastgele = new Random();
int tutulansayi = rastgele.Next(0, 100);
int sayac = 0;

for (; ; )
{
    Console.Write("Sayıyı tahmin edin: ");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    sayac++;
    if (tahmin > tutulansayi)
        Console.WriteLine("Daha küçük bir sayı yazın.");
    else if (tahmin < tutulansayi)
        Console.WriteLine("Daha büyük bir sayı yazın.");
    else
    {
        Console.WriteLine(sayac + " tahminde bildiniz!");
        break;
    }
}
Console.ReadKey();
