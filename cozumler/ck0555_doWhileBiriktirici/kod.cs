int toplam = 0;
int sayi;
do
{
    Console.Write("Sayı girin (çıkmak için 0): ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi > 0)
        toplam = toplam + sayi;
} while (sayi != 0);
Console.WriteLine("Genel toplam: " + toplam);
Console.ReadKey();
