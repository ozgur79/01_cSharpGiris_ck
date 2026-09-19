Console.Write("Hangi sayıda durayım? ");
int cikisSayisi = Convert.ToInt32(Console.ReadLine());

int toplam = 0;
int sayi;
do
{
    Console.Write("Sayı girin (çıkmak için " + cikisSayisi + "): ");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam = toplam + sayi;
} while (sayi != cikisSayisi);
Console.WriteLine("Genel toplam: " + toplam);
Console.ReadKey();
