int tutulansayi, tahmin, hak = 5;
Random rastgele = new Random();
tutulansayi = rastgele.Next(0, 50);

do
{
    Console.Write("Sayıyı tahmin edin (" + hak + " hakkınız var): ");
    tahmin = Convert.ToInt32(Console.ReadLine());
    if (tahmin > tutulansayi)
        Console.WriteLine("Daha küçük bir sayı yazın.");
    else if (tahmin < tutulansayi)
        Console.WriteLine("Daha büyük bir sayı yazın.");
    else
        Console.WriteLine("Bildiniz!");
    hak--;
} while (tahmin != tutulansayi && hak > 0);

Console.WriteLine("Oyun bitti.");
Console.ReadKey();
