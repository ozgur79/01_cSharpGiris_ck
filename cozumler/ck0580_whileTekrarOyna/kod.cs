int devam = 1;
int oyunSayisi = 0;
while (devam == 1)
{
    Random rastgele = new Random();
    int sayi = rastgele.Next(1, 10);
    oyunSayisi++;

    Console.Write("1 ile 9 arasında bir sayı tahmin edin: ");
    int tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin == sayi)
        Console.WriteLine("Bildiniz! Sayı: " + sayi);
    else
        Console.WriteLine("Bilemediniz, sayı: " + sayi + " idi.");

    Console.Write("Tekrar oynamak ister misiniz? (E/H): ");
    string tekrar = Console.ReadLine();
    if (tekrar == "H" || tekrar == "h")
        devam = 0;
}
Console.WriteLine("Toplam " + oyunSayisi + " kez oynadınız.");
Console.ReadKey();
